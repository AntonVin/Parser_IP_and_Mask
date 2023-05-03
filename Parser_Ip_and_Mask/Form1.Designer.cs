namespace Parser_Ip_and_Mask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVrfForwarding = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(12, 533);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(943, 58);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Извлечь данные";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.ForeColor = System.Drawing.Color.Red;
            this.txtLog.Location = new System.Drawing.Point(470, 40);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(485, 400);
            this.txtLog.TabIndex = 2;
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(12, 460);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(943, 23);
            this.txtPath.TabIndex = 3;
            this.txtPath.Text = "D:\\Task2\\BackUpCisco";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 16);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(60, 15);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Результат";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(470, 22);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(27, 15);
            this.lblLog.TabIndex = 5;
            this.lblLog.Text = "Лог";
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 441);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(74, 15);
            this.lblPath.TabIndex = 6;
            this.lblPath.Text = "Директорий";
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Station,
            this.IP,
            this.Mask});
            this.dgvResult.Location = new System.Drawing.Point(12, 38);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowTemplate.Height = 25;
            this.dgvResult.Size = new System.Drawing.Size(440, 402);
            this.dgvResult.TabIndex = 7;
            // 
            // Station
            // 
            this.Station.HeaderText = "Станция";
            this.Station.Name = "Station";
            // 
            // IP
            // 
            this.IP.HeaderText = "IP";
            this.IP.Name = "IP";
            // 
            // Mask
            // 
            this.Mask.HeaderText = "Маска";
            this.Mask.Name = "Mask";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(116, 12);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(197, 23);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Копировать IP и маску";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "vrf forwarding";
            // 
            // txtVrfForwarding
            // 
            this.txtVrfForwarding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVrfForwarding.Location = new System.Drawing.Point(12, 504);
            this.txtVrfForwarding.Name = "txtVrfForwarding";
            this.txtVrfForwarding.Size = new System.Drawing.Size(943, 23);
            this.txtVrfForwarding.TabIndex = 10;
            this.txtVrfForwarding.Text = "TM_PS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 604);
            this.Controls.Add(this.txtVrfForwarding);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Парсер IP и маски";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnStart;
        private TextBox txtLog;
        private TextBox txtPath;
        private Label lblResult;
        private Label lblLog;
        private Label lblPath;
        private DataGridView dgvResult;
        private DataGridViewTextBoxColumn Station;
        private DataGridViewTextBoxColumn IP;
        private DataGridViewTextBoxColumn Mask;
        private Button btnCopy;
        private Label label1;
        private TextBox txtVrfForwarding;
    }
}