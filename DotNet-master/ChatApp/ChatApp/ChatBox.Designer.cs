namespace ChatApp
{
    partial class ChatBox
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
            this.gbSender = new System.Windows.Forms.GroupBox();
            this.lblMyIP = new System.Windows.Forms.Label();
            this.txtMyIP = new System.Windows.Forms.TextBox();
            this.lblMyPort = new System.Windows.Forms.Label();
            this.txtMyPort = new System.Windows.Forms.TextBox();
            this.gbReceiver = new System.Windows.Forms.GroupBox();
            this.lblReceiverIP = new System.Windows.Forms.Label();
            this.lblReceiverPort = new System.Windows.Forms.Label();
            this.txtReceiverIP = new System.Windows.Forms.TextBox();
            this.txtReceiverPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chatList = new System.Windows.Forms.ListBox();
            this.txtMesseage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbSender.SuspendLayout();
            this.gbReceiver.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSender
            // 
            this.gbSender.Controls.Add(this.txtMyPort);
            this.gbSender.Controls.Add(this.lblMyPort);
            this.gbSender.Controls.Add(this.txtMyIP);
            this.gbSender.Controls.Add(this.lblMyIP);
            this.gbSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSender.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbSender.Location = new System.Drawing.Point(3, 3);
            this.gbSender.Name = "gbSender";
            this.gbSender.Size = new System.Drawing.Size(200, 100);
            this.gbSender.TabIndex = 0;
            this.gbSender.TabStop = false;
            this.gbSender.Text = "Sender";
            // 
            // lblMyIP
            // 
            this.lblMyIP.AutoSize = true;
            this.lblMyIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyIP.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblMyIP.Location = new System.Drawing.Point(16, 29);
            this.lblMyIP.Name = "lblMyIP";
            this.lblMyIP.Size = new System.Drawing.Size(22, 16);
            this.lblMyIP.TabIndex = 0;
            this.lblMyIP.Text = "IP";
            // 
            // txtMyIP
            // 
            this.txtMyIP.Location = new System.Drawing.Point(85, 29);
            this.txtMyIP.Name = "txtMyIP";
            this.txtMyIP.Size = new System.Drawing.Size(100, 20);
            this.txtMyIP.TabIndex = 6;
            // 
            // lblMyPort
            // 
            this.lblMyPort.AutoSize = true;
            this.lblMyPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyPort.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblMyPort.Location = new System.Drawing.Point(16, 66);
            this.lblMyPort.Name = "lblMyPort";
            this.lblMyPort.Size = new System.Drawing.Size(36, 16);
            this.lblMyPort.TabIndex = 1;
            this.lblMyPort.Text = "Port";
            // 
            // txtMyPort
            // 
            this.txtMyPort.Location = new System.Drawing.Point(85, 63);
            this.txtMyPort.Name = "txtMyPort";
            this.txtMyPort.Size = new System.Drawing.Size(100, 20);
            this.txtMyPort.TabIndex = 7;
            // 
            // gbReceiver
            // 
            this.gbReceiver.Controls.Add(this.txtReceiverPort);
            this.gbReceiver.Controls.Add(this.txtReceiverIP);
            this.gbReceiver.Controls.Add(this.lblReceiverPort);
            this.gbReceiver.Controls.Add(this.lblReceiverIP);
            this.gbReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReceiver.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbReceiver.Location = new System.Drawing.Point(264, 3);
            this.gbReceiver.Name = "gbReceiver";
            this.gbReceiver.Size = new System.Drawing.Size(200, 100);
            this.gbReceiver.TabIndex = 1;
            this.gbReceiver.TabStop = false;
            this.gbReceiver.Text = "Receiver";
            // 
            // lblReceiverIP
            // 
            this.lblReceiverIP.AutoSize = true;
            this.lblReceiverIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverIP.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblReceiverIP.Location = new System.Drawing.Point(19, 29);
            this.lblReceiverIP.Name = "lblReceiverIP";
            this.lblReceiverIP.Size = new System.Drawing.Size(22, 16);
            this.lblReceiverIP.TabIndex = 2;
            this.lblReceiverIP.Text = "IP";
            // 
            // lblReceiverPort
            // 
            this.lblReceiverPort.AutoSize = true;
            this.lblReceiverPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverPort.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblReceiverPort.Location = new System.Drawing.Point(19, 66);
            this.lblReceiverPort.Name = "lblReceiverPort";
            this.lblReceiverPort.Size = new System.Drawing.Size(36, 16);
            this.lblReceiverPort.TabIndex = 3;
            this.lblReceiverPort.Text = "Port";
            // 
            // txtReceiverIP
            // 
            this.txtReceiverIP.Location = new System.Drawing.Point(94, 28);
            this.txtReceiverIP.Name = "txtReceiverIP";
            this.txtReceiverIP.Size = new System.Drawing.Size(100, 20);
            this.txtReceiverIP.TabIndex = 4;
            // 
            // txtReceiverPort
            // 
            this.txtReceiverPort.Location = new System.Drawing.Point(94, 62);
            this.txtReceiverPort.Name = "txtReceiverPort";
            this.txtReceiverPort.Size = new System.Drawing.Size(100, 20);
            this.txtReceiverPort.TabIndex = 5;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConnect.Location = new System.Drawing.Point(486, 49);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.gbReceiver);
            this.panel1.Controls.Add(this.gbSender);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 117);
            this.panel1.TabIndex = 0;
            // 
            // chatList
            // 
            this.chatList.FormattingEnabled = true;
            this.chatList.Location = new System.Drawing.Point(3, 8);
            this.chatList.Name = "chatList";
            this.chatList.Size = new System.Drawing.Size(589, 160);
            this.chatList.TabIndex = 0;
            // 
            // txtMesseage
            // 
            this.txtMesseage.Location = new System.Drawing.Point(3, 174);
            this.txtMesseage.Multiline = true;
            this.txtMesseage.Name = "txtMesseage";
            this.txtMesseage.Size = new System.Drawing.Size(476, 31);
            this.txtMesseage.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.PanNE;
            this.btnSend.Location = new System.Drawing.Point(486, 179);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnSend);
            this.panel2.Controls.Add(this.txtMesseage);
            this.panel2.Controls.Add(this.chatList);
            this.panel2.Location = new System.Drawing.Point(12, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 211);
            this.panel2.TabIndex = 1;
            // 
            // ChatBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 349);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ChatBox";
            this.Text = "ChatBox";
            this.Load += new System.EventHandler(this.ChatBox_Load);
            this.gbSender.ResumeLayout(false);
            this.gbSender.PerformLayout();
            this.gbReceiver.ResumeLayout(false);
            this.gbReceiver.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSender;
        private System.Windows.Forms.TextBox txtMyPort;
        private System.Windows.Forms.Label lblMyPort;
        private System.Windows.Forms.TextBox txtMyIP;
        private System.Windows.Forms.Label lblMyIP;
        private System.Windows.Forms.GroupBox gbReceiver;
        private System.Windows.Forms.TextBox txtReceiverPort;
        private System.Windows.Forms.TextBox txtReceiverIP;
        private System.Windows.Forms.Label lblReceiverPort;
        private System.Windows.Forms.Label lblReceiverIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox chatList;
        private System.Windows.Forms.TextBox txtMesseage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel2;
    }
}