using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using File = Google.Apis.Drive.v3.Data.File;
using static System.Net.WebRequestMethods;

namespace GDAPITest
{
    public partial class MainForm : Form
    {
        string CredentialPath = ".credentials/drive-dotnet-quickstart.json";    // 記錄授權
        string ApplicationName = "GDAPITest";    // 程式名稱
        string[] Scopes = { DriveService.Scope.DriveFile };  // 授權範圍
        DriveService service; // 將服務設為全域變數，以免每次都要重新授權，但若過期時，就不知如何處理了？待研究

        public MainForm()
        {
            InitializeComponent();
            service = GetDriveService();    // 取得授權
        }

        // 取得 Google 服務

        private DriveService GetDriveService()
        {
            UserCredential credential;

            using (var stream = new FileStream("client_id.json", FileMode.Open, FileAccess.Read)) {
                string credPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, CredentialPath);

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            DriveService service = new DriveService(new BaseClientService.Initializer() {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            return service;
        }

        // 列出目錄及所有檔案

        private void btListFiles_Click(object sender, EventArgs e)
        {
            // DriveService service = GetDriveService();

            string parentFolderId = edParentFolderId.Text;
            if(parentFolderId == "") {
                parentFolderId = "file";
            }

            // 列出您的應用程式建立的檔案
            IList<File> folders = ListFiles(service, "root");   // 列出根目錄的資料
            IList<File> files = ListFiles(service, parentFolderId);     // 列出子目錄或非根目錄的資料

            lbxRoot.Items.Clear();
            lbxFiles.Items.Clear();

            // 將根目錄資料列在 ListBox 上
            if (folders != null && folders.Count > 0) {
                foreach (var file in folders) {
                    lbxRoot.Items.Add($"{file.Name} ({file.Id})");
                }
            } else {
                MessageBox.Show("No files found.");
            }

            // 將非根目錄資料列在 ListBox 上
            if (files != null && files.Count > 0) {
                foreach (var file in files) {
                    lbxFiles.Items.Add($"{file.Name} ({file.Id})");
                }
            } else {
                MessageBox.Show("No folders found.");
            }
        }

        private static IList<File> ListFiles(DriveService service, string root_or_file)
        {
            string request = $"'{root_or_file}'";
            if (root_or_file == "file") {
                request = "not 'root'";
            }

            try {
                FilesResource.ListRequest listRequest = service.Files.List();
                // 查詢根目錄中的檔案
                // listRequest.Q = "" 列出全部目錄檔案
                // 'root' in parents 會列出根目錄檔案
                // not 'root' in parents 會列出所有非根目錄檔案
                // '{id}' in parents 則會列出指定目錄下的檔案
                listRequest.Q = "name contains 'CBETA' and trashed = true";//request + " in parents"; 
                // nextPageToken 應該是要傳回下一頁用的，此處沒處理。
                listRequest.Fields = "nextPageToken, files(id, name)";  
                FileList files = listRequest.Execute();
                return files.Files;
            } catch (Exception e) {
                MessageBox.Show($"錯誤: {e.Message}");
                return null;
            }
        }

        // 列出許多資訊

        private void btShowInfo_Click(object sender, EventArgs e)
        {
            // DriveService service = GetDriveService();

            string fileId = edFileId.Text;
            if(fileId == "") { return; }

            // 取得各種屬性
            FilesResource.GetRequest request = service.Files.Get(fileId);
            request.Fields = "name, parents, size, createdTime, modifiedTime";
            File file = request.Execute();

            edParentFolderId.Text = file.Parents[0].ToString(); // 取得目錄名
            edFileName.Text = file.Name;                        // 取得檔名
            string size = file.Size.ToString();                 // 取得檔案大小
            string createdTime = file.CreatedTime.ToString();   // 取得建檔日期
            string modifiedTime = file.ModifiedTime.ToString(); // 取得修改日期

            edFileInfo.Text = $"【建立時間】{createdTime} 【修改時間】{modifiedTime} 【檔案大小】{size}";
        }

        // 建立目錄

        private void btCreateFolder_Click(object sender, EventArgs e)
        {
            // 要創建的目錄的名稱
            string folderName = edFolderName.Text;
            // 父目錄 ID，若是最上層則空白即可，或是用 root
            string parentFolderId = edParentFolderId.Text;

            // 創建目錄
            CreateFolderInDrive(folderName, parentFolderId);
        }

        private void CreateFolderInDrive(string folderName, string parentFolderId)
        {
            // DriveService service = GetDriveService();

            // 如果沒有指定父目錄，則用 root 為根目錄
            if(parentFolderId == "") {
                parentFolderId = "root";
            }

            // 創建 File 實例
            File fileMetadata = new File {
                Name = folderName,
                MimeType = "application/vnd.google-apps.folder",
                Parents = new List<string> { parentFolderId }
            };

            // 建立目錄
            var request = service.Files.Create(fileMetadata);
            // request.Fields = "id";          // 僅取回 id 屬性，亦可忽略不寫
            var folder = request.Execute();

            // 打印新子目錄的ID
            if (folder != null) {
                edSubFolderId.Text = folder.Id;
                MessageBox.Show($"建立目錄 ID：{folder.Id}");
            } else {
                MessageBox.Show("建立目錄失敗。");
            }
        }

        // 上傳檔案

        private void btUploadFile_Click(object sender, EventArgs e)
        {
            string fileName = edFileName.Text;
            string parentFolderId = edParentFolderId.Text;

            UploadFileToDrive(fileName, parentFolderId);
        }

        private void UploadFileToDrive(string fileName, string parentFolderId)
        {
            // DriveService service = GetDriveService();
            
            // 如果沒有指定父目錄，則用 root 為根目錄
            if (parentFolderId == "") {
                parentFolderId = "root";
            }

            // 創建 File 實例
            var fileMetadata = new File() {
                Name = Path.GetFileName(fileName),
                Parents = new List<string> { parentFolderId }
            };

            FilesResource.CreateMediaUpload request;

            using (var stream = new FileStream(fileName, FileMode.Open)) {
                request = service.Files.Create(fileMetadata, stream, GetMimeType(fileName));
                request.Fields = "id";      // 返回文件的ID
                request.Upload();
            }

            var file = request.ResponseBody;
            edFileId.Text = file.Id;
            MessageBox.Show($"檔案 ID：{file.Id}");
        }

        // 抄來的，取得 MineType
        private string GetMimeType(string filePath)
        {
            string mimeType = "application/unknown";
            string ext = Path.GetExtension(filePath).ToLower();
            Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext);
            if (regKey != null && regKey.GetValue("Content Type") != null) {
                mimeType = regKey.GetValue("Content Type").ToString();
            }
            return mimeType;
        }

        // 下載檔案，此處會直接覆蓋，並沒有檢查檔案是否存在
        // 不能直接下載目錄

        private void btDownloadFile_Click(object sender, EventArgs e)
        {
            string fileId = edFileId.Text;
            string newFileName = edFileName.Text;

            DownloadFile(newFileName, fileId);
        }

        private void DownloadFile(string newFileName, string fileId)
        {
            // DriveService service = GetDriveService();

            var request = service.Files.Get(fileId);
            using (var stream = new FileStream(newFileName, FileMode.Create)) {
                request.Download(stream);
            }
            MessageBox.Show("OK");
        }

        // 更新檔案

        private void btUpdateFile_Click(object sender, EventArgs e)
        {
            string uploadFile = edFileName.Text;
            string fileId = edFileId.Text;

            // 把檔案檔尾加上一行，模擬編輯文件
            System.IO.File.AppendAllText(uploadFile, "\nAppended text at " + DateTime.Now);

            // 上傳檔案
            UpdateFile(uploadFile, fileId);
        }

        private void UpdateFile(string fileName, string fileId)
        {
            // DriveService service = GetDriveService();

            var fileMetadata = new File() {
                Name = Path.GetFileName(fileName)
            };

            FilesResource.UpdateMediaUpload request;

            using (var stream = new FileStream(fileName, FileMode.Open)) {
                request = service.Files.Update(fileMetadata, fileId, stream, GetMimeType(fileName));
                request.Fields = "id";
                request.Upload();
            }

            // var file = request.ResponseBody;
            MessageBox.Show("OK");
        }

        // 目錄或檔案更名

        private void btUpdateName_Click(object sender, EventArgs e)
        {
            // DriveService service = GetDriveService();
            
            string fileId = edFileId.Text;
            string newFileName = edFileName.Text;

            File file = new File();
            file.Name = newFileName;

            service.Files.Update(file, fileId).Execute();
            MessageBox.Show("OK");
        }

        // 目錄檔案移動

        private void btMoveFile_Click(object sender, EventArgs e)
        {
            string fileId = edFileId.Text;
            string parentFolderId = edParentFolderId.Text;

            // 若目的目錄空白，就移到根目錄
            if(parentFolderId == "") {
                parentFolderId = "root";
            }

            File file = new File();

            FilesResource.UpdateRequest request = service.Files.Update(file, fileId);
            // Update 時，不能直接修改 Parent 屬性，要用 AddParents
            request.AddParents = parentFolderId;
            request.Execute();
            MessageBox.Show("OK");
        }

        // 回收檔案或目錄

        private void btTrashFile_Click(object sender, EventArgs e)
        {
            // DriveService service = GetDriveService();

            string fileId = edFileId.Text;

            // 取得是否在垃圾桶的屬性
            FilesResource.GetRequest request = service.Files.Get(fileId);
            request.Fields = "trashed";
            File file = request.Execute();

            // 變更是否在垃圾桶的屬性
            file.Trashed = !file.Trashed;
            service.Files.Update(file, fileId).Execute();

            MessageBox.Show("OK");
        }

        // 刪除目錄或檔案

        private void btDeleteFile_Click(object sender, EventArgs e)
        {
            string fileId = edFileId.Text;
            // DriveService service = GetDriveService();
            service.Files.Delete(fileId).Execute();
            MessageBox.Show("OK");
        }

        /// ///////////////////////////////////////////////

        private void lbxRoot_SelectedIndexChanged(object sender, EventArgs e)
        {
            edId.Text = lbxRoot.Items[lbxRoot.SelectedIndex].ToString();
        }

        private void lbxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            edId.Text = lbxFiles.Items[lbxFiles.SelectedIndex].ToString();
        }
    }
}
