namespace FileBuilder
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.InfoTabControl = new System.Windows.Forms.TabControl();
            this.dbInfoTab = new System.Windows.Forms.TabPage();
            this.sqlTextBox = new System.Windows.Forms.TextBox();
            this.SQL = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.dbNameTextBox = new System.Windows.Forms.TextBox();
            this.dbName = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.Label();
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.host = new System.Windows.Forms.Label();
            this.FileInfoTabPage = new System.Windows.Forms.TabPage();
            this.codePageLink = new System.Windows.Forms.LinkLabel();
            this.separatorTypeComboBox = new System.Windows.Forms.ComboBox();
            this.separatorType = new System.Windows.Forms.Label();
            this.separatorTextBox = new System.Windows.Forms.TextBox();
            this.separator = new System.Windows.Forms.Label();
            this.charsetTextBox = new System.Windows.Forms.TextBox();
            this.fileCharset = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.fileInfoTextBox = new System.Windows.Forms.TextBox();
            this.builderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.InfoTabControl.SuspendLayout();
            this.dbInfoTab.SuspendLayout();
            this.FileInfoTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.InfoTabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1309, 764);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.TabIndex = 0;
            // 
            // InfoTabControl
            // 
            this.InfoTabControl.Controls.Add(this.dbInfoTab);
            this.InfoTabControl.Controls.Add(this.FileInfoTabPage);
            this.InfoTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoTabControl.Location = new System.Drawing.Point(0, 0);
            this.InfoTabControl.Name = "InfoTabControl";
            this.InfoTabControl.SelectedIndex = 0;
            this.InfoTabControl.Size = new System.Drawing.Size(1309, 145);
            this.InfoTabControl.TabIndex = 0;
            // 
            // dbInfoTab
            // 
            this.dbInfoTab.Controls.Add(this.sqlTextBox);
            this.dbInfoTab.Controls.Add(this.SQL);
            this.dbInfoTab.Controls.Add(this.passwordTextBox);
            this.dbInfoTab.Controls.Add(this.password);
            this.dbInfoTab.Controls.Add(this.userNameTextBox);
            this.dbInfoTab.Controls.Add(this.userName);
            this.dbInfoTab.Controls.Add(this.dbNameTextBox);
            this.dbInfoTab.Controls.Add(this.dbName);
            this.dbInfoTab.Controls.Add(this.portTextBox);
            this.dbInfoTab.Controls.Add(this.port);
            this.dbInfoTab.Controls.Add(this.hostTextBox);
            this.dbInfoTab.Controls.Add(this.host);
            this.dbInfoTab.Location = new System.Drawing.Point(4, 22);
            this.dbInfoTab.Name = "dbInfoTab";
            this.dbInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.dbInfoTab.Size = new System.Drawing.Size(1301, 119);
            this.dbInfoTab.TabIndex = 0;
            this.dbInfoTab.Text = "数据库信息";
            this.dbInfoTab.UseVisualStyleBackColor = true;
            // 
            // sqlTextBox
            // 
            this.sqlTextBox.Location = new System.Drawing.Point(51, 54);
            this.sqlTextBox.Multiline = true;
            this.sqlTextBox.Name = "sqlTextBox";
            this.sqlTextBox.Size = new System.Drawing.Size(1242, 59);
            this.sqlTextBox.TabIndex = 11;
            // 
            // SQL
            // 
            this.SQL.AutoSize = true;
            this.SQL.Location = new System.Drawing.Point(8, 57);
            this.SQL.Name = "SQL";
            this.SQL.Size = new System.Drawing.Size(31, 13);
            this.SQL.TabIndex = 10;
            this.SQL.Text = "SQL:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(923, 7);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(119, 20);
            this.passwordTextBox.TabIndex = 9;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(880, 10);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(34, 13);
            this.password.TabIndex = 8;
            this.password.Text = "密码:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(713, 7);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.userNameTextBox.TabIndex = 7;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(661, 10);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(46, 13);
            this.userName.TabIndex = 6;
            this.userName.Text = "用户名:";
            // 
            // dbNameTextBox
            // 
            this.dbNameTextBox.Location = new System.Drawing.Point(498, 7);
            this.dbNameTextBox.Name = "dbNameTextBox";
            this.dbNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.dbNameTextBox.TabIndex = 5;
            // 
            // dbName
            // 
            this.dbName.AutoSize = true;
            this.dbName.Location = new System.Drawing.Point(434, 10);
            this.dbName.Name = "dbName";
            this.dbName.Size = new System.Drawing.Size(58, 13);
            this.dbName.TabIndex = 4;
            this.dbName.Text = "数据库名:";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(266, 7);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 20);
            this.portTextBox.TabIndex = 3;
            this.portTextBox.Text = "3306";
            // 
            // port
            // 
            this.port.AutoSize = true;
            this.port.Location = new System.Drawing.Point(223, 10);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(34, 13);
            this.port.TabIndex = 2;
            this.port.Text = "端口:";
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(51, 7);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(118, 20);
            this.hostTextBox.TabIndex = 1;
            // 
            // host
            // 
            this.host.AutoSize = true;
            this.host.Location = new System.Drawing.Point(8, 10);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(30, 13);
            this.host.TabIndex = 0;
            this.host.Text = "host:";
            // 
            // FileInfoTabPage
            // 
            this.FileInfoTabPage.Controls.Add(this.codePageLink);
            this.FileInfoTabPage.Controls.Add(this.separatorTypeComboBox);
            this.FileInfoTabPage.Controls.Add(this.separatorType);
            this.FileInfoTabPage.Controls.Add(this.separatorTextBox);
            this.FileInfoTabPage.Controls.Add(this.separator);
            this.FileInfoTabPage.Controls.Add(this.charsetTextBox);
            this.FileInfoTabPage.Controls.Add(this.fileCharset);
            this.FileInfoTabPage.Location = new System.Drawing.Point(4, 22);
            this.FileInfoTabPage.Name = "FileInfoTabPage";
            this.FileInfoTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FileInfoTabPage.Size = new System.Drawing.Size(1301, 119);
            this.FileInfoTabPage.TabIndex = 1;
            this.FileInfoTabPage.Text = "文件信息";
            this.FileInfoTabPage.UseVisualStyleBackColor = true;
            // 
            // codePageLink
            // 
            this.codePageLink.AutoSize = true;
            this.codePageLink.LinkVisited = true;
            this.codePageLink.Location = new System.Drawing.Point(7, 55);
            this.codePageLink.Name = "codePageLink";
            this.codePageLink.Size = new System.Drawing.Size(164, 13);
            this.codePageLink.TabIndex = 12;
            this.codePageLink.TabStop = true;
            this.codePageLink.Text = "文件编码参考ANSI代码页索引";
            this.codePageLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CodePageLink_click);
            // 
            // separatorTypeComboBox
            // 
            this.separatorTypeComboBox.FormattingEnabled = true;
            this.separatorTypeComboBox.Items.AddRange(new object[] {
            "字符串",
            "ASCII"});
            this.separatorTypeComboBox.Location = new System.Drawing.Point(523, 6);
            this.separatorTypeComboBox.Name = "separatorTypeComboBox";
            this.separatorTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.separatorTypeComboBox.TabIndex = 11;
            // 
            // separatorType
            // 
            this.separatorType.AutoSize = true;
            this.separatorType.Location = new System.Drawing.Point(450, 12);
            this.separatorType.Name = "separatorType";
            this.separatorType.Size = new System.Drawing.Size(67, 13);
            this.separatorType.TabIndex = 10;
            this.separatorType.Text = "分隔符类型:";
            // 
            // separatorTextBox
            // 
            this.separatorTextBox.Location = new System.Drawing.Point(307, 9);
            this.separatorTextBox.Name = "separatorTextBox";
            this.separatorTextBox.Size = new System.Drawing.Size(100, 20);
            this.separatorTextBox.TabIndex = 9;
            // 
            // separator
            // 
            this.separator.AutoSize = true;
            this.separator.Location = new System.Drawing.Point(231, 12);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(70, 13);
            this.separator.TabIndex = 8;
            this.separator.Text = "字段分隔符:";
            // 
            // charsetTextBox
            // 
            this.charsetTextBox.Location = new System.Drawing.Point(70, 6);
            this.charsetTextBox.Name = "charsetTextBox";
            this.charsetTextBox.Size = new System.Drawing.Size(100, 20);
            this.charsetTextBox.TabIndex = 7;
            // 
            // fileCharset
            // 
            this.fileCharset.AutoSize = true;
            this.fileCharset.Location = new System.Drawing.Point(6, 9);
            this.fileCharset.Name = "fileCharset";
            this.fileCharset.Size = new System.Drawing.Size(58, 13);
            this.fileCharset.TabIndex = 6;
            this.fileCharset.Text = "文件编码:";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.fileInfoTextBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.builderButton);
            this.splitContainer2.Size = new System.Drawing.Size(1309, 615);
            this.splitContainer2.SplitterDistance = 1004;
            this.splitContainer2.TabIndex = 0;
            // 
            // fileInfoTextBox
            // 
            this.fileInfoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileInfoTextBox.Location = new System.Drawing.Point(0, 0);
            this.fileInfoTextBox.Multiline = true;
            this.fileInfoTextBox.Name = "fileInfoTextBox";
            this.fileInfoTextBox.Size = new System.Drawing.Size(1004, 615);
            this.fileInfoTextBox.TabIndex = 0;
            // 
            // builderButton
            // 
            this.builderButton.BackColor = System.Drawing.Color.LightGreen;
            this.builderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.builderButton.Font = new System.Drawing.Font("STSong", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.builderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.builderButton.Location = new System.Drawing.Point(0, 0);
            this.builderButton.Name = "builderButton";
            this.builderButton.Size = new System.Drawing.Size(301, 615);
            this.builderButton.TabIndex = 0;
            this.builderButton.Text = "生成文件";
            this.builderButton.UseVisualStyleBackColor = false;
            this.builderButton.Click += new System.EventHandler(this.BuilderButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 764);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Builder";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.InfoTabControl.ResumeLayout(false);
            this.dbInfoTab.ResumeLayout(false);
            this.dbInfoTab.PerformLayout();
            this.FileInfoTabPage.ResumeLayout(false);
            this.FileInfoTabPage.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl InfoTabControl;
        private System.Windows.Forms.TabPage dbInfoTab;
        private System.Windows.Forms.TabPage FileInfoTabPage;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox fileInfoTextBox;
        private System.Windows.Forms.Button builderButton;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label port;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.Label host;
        private System.Windows.Forms.TextBox sqlTextBox;
        private System.Windows.Forms.Label SQL;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox dbNameTextBox;
        private System.Windows.Forms.Label dbName;
        private System.Windows.Forms.TextBox charsetTextBox;
        private System.Windows.Forms.Label fileCharset;
        private System.Windows.Forms.ComboBox separatorTypeComboBox;
        private System.Windows.Forms.Label separatorType;
        private System.Windows.Forms.TextBox separatorTextBox;
        private System.Windows.Forms.Label separator;
        private System.Windows.Forms.LinkLabel codePageLink;
    }
}

