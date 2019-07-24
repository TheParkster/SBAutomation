namespace SB_Task_Creation
{
    partial class frmMain
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
            this.tbWorkflow = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUnicode = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWorkflowName = new System.Windows.Forms.TextBox();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnClearMultiple = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPasswordMultiple = new System.Windows.Forms.TextBox();
            this.txtUserNameMultiple = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRunMultiple = new System.Windows.Forms.Button();
            this.dgvWorkflows = new System.Windows.Forms.DataGridView();
            this.FolderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkflowName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unicode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBrowse = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnClearWorkflow = new System.Windows.Forms.Button();
            this.btnRunWorkflow = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtWorkflow = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPasswordWorkflow = new System.Windows.Forms.TextBox();
            this.txtUserNameWorkflow = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rchOutput = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbWorkflow.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkflows)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbWorkflow
            // 
            this.tbWorkflow.Controls.Add(this.tabPage1);
            this.tbWorkflow.Controls.Add(this.tabPage2);
            this.tbWorkflow.Controls.Add(this.tabPage3);
            this.tbWorkflow.Location = new System.Drawing.Point(12, 31);
            this.tbWorkflow.Name = "tbWorkflow";
            this.tbWorkflow.SelectedIndex = 0;
            this.tbWorkflow.Size = new System.Drawing.Size(626, 375);
            this.tbWorkflow.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnRun);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Single Task";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(334, 265);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 47);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(68, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 115);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Credentials";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(206, 66);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(154, 22);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(206, 31);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(154, 22);
            this.txtUserName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "UserName:";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(198, 265);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(111, 47);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUnicode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtWorkflowName);
            this.groupBox1.Controls.Add(this.txtFolderName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(68, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 117);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informatica";
            // 
            // chkUnicode
            // 
            this.chkUnicode.AutoSize = true;
            this.chkUnicode.Location = new System.Drawing.Point(182, 87);
            this.chkUnicode.Name = "chkUnicode";
            this.chkUnicode.Size = new System.Drawing.Size(128, 21);
            this.chkUnicode.TabIndex = 5;
            this.chkUnicode.Text = "Unicode Server";
            this.chkUnicode.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Workflow Name:";
            // 
            // txtWorkflowName
            // 
            this.txtWorkflowName.Location = new System.Drawing.Point(143, 59);
            this.txtWorkflowName.Name = "txtWorkflowName";
            this.txtWorkflowName.Size = new System.Drawing.Size(341, 22);
            this.txtWorkflowName.TabIndex = 3;
            // 
            // txtFolderName
            // 
            this.txtFolderName.Location = new System.Drawing.Point(143, 26);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(218, 22);
            this.txtFolderName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Folder Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnClearMultiple);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.btnRunMultiple);
            this.tabPage2.Controls.Add(this.dgvWorkflows);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 346);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Multiple Tasks";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnClearMultiple
            // 
            this.btnClearMultiple.Location = new System.Drawing.Point(312, 293);
            this.btnClearMultiple.Name = "btnClearMultiple";
            this.btnClearMultiple.Size = new System.Drawing.Size(111, 47);
            this.btnClearMultiple.TabIndex = 10;
            this.btnClearMultiple.Text = "Clear";
            this.btnClearMultiple.UseVisualStyleBackColor = true;
            this.btnClearMultiple.Click += new System.EventHandler(this.btnClearMultiple_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPasswordMultiple);
            this.groupBox4.Controls.Add(this.txtUserNameMultiple);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(6, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(606, 81);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Credentials";
            // 
            // txtPasswordMultiple
            // 
            this.txtPasswordMultiple.Location = new System.Drawing.Point(263, 50);
            this.txtPasswordMultiple.Name = "txtPasswordMultiple";
            this.txtPasswordMultiple.Size = new System.Drawing.Size(154, 22);
            this.txtPasswordMultiple.TabIndex = 8;
            this.txtPasswordMultiple.UseSystemPasswordChar = true;
            // 
            // txtUserNameMultiple
            // 
            this.txtUserNameMultiple.Location = new System.Drawing.Point(263, 15);
            this.txtUserNameMultiple.Name = "txtUserNameMultiple";
            this.txtUserNameMultiple.Size = new System.Drawing.Size(154, 22);
            this.txtUserNameMultiple.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "UserName:";
            // 
            // btnRunMultiple
            // 
            this.btnRunMultiple.Location = new System.Drawing.Point(187, 293);
            this.btnRunMultiple.Name = "btnRunMultiple";
            this.btnRunMultiple.Size = new System.Drawing.Size(111, 47);
            this.btnRunMultiple.TabIndex = 9;
            this.btnRunMultiple.Text = "Run";
            this.btnRunMultiple.UseVisualStyleBackColor = true;
            this.btnRunMultiple.Click += new System.EventHandler(this.btnRunMultiple_Click);
            // 
            // dgvWorkflows
            // 
            this.dgvWorkflows.AllowUserToAddRows = false;
            this.dgvWorkflows.AllowUserToDeleteRows = false;
            this.dgvWorkflows.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvWorkflows.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvWorkflows.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvWorkflows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkflows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FolderName,
            this.WorkflowName,
            this.Unicode});
            this.dgvWorkflows.Location = new System.Drawing.Point(6, 87);
            this.dgvWorkflows.Name = "dgvWorkflows";
            this.dgvWorkflows.ReadOnly = true;
            this.dgvWorkflows.RowTemplate.Height = 24;
            this.dgvWorkflows.Size = new System.Drawing.Size(606, 113);
            this.dgvWorkflows.TabIndex = 1;
            // 
            // FolderName
            // 
            this.FolderName.HeaderText = "FolderName";
            this.FolderName.Name = "FolderName";
            this.FolderName.ReadOnly = true;
            this.FolderName.Width = 114;
            // 
            // WorkflowName
            // 
            this.WorkflowName.HeaderText = "WorkflowName";
            this.WorkflowName.Name = "WorkflowName";
            this.WorkflowName.ReadOnly = true;
            this.WorkflowName.Width = 131;
            // 
            // Unicode
            // 
            this.Unicode.HeaderText = "Unicode";
            this.Unicode.Name = "Unicode";
            this.Unicode.ReadOnly = true;
            this.Unicode.Width = 89;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.txtBrowse);
            this.groupBox3.Controls.Add(this.btnBrowse);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(606, 75);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Upload CSV";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(449, 30);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBrowse
            // 
            this.txtBrowse.Location = new System.Drawing.Point(171, 33);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(272, 22);
            this.txtBrowse.TabIndex = 6;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(79, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(86, 28);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnClearWorkflow);
            this.tabPage3.Controls.Add(this.btnRunWorkflow);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(618, 346);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SB Workflow";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnClearWorkflow
            // 
            this.btnClearWorkflow.Location = new System.Drawing.Point(318, 203);
            this.btnClearWorkflow.Name = "btnClearWorkflow";
            this.btnClearWorkflow.Size = new System.Drawing.Size(111, 47);
            this.btnClearWorkflow.TabIndex = 12;
            this.btnClearWorkflow.Text = "Clear";
            this.btnClearWorkflow.UseVisualStyleBackColor = true;
            this.btnClearWorkflow.Click += new System.EventHandler(this.btnClearWorkflow_Click);
            // 
            // btnRunWorkflow
            // 
            this.btnRunWorkflow.Location = new System.Drawing.Point(193, 203);
            this.btnRunWorkflow.Name = "btnRunWorkflow";
            this.btnRunWorkflow.Size = new System.Drawing.Size(111, 47);
            this.btnRunWorkflow.TabIndex = 11;
            this.btnRunWorkflow.Text = "Run";
            this.btnRunWorkflow.UseVisualStyleBackColor = true;
            this.btnRunWorkflow.Click += new System.EventHandler(this.btnRunWorkflow_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtWorkflow);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(606, 77);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "SB Workflow";
            // 
            // txtWorkflow
            // 
            this.txtWorkflow.Location = new System.Drawing.Point(263, 33);
            this.txtWorkflow.Name = "txtWorkflow";
            this.txtWorkflow.Size = new System.Drawing.Size(243, 22);
            this.txtWorkflow.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "StoneBranch Workflow Name:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPasswordWorkflow);
            this.groupBox5.Controls.Add(this.txtUserNameWorkflow);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(6, 99);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(606, 98);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Credentials";
            // 
            // txtPasswordWorkflow
            // 
            this.txtPasswordWorkflow.Location = new System.Drawing.Point(263, 59);
            this.txtPasswordWorkflow.Name = "txtPasswordWorkflow";
            this.txtPasswordWorkflow.Size = new System.Drawing.Size(154, 22);
            this.txtPasswordWorkflow.TabIndex = 11;
            this.txtPasswordWorkflow.UseSystemPasswordChar = true;
            // 
            // txtUserNameWorkflow
            // 
            this.txtUserNameWorkflow.Location = new System.Drawing.Point(263, 24);
            this.txtUserNameWorkflow.Name = "txtUserNameWorkflow";
            this.txtUserNameWorkflow.Size = new System.Drawing.Size(154, 22);
            this.txtUserNameWorkflow.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "UserName:";
            // 
            // rchOutput
            // 
            this.rchOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rchOutput.Location = new System.Drawing.Point(12, 412);
            this.rchOutput.Name = "rchOutput";
            this.rchOutput.Size = new System.Drawing.Size(626, 186);
            this.rchOutput.TabIndex = 1;
            this.rchOutput.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(650, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 610);
            this.Controls.Add(this.rchOutput);
            this.Controls.Add(this.tbWorkflow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoneBranch Task and Workflow Creator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tbWorkflow.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkflows)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbWorkflow;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWorkflowName;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchOutput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkUnicode;
        private System.Windows.Forms.DataGridView dgvWorkflows;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBrowse;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPasswordMultiple;
        private System.Windows.Forms.TextBox txtUserNameMultiple;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnClearMultiple;
        private System.Windows.Forms.Button btnRunMultiple;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkflowName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unicode;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnClearWorkflow;
        private System.Windows.Forms.Button btnRunWorkflow;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtWorkflow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtPasswordWorkflow;
        private System.Windows.Forms.TextBox txtUserNameWorkflow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

