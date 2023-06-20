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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interfaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shutdown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCopy = new System.Windows.Forms.Button();
            this.grpBox_Columns = new System.Windows.Forms.GroupBox();
            this.chBox_Shutdown = new System.Windows.Forms.CheckBox();
            this.chBox_VRF = new System.Windows.Forms.CheckBox();
            this.chBox_Mask = new System.Windows.Forms.CheckBox();
            this.chBox_IP = new System.Windows.Forms.CheckBox();
            this.chBox_Interface = new System.Windows.Forms.CheckBox();
            this.chBox_Station = new System.Windows.Forms.CheckBox();
            this.btnOpenFD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.grpBox_Columns.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(12, 535);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(1198, 58);
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
            this.txtLog.Location = new System.Drawing.Point(738, 39);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(483, 441);
            this.txtLog.TabIndex = 2;
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(12, 502);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(1148, 23);
            this.txtPath.TabIndex = 3;
            this.txtPath.Text = "D:\\Tasks\\Task2\\BackUpCisco";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Gigi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(12, 8);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(82, 21);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Результат";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Gigi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLog.Location = new System.Drawing.Point(738, 9);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(36, 21);
            this.lblLog.TabIndex = 5;
            this.lblLog.Text = "Лог";
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 483);
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
            this.interfaceName,
            this.IP,
            this.Mask,
            this.vrf,
            this.shutdown});
            this.dgvResult.Location = new System.Drawing.Point(12, 65);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowTemplate.Height = 25;
            this.dgvResult.Size = new System.Drawing.Size(720, 415);
            this.dgvResult.TabIndex = 7;
            // 
            // Station
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Station.DefaultCellStyle = dataGridViewCellStyle1;
            this.Station.HeaderText = "Станция";
            this.Station.Name = "Station";
            this.Station.Width = 110;
            // 
            // interfaceName
            // 
            this.interfaceName.HeaderText = "Имя интерфейса";
            this.interfaceName.Name = "interfaceName";
            this.interfaceName.Width = 180;
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
            // vrf
            // 
            this.vrf.HeaderText = "VRF";
            this.vrf.Name = "vrf";
            // 
            // shutdown
            // 
            this.shutdown.HeaderText = "Shutdown";
            this.shutdown.Name = "shutdown";
            this.shutdown.Width = 105;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(287, 0);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(197, 23);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Копировать данные";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // grpBox_Columns
            // 
            this.grpBox_Columns.Controls.Add(this.chBox_Shutdown);
            this.grpBox_Columns.Controls.Add(this.chBox_VRF);
            this.grpBox_Columns.Controls.Add(this.chBox_Mask);
            this.grpBox_Columns.Controls.Add(this.chBox_IP);
            this.grpBox_Columns.Controls.Add(this.chBox_Interface);
            this.grpBox_Columns.Controls.Add(this.chBox_Station);
            this.grpBox_Columns.Location = new System.Drawing.Point(12, 26);
            this.grpBox_Columns.Name = "grpBox_Columns";
            this.grpBox_Columns.Size = new System.Drawing.Size(720, 34);
            this.grpBox_Columns.TabIndex = 9;
            this.grpBox_Columns.TabStop = false;
            this.grpBox_Columns.Text = "Выбрать столбцы для копирования";
            // 
            // chBox_Shutdown
            // 
            this.chBox_Shutdown.AutoSize = true;
            this.chBox_Shutdown.Location = new System.Drawing.Point(594, 13);
            this.chBox_Shutdown.Name = "chBox_Shutdown";
            this.chBox_Shutdown.Size = new System.Drawing.Size(15, 14);
            this.chBox_Shutdown.TabIndex = 5;
            this.chBox_Shutdown.UseVisualStyleBackColor = true;
            // 
            // chBox_VRF
            // 
            this.chBox_VRF.AutoSize = true;
            this.chBox_VRF.Location = new System.Drawing.Point(496, 13);
            this.chBox_VRF.Name = "chBox_VRF";
            this.chBox_VRF.Size = new System.Drawing.Size(15, 14);
            this.chBox_VRF.TabIndex = 4;
            this.chBox_VRF.UseVisualStyleBackColor = true;
            // 
            // chBox_Mask
            // 
            this.chBox_Mask.AutoSize = true;
            this.chBox_Mask.Location = new System.Drawing.Point(397, 13);
            this.chBox_Mask.Name = "chBox_Mask";
            this.chBox_Mask.Size = new System.Drawing.Size(15, 14);
            this.chBox_Mask.TabIndex = 3;
            this.chBox_Mask.UseVisualStyleBackColor = true;
            // 
            // chBox_IP
            // 
            this.chBox_IP.AutoSize = true;
            this.chBox_IP.Location = new System.Drawing.Point(296, 13);
            this.chBox_IP.Name = "chBox_IP";
            this.chBox_IP.Size = new System.Drawing.Size(15, 14);
            this.chBox_IP.TabIndex = 2;
            this.chBox_IP.UseVisualStyleBackColor = true;
            // 
            // chBox_Interface
            // 
            this.chBox_Interface.AutoSize = true;
            this.chBox_Interface.Location = new System.Drawing.Point(121, 13);
            this.chBox_Interface.Name = "chBox_Interface";
            this.chBox_Interface.Size = new System.Drawing.Size(15, 14);
            this.chBox_Interface.TabIndex = 1;
            this.chBox_Interface.UseVisualStyleBackColor = true;
            // 
            // chBox_Station
            // 
            this.chBox_Station.AutoSize = true;
            this.chBox_Station.Location = new System.Drawing.Point(6, 13);
            this.chBox_Station.Name = "chBox_Station";
            this.chBox_Station.Size = new System.Drawing.Size(15, 14);
            this.chBox_Station.TabIndex = 0;
            this.chBox_Station.UseVisualStyleBackColor = true;
            // 
            // btnOpenFD
            // 
            this.btnOpenFD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFD.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenFD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenFD.BackgroundImage")));
            this.btnOpenFD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenFD.Location = new System.Drawing.Point(1166, 495);
            this.btnOpenFD.Name = "btnOpenFD";
            this.btnOpenFD.Size = new System.Drawing.Size(52, 34);
            this.btnOpenFD.TabIndex = 10;
            this.btnOpenFD.UseVisualStyleBackColor = false;
            this.btnOpenFD.Click += new System.EventHandler(this.btnOpenFD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 605);
            this.Controls.Add(this.btnOpenFD);
            this.Controls.Add(this.grpBox_Columns);
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
            this.grpBox_Columns.ResumeLayout(false);
            this.grpBox_Columns.PerformLayout();
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
        private Button btnCopy;
        private GroupBox grpBox_Columns;
        private CheckBox chBox_Shutdown;
        private CheckBox chBox_VRF;
        private CheckBox chBox_Mask;
        private CheckBox chBox_IP;
        private CheckBox chBox_Interface;
        private CheckBox chBox_Station;
        private Button btnOpenFD;
        private DataGridViewTextBoxColumn Station;
        private DataGridViewTextBoxColumn interfaceName;
        private DataGridViewTextBoxColumn IP;
        private DataGridViewTextBoxColumn Mask;
        private DataGridViewTextBoxColumn vrf;
        private DataGridViewTextBoxColumn shutdown;
    }
}