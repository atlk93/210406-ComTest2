
namespace ComTest
{
    partial class FormServer
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.sbServerMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbServerLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbServerMessage,
            this.sbServerLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(815, 32);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnStop);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.tbPort);
            this.splitContainer1.Panel2.Controls.Add(this.tbIP);
            this.splitContainer1.Panel2.Controls.Add(this.btnStart);
            this.splitContainer1.Panel2.Controls.Add(this.tbServerPort);
            this.splitContainer1.Size = new System.Drawing.Size(815, 445);
            this.splitContainer1.SplitterDistance = 462;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tbServer);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tbClient);
            this.splitContainer2.Size = new System.Drawing.Size(462, 445);
            this.splitContainer2.SplitterDistance = 201;
            this.splitContainer2.TabIndex = 0;
            // 
            // tbServer
            // 
            this.tbServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServer.Location = new System.Drawing.Point(0, 0);
            this.tbServer.Multiline = true;
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(462, 202);
            this.tbServer.TabIndex = 0;
            // 
            // tbClient
            // 
            this.tbClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClient.Location = new System.Drawing.Point(0, 3);
            this.tbClient.Multiline = true;
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(459, 237);
            this.tbClient.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Send 1 Packet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(152, 257);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 28);
            this.tbPort.TabIndex = 4;
            this.tbPort.Text = "9001";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(46, 257);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(100, 28);
            this.tbIP.TabIndex = 3;
            this.tbIP.Text = "127.0.0.1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(46, 25);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 28);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Server Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbServerPort
            // 
            this.tbServerPort.Location = new System.Drawing.Point(199, 25);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(100, 28);
            this.tbServerPort.TabIndex = 1;
            this.tbServerPort.Text = "9001";
            // 
            // sbServerMessage
            // 
            this.sbServerMessage.AutoSize = false;
            this.sbServerMessage.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sbServerMessage.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.sbServerMessage.Name = "sbServerMessage";
            this.sbServerMessage.Size = new System.Drawing.Size(200, 25);
            // 
            // sbServerLabel2
            // 
            this.sbServerLabel2.AutoSize = false;
            this.sbServerLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.sbServerLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.sbServerLabel2.Name = "sbServerLabel2";
            this.sbServerLabel2.Size = new System.Drawing.Size(100, 25);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(46, 69);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(147, 34);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 501);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormServer";
            this.Text = "Tcp Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormServer_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.ToolStripStatusLabel sbServerMessage;
        private System.Windows.Forms.ToolStripStatusLabel sbServerLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
    }
}

