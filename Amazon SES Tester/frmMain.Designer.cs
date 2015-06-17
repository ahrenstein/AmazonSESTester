namespace Amazon_SES_Tester
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.ComboBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.ComboBox();
            this.txtTLS = new System.Windows.Forms.TextBox();
            this.lblTLS = new System.Windows.Forms.Label();
            this.lblSMTPUser = new System.Windows.Forms.Label();
            this.lblSMTPPass = new System.Windows.Forms.Label();
            this.txtSMTPUser = new System.Windows.Forms.TextBox();
            this.txtSMTPPassword = new System.Windows.Forms.TextBox();
            this.txtSMTPSubject = new System.Windows.Forms.TextBox();
            this.txtSMTPBody = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.Location = new System.Drawing.Point(397, 526);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(316, 526);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(12, 24);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(65, 13);
            this.lblServer.TabIndex = 2;
            this.lblServer.Text = "SES Server:";
            // 
            // txtServer
            // 
            this.txtServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtServer.FormattingEnabled = true;
            this.txtServer.Location = new System.Drawing.Point(105, 21);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(367, 21);
            this.txtServer.TabIndex = 1;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(12, 51);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(63, 13);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Server Port:";
            // 
            // txtPort
            // 
            this.txtPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPort.FormattingEnabled = true;
            this.txtPort.Location = new System.Drawing.Point(105, 48);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(66, 21);
            this.txtPort.TabIndex = 2;
            // 
            // txtTLS
            // 
            this.txtTLS.Location = new System.Drawing.Point(105, 75);
            this.txtTLS.Name = "txtTLS";
            this.txtTLS.ReadOnly = true;
            this.txtTLS.Size = new System.Drawing.Size(66, 20);
            this.txtTLS.TabIndex = 6;
            this.txtTLS.TabStop = false;
            this.txtTLS.Text = "YES";
            // 
            // lblTLS
            // 
            this.lblTLS.AutoSize = true;
            this.lblTLS.Location = new System.Drawing.Point(12, 78);
            this.lblTLS.Name = "lblTLS";
            this.lblTLS.Size = new System.Drawing.Size(52, 13);
            this.lblTLS.TabIndex = 7;
            this.lblTLS.Text = "Use TLS:";
            // 
            // lblSMTPUser
            // 
            this.lblSMTPUser.AutoSize = true;
            this.lblSMTPUser.Location = new System.Drawing.Point(12, 104);
            this.lblSMTPUser.Name = "lblSMTPUser";
            this.lblSMTPUser.Size = new System.Drawing.Size(65, 13);
            this.lblSMTPUser.TabIndex = 8;
            this.lblSMTPUser.Text = "SMTP User:";
            // 
            // lblSMTPPass
            // 
            this.lblSMTPPass.AutoSize = true;
            this.lblSMTPPass.Location = new System.Drawing.Point(12, 130);
            this.lblSMTPPass.Name = "lblSMTPPass";
            this.lblSMTPPass.Size = new System.Drawing.Size(89, 13);
            this.lblSMTPPass.TabIndex = 9;
            this.lblSMTPPass.Text = "SMTP Password:";
            // 
            // txtSMTPUser
            // 
            this.txtSMTPUser.Location = new System.Drawing.Point(105, 101);
            this.txtSMTPUser.Name = "txtSMTPUser";
            this.txtSMTPUser.Size = new System.Drawing.Size(325, 20);
            this.txtSMTPUser.TabIndex = 3;
            // 
            // txtSMTPPassword
            // 
            this.txtSMTPPassword.Location = new System.Drawing.Point(105, 127);
            this.txtSMTPPassword.Name = "txtSMTPPassword";
            this.txtSMTPPassword.Size = new System.Drawing.Size(325, 20);
            this.txtSMTPPassword.TabIndex = 4;
            // 
            // txtSMTPSubject
            // 
            this.txtSMTPSubject.Location = new System.Drawing.Point(105, 153);
            this.txtSMTPSubject.Name = "txtSMTPSubject";
            this.txtSMTPSubject.ReadOnly = true;
            this.txtSMTPSubject.Size = new System.Drawing.Size(327, 20);
            this.txtSMTPSubject.TabIndex = 12;
            this.txtSMTPSubject.TabStop = false;
            this.txtSMTPSubject.Text = "TEST E-MAIL: Sent via Amazon SES Tester";
            // 
            // txtSMTPBody
            // 
            this.txtSMTPBody.Location = new System.Drawing.Point(105, 179);
            this.txtSMTPBody.Multiline = true;
            this.txtSMTPBody.Name = "txtSMTPBody";
            this.txtSMTPBody.ReadOnly = true;
            this.txtSMTPBody.Size = new System.Drawing.Size(325, 234);
            this.txtSMTPBody.TabIndex = 13;
            this.txtSMTPBody.TabStop = false;
            this.txtSMTPBody.Text = "FILLED_UPON_LAUNCH";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(12, 156);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(92, 13);
            this.lblSubject.TabIndex = 14;
            this.lblSubject.Text = "Message Subject:";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(12, 179);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(80, 13);
            this.lblBody.TabIndex = 15;
            this.lblBody.Text = "Message Body:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(105, 419);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(325, 20);
            this.txtFrom.TabIndex = 5;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(105, 445);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(327, 20);
            this.txtTo.TabIndex = 6;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 422);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(74, 13);
            this.lblFrom.TabIndex = 18;
            this.lblFrom.Text = "From Address:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(13, 448);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(64, 13);
            this.lblTo.TabIndex = 19;
            this.lblTo.Text = "To Address:";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSend.Location = new System.Drawing.Point(12, 526);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtSMTPBody);
            this.Controls.Add(this.txtSMTPSubject);
            this.Controls.Add(this.txtSMTPPassword);
            this.Controls.Add(this.txtSMTPUser);
            this.Controls.Add(this.lblSMTPPass);
            this.Controls.Add(this.lblSMTPUser);
            this.Controls.Add(this.lblTLS);
            this.Controls.Add(this.txtTLS);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnQuit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "frmMain";
            this.Text = "Amazon SES Tester";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.ComboBox txtServer;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.ComboBox txtPort;
        private System.Windows.Forms.TextBox txtTLS;
        private System.Windows.Forms.Label lblTLS;
        private System.Windows.Forms.Label lblSMTPUser;
        private System.Windows.Forms.Label lblSMTPPass;
        private System.Windows.Forms.TextBox txtSMTPUser;
        private System.Windows.Forms.TextBox txtSMTPPassword;
        private System.Windows.Forms.TextBox txtSMTPSubject;
        private System.Windows.Forms.TextBox txtSMTPBody;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnSend;
    }
}

