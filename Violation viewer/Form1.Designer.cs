namespace Violation_viewer
{
    partial class UI
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.listName = new System.Windows.Forms.ListBox();
            this.imdBox = new System.Windows.Forms.PictureBox();
            this.SelectFolder = new System.Windows.Forms.TextBox();
            this.FolderSave = new System.Windows.Forms.TextBox();
            this.SelecDownloadFolder = new System.Windows.Forms.Button();
            this.SelectFolderSave = new System.Windows.Forms.Button();
            this.SaveCurrent = new System.Windows.Forms.Button();
            this.SaveAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imdBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listName
            // 
            this.listName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listName.FormattingEnabled = true;
            this.listName.ItemHeight = 20;
            this.listName.Location = new System.Drawing.Point(3, 4);
            this.listName.Name = "listName";
            this.listName.Size = new System.Drawing.Size(200, 724);
            this.listName.TabIndex = 0;
            // 
            // imdBox
            // 
            this.imdBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imdBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.imdBox.Location = new System.Drawing.Point(207, 4);
            this.imdBox.Name = "imdBox";
            this.imdBox.Size = new System.Drawing.Size(1280, 720);
            this.imdBox.TabIndex = 2;
            this.imdBox.TabStop = false;
            // 
            // SelectFolder
            // 
            this.SelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFolder.Location = new System.Drawing.Point(207, 736);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(500, 26);
            this.SelectFolder.TabIndex = 1;
            // 
            // FolderSave
            // 
            this.FolderSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FolderSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderSave.Location = new System.Drawing.Point(712, 736);
            this.FolderSave.Name = "FolderSave";
            this.FolderSave.Size = new System.Drawing.Size(500, 26);
            this.FolderSave.TabIndex = 1;
            // 
            // SelecDownloadFolder
            // 
            this.SelecDownloadFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelecDownloadFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SelecDownloadFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelecDownloadFolder.Location = new System.Drawing.Point(207, 770);
            this.SelecDownloadFolder.Name = "SelecDownloadFolder";
            this.SelecDownloadFolder.Size = new System.Drawing.Size(500, 40);
            this.SelecDownloadFolder.TabIndex = 2;
            this.SelecDownloadFolder.Text = "Select download folder";
            this.SelecDownloadFolder.UseVisualStyleBackColor = true;
            this.SelecDownloadFolder.Click += new System.EventHandler(this.Select_Click);
            // 
            // SelectFolderSave
            // 
            this.SelectFolderSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SelectFolderSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SelectFolderSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFolderSave.Location = new System.Drawing.Point(712, 770);
            this.SelectFolderSave.Name = "SelectFolderSave";
            this.SelectFolderSave.Size = new System.Drawing.Size(500, 40);
            this.SelectFolderSave.TabIndex = 2;
            this.SelectFolderSave.Text = "Select a folder to save";
            this.SelectFolderSave.UseVisualStyleBackColor = true;
            // 
            // SaveCurrent
            // 
            this.SaveCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveCurrent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCurrent.Location = new System.Drawing.Point(1218, 732);
            this.SaveCurrent.Name = "SaveCurrent";
            this.SaveCurrent.Size = new System.Drawing.Size(270, 40);
            this.SaveCurrent.TabIndex = 6;
            this.SaveCurrent.Text = "Save current";
            this.SaveCurrent.UseVisualStyleBackColor = true;
            this.SaveCurrent.Click += new System.EventHandler(this.SaveCurrent_Click);
            // 
            // SaveAll
            // 
            this.SaveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAll.Location = new System.Drawing.Point(1218, 774);
            this.SaveAll.Name = "SaveAll";
            this.SaveAll.Size = new System.Drawing.Size(270, 40);
            this.SaveAll.TabIndex = 7;
            this.SaveAll.Text = "Save all";
            this.SaveAll.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 740);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 71);
            this.button1.TabIndex = 9;
            this.button1.Text = "Сlear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UI
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1499, 821);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveAll);
            this.Controls.Add(this.SaveCurrent);
            this.Controls.Add(this.SelectFolderSave);
            this.Controls.Add(this.SelecDownloadFolder);
            this.Controls.Add(this.FolderSave);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.imdBox);
            this.Controls.Add(this.listName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1515, 860);
            this.Name = "UI";
            this.Text = "Violation viewer";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.UI_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.UI_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.imdBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listName;
        private System.Windows.Forms.PictureBox imdBox;
        private System.Windows.Forms.TextBox SelectFolder;
        private System.Windows.Forms.TextBox FolderSave;
        private System.Windows.Forms.Button SelecDownloadFolder;
        private System.Windows.Forms.Button SelectFolderSave;
        private System.Windows.Forms.Button SaveCurrent;
        private System.Windows.Forms.Button SaveAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

