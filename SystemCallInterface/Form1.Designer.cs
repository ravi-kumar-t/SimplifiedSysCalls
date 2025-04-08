namespace SystemCallInterface
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxSystemCalls;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxSystemCalls = new System.Windows.Forms.GroupBox();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.groupBoxSystemCalls.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Navy;
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(600, 60);
            this.headerPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🔐 System Call Interface";
            // 
            // groupBoxSystemCalls
            // 
            this.groupBoxSystemCalls.Controls.Add(this.btnCreateFile);
            this.groupBoxSystemCalls.Controls.Add(this.btnWriteFile);
            this.groupBoxSystemCalls.Controls.Add(this.btnReadFile);
            this.groupBoxSystemCalls.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBoxSystemCalls.Location = new System.Drawing.Point(30, 80);
            this.groupBoxSystemCalls.Name = "groupBoxSystemCalls";
            this.groupBoxSystemCalls.Size = new System.Drawing.Size(540, 80);
            this.groupBoxSystemCalls.TabIndex = 1;
            this.groupBoxSystemCalls.TabStop = false;
            this.groupBoxSystemCalls.Text = "System Calls";
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateFile.Location = new System.Drawing.Point(6, 36);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(100, 44);
            this.btnCreateFile.TabIndex = 0;
            this.btnCreateFile.Text = "Create";
            this.btnCreateFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWriteFile.Location = new System.Drawing.Point(125, 36);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(100, 44);
            this.btnWriteFile.TabIndex = 1;
            this.btnWriteFile.Text = "Write";
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadFile.Location = new System.Drawing.Point(242, 36);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(100, 44);
            this.btnReadFile.TabIndex = 2;
            this.btnReadFile.Text = "Read";
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // lblInput
            // 
            this.lblInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInput.Location = new System.Drawing.Point(30, 175);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(225, 27);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Write Content to File:";
            this.lblInput.Click += new System.EventHandler(this.lblInput_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtInput.Location = new System.Drawing.Point(30, 205);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(540, 70);
            this.txtInput.TabIndex = 3;
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOutput.Location = new System.Drawing.Point(30, 289);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(100, 31);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "Output:";
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOutput.Location = new System.Drawing.Point(30, 315);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(540, 100);
            this.txtOutput.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(470, 430);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.groupBoxSystemCalls);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "System Call Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.groupBoxSystemCalls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
