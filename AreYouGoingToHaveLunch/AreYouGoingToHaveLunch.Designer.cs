namespace AreYouGoingToHaveLunch
{
    partial class AreYouGoingToHaveLunch
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelHost = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStart.Location = new System.Drawing.Point(417, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(132, 34);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStop.Location = new System.Drawing.Point(555, 3);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(134, 34);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHost.Location = new System.Drawing.Point(3, 0);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(63, 40);
            this.labelHost.TabIndex = 2;
            this.labelHost.Text = "Host";
            this.labelHost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPort.Location = new System.Drawing.Point(210, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(63, 40);
            this.labelPort.TabIndex = 3;
            this.labelPort.Text = "Port";
            this.labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxHost
            // 
            this.textBoxHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHost.Location = new System.Drawing.Point(72, 3);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(132, 31);
            this.textBoxHost.TabIndex = 4;
            this.textBoxHost.Text = "127.0.0.1";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPort.Location = new System.Drawing.Point(279, 3);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(132, 31);
            this.textBoxPort.TabIndex = 5;
            this.textBoxPort.Text = "8910";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStatus.Location = new System.Drawing.Point(3, 115);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(692, 546);
            this.textBoxStatus.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 664);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxStatus, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelConnectionStatus, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(698, 664);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.labelHost, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHost, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonStop, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPort, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonStart, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPort, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(692, 40);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelConnectionStatus.Location = new System.Drawing.Point(3, 46);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(692, 66);
            this.labelConnectionStatus.TabIndex = 7;
            this.labelConnectionStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AreYouGoingToHaveLunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 664);
            this.Controls.Add(this.panel1);
            this.Name = "AreYouGoingToHaveLunch";
            this.Text = "Are you goiung to have lunch?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonStart;
        private Button buttonStop;
        private Label labelHost;
        private Label labelPort;
        private TextBox textBoxHost;
        private TextBox textBoxPort;
        private TextBox textBoxStatus;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelConnectionStatus;
    }
}