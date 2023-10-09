namespace GDAPITest
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btListFiles = new System.Windows.Forms.Button();
            this.btCreateFolder = new System.Windows.Forms.Button();
            this.btUploadFile = new System.Windows.Forms.Button();
            this.btDownloadFile = new System.Windows.Forms.Button();
            this.btUpdateFile = new System.Windows.Forms.Button();
            this.btDeleteFile = new System.Windows.Forms.Button();
            this.lbxRoot = new System.Windows.Forms.ListBox();
            this.lbxFiles = new System.Windows.Forms.ListBox();
            this.edId = new System.Windows.Forms.TextBox();
            this.edFolderName = new System.Windows.Forms.TextBox();
            this.edParentFolderId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edSubFolderId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edFileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edFileId = new System.Windows.Forms.TextBox();
            this.btUpdateName = new System.Windows.Forms.Button();
            this.btTrashFile = new System.Windows.Forms.Button();
            this.btMoveFile = new System.Windows.Forms.Button();
            this.btShowInfo = new System.Windows.Forms.Button();
            this.edFileInfo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btListFiles
            // 
            this.btListFiles.Location = new System.Drawing.Point(13, 14);
            this.btListFiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btListFiles.Name = "btListFiles";
            this.btListFiles.Size = new System.Drawing.Size(177, 45);
            this.btListFiles.TabIndex = 0;
            this.btListFiles.Text = "列出目錄(2)檔案";
            this.btListFiles.UseVisualStyleBackColor = true;
            this.btListFiles.Click += new System.EventHandler(this.btListFiles_Click);
            // 
            // btCreateFolder
            // 
            this.btCreateFolder.Location = new System.Drawing.Point(13, 124);
            this.btCreateFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCreateFolder.Name = "btCreateFolder";
            this.btCreateFolder.Size = new System.Drawing.Size(177, 45);
            this.btCreateFolder.TabIndex = 1;
            this.btCreateFolder.Text = "建立目錄 12>3";
            this.btCreateFolder.UseVisualStyleBackColor = true;
            this.btCreateFolder.Click += new System.EventHandler(this.btCreateFolder_Click);
            // 
            // btUploadFile
            // 
            this.btUploadFile.Location = new System.Drawing.Point(13, 179);
            this.btUploadFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btUploadFile.Name = "btUploadFile";
            this.btUploadFile.Size = new System.Drawing.Size(177, 45);
            this.btUploadFile.TabIndex = 2;
            this.btUploadFile.Text = "上傳檔案 24>5";
            this.btUploadFile.UseVisualStyleBackColor = true;
            this.btUploadFile.Click += new System.EventHandler(this.btUploadFile_Click);
            // 
            // btDownloadFile
            // 
            this.btDownloadFile.Location = new System.Drawing.Point(13, 234);
            this.btDownloadFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDownloadFile.Name = "btDownloadFile";
            this.btDownloadFile.Size = new System.Drawing.Size(177, 45);
            this.btDownloadFile.TabIndex = 3;
            this.btDownloadFile.Text = "下載檔案 45";
            this.btDownloadFile.UseVisualStyleBackColor = true;
            this.btDownloadFile.Click += new System.EventHandler(this.btDownloadFile_Click);
            // 
            // btUpdateFile
            // 
            this.btUpdateFile.Location = new System.Drawing.Point(13, 289);
            this.btUpdateFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btUpdateFile.Name = "btUpdateFile";
            this.btUpdateFile.Size = new System.Drawing.Size(177, 45);
            this.btUpdateFile.TabIndex = 4;
            this.btUpdateFile.Text = "更新檔案 45";
            this.btUpdateFile.UseVisualStyleBackColor = true;
            this.btUpdateFile.Click += new System.EventHandler(this.btUpdateFile_Click);
            // 
            // btDeleteFile
            // 
            this.btDeleteFile.Location = new System.Drawing.Point(13, 509);
            this.btDeleteFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDeleteFile.Name = "btDeleteFile";
            this.btDeleteFile.Size = new System.Drawing.Size(177, 45);
            this.btDeleteFile.TabIndex = 5;
            this.btDeleteFile.Text = "目錄檔案刪除 5";
            this.btDeleteFile.UseVisualStyleBackColor = true;
            this.btDeleteFile.Click += new System.EventHandler(this.btDeleteFile_Click);
            // 
            // lbxRoot
            // 
            this.lbxRoot.FormattingEnabled = true;
            this.lbxRoot.ItemHeight = 25;
            this.lbxRoot.Location = new System.Drawing.Point(488, 56);
            this.lbxRoot.Name = "lbxRoot";
            this.lbxRoot.Size = new System.Drawing.Size(632, 179);
            this.lbxRoot.TabIndex = 7;
            this.lbxRoot.SelectedIndexChanged += new System.EventHandler(this.lbxRoot_SelectedIndexChanged);
            // 
            // lbxFiles
            // 
            this.lbxFiles.FormattingEnabled = true;
            this.lbxFiles.ItemHeight = 25;
            this.lbxFiles.Location = new System.Drawing.Point(488, 250);
            this.lbxFiles.Name = "lbxFiles";
            this.lbxFiles.Size = new System.Drawing.Size(632, 204);
            this.lbxFiles.TabIndex = 8;
            this.lbxFiles.SelectedIndexChanged += new System.EventHandler(this.lbxFiles_SelectedIndexChanged);
            // 
            // edId
            // 
            this.edId.Location = new System.Drawing.Point(488, 13);
            this.edId.Name = "edId";
            this.edId.Size = new System.Drawing.Size(632, 34);
            this.edId.TabIndex = 9;
            // 
            // edFolderName
            // 
            this.edFolderName.Location = new System.Drawing.Point(211, 44);
            this.edFolderName.Name = "edFolderName";
            this.edFolderName.Size = new System.Drawing.Size(271, 34);
            this.edFolderName.TabIndex = 10;
            this.edFolderName.Text = "CBETA-User-Data";
            // 
            // edParentFolderId
            // 
            this.edParentFolderId.Location = new System.Drawing.Point(211, 114);
            this.edParentFolderId.Name = "edParentFolderId";
            this.edParentFolderId.Size = new System.Drawing.Size(271, 34);
            this.edParentFolderId.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "1.目錄名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "2.父目錄ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "3.子目錄ID";
            // 
            // edSubFolderId
            // 
            this.edSubFolderId.Location = new System.Drawing.Point(211, 186);
            this.edSubFolderId.Name = "edSubFolderId";
            this.edSubFolderId.Size = new System.Drawing.Size(271, 34);
            this.edSubFolderId.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "4.檔名";
            // 
            // edFileName
            // 
            this.edFileName.Location = new System.Drawing.Point(211, 262);
            this.edFileName.Name = "edFileName";
            this.edFileName.Size = new System.Drawing.Size(271, 34);
            this.edFileName.TabIndex = 18;
            this.edFileName.Text = "bookmark.json";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "5.目錄/檔案ID";
            // 
            // edFileId
            // 
            this.edFileId.Location = new System.Drawing.Point(211, 334);
            this.edFileId.Name = "edFileId";
            this.edFileId.Size = new System.Drawing.Size(271, 34);
            this.edFileId.TabIndex = 20;
            // 
            // btUpdateName
            // 
            this.btUpdateName.Location = new System.Drawing.Point(13, 344);
            this.btUpdateName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btUpdateName.Name = "btUpdateName";
            this.btUpdateName.Size = new System.Drawing.Size(177, 45);
            this.btUpdateName.TabIndex = 22;
            this.btUpdateName.Text = "目錄檔案更名 45";
            this.btUpdateName.UseVisualStyleBackColor = true;
            this.btUpdateName.Click += new System.EventHandler(this.btUpdateName_Click);
            // 
            // btTrashFile
            // 
            this.btTrashFile.Location = new System.Drawing.Point(13, 454);
            this.btTrashFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTrashFile.Name = "btTrashFile";
            this.btTrashFile.Size = new System.Drawing.Size(177, 45);
            this.btTrashFile.TabIndex = 23;
            this.btTrashFile.Text = "目錄檔案回收 5";
            this.btTrashFile.UseVisualStyleBackColor = true;
            this.btTrashFile.Click += new System.EventHandler(this.btTrashFile_Click);
            // 
            // btMoveFile
            // 
            this.btMoveFile.Location = new System.Drawing.Point(13, 399);
            this.btMoveFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btMoveFile.Name = "btMoveFile";
            this.btMoveFile.Size = new System.Drawing.Size(177, 45);
            this.btMoveFile.TabIndex = 24;
            this.btMoveFile.Text = "目錄檔案移動 25";
            this.btMoveFile.UseVisualStyleBackColor = true;
            this.btMoveFile.Click += new System.EventHandler(this.btMoveFile_Click);
            // 
            // btShowInfo
            // 
            this.btShowInfo.Location = new System.Drawing.Point(13, 69);
            this.btShowInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btShowInfo.Name = "btShowInfo";
            this.btShowInfo.Size = new System.Drawing.Size(177, 45);
            this.btShowInfo.TabIndex = 25;
            this.btShowInfo.Text = "顯示資訊 5>246";
            this.btShowInfo.UseVisualStyleBackColor = true;
            this.btShowInfo.Click += new System.EventHandler(this.btShowInfo_Click);
            // 
            // edFileInfo
            // 
            this.edFileInfo.Location = new System.Drawing.Point(213, 488);
            this.edFileInfo.Name = "edFileInfo";
            this.edFileInfo.Size = new System.Drawing.Size(906, 34);
            this.edFileInfo.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "6.資訊";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 621);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.edFileInfo);
            this.Controls.Add(this.btShowInfo);
            this.Controls.Add(this.btMoveFile);
            this.Controls.Add(this.btTrashFile);
            this.Controls.Add(this.btUpdateName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edFileId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edSubFolderId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edParentFolderId);
            this.Controls.Add(this.edFolderName);
            this.Controls.Add(this.edId);
            this.Controls.Add(this.lbxFiles);
            this.Controls.Add(this.lbxRoot);
            this.Controls.Add(this.btDeleteFile);
            this.Controls.Add(this.btUpdateFile);
            this.Controls.Add(this.btDownloadFile);
            this.Controls.Add(this.btUploadFile);
            this.Controls.Add(this.btCreateFolder);
            this.Controls.Add(this.btListFiles);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Google Drive Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btListFiles;
        private System.Windows.Forms.Button btCreateFolder;
        private System.Windows.Forms.Button btUploadFile;
        private System.Windows.Forms.Button btDownloadFile;
        private System.Windows.Forms.Button btUpdateFile;
        private System.Windows.Forms.Button btDeleteFile;
        private System.Windows.Forms.ListBox lbxRoot;
        private System.Windows.Forms.ListBox lbxFiles;
        private System.Windows.Forms.TextBox edId;
        private System.Windows.Forms.TextBox edFolderName;
        private System.Windows.Forms.TextBox edParentFolderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edSubFolderId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edFileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edFileId;
        private System.Windows.Forms.Button btUpdateName;
        private System.Windows.Forms.Button btTrashFile;
        private System.Windows.Forms.Button btMoveFile;
        private System.Windows.Forms.Button btShowInfo;
        private System.Windows.Forms.TextBox edFileInfo;
        private System.Windows.Forms.Label label7;
    }
}

