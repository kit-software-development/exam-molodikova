namespace CryptographyRSA
{
    partial class MainForm
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
            this.buttonSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlRSA = new System.Windows.Forms.Panel();
            this.textPublicKey = new System.Windows.Forms.TextBox();
            this.lblPublicKey = new System.Windows.Forms.Label();
            this.lblKeySizeValue = new System.Windows.Forms.Label();
            this.lblKeySize = new System.Windows.Forms.Label();
            this.textContent = new System.Windows.Forms.TextBox();
            this.textEncrypt = new System.Windows.Forms.TextBox();
            this.textDecrypt = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.textHost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlRSA.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(813, 592);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 33);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.clickSend);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(283, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Content:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(283, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Encrypt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(283, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Decrypt:";
            // 
            // pnlRSA
            // 
            this.pnlRSA.BackColor = System.Drawing.Color.Transparent;
            this.pnlRSA.Controls.Add(this.textPublicKey);
            this.pnlRSA.Controls.Add(this.lblPublicKey);
            this.pnlRSA.Controls.Add(this.lblKeySizeValue);
            this.pnlRSA.Controls.Add(this.lblKeySize);
            this.pnlRSA.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlRSA.Location = new System.Drawing.Point(0, 0);
            this.pnlRSA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRSA.Name = "pnlRSA";
            this.pnlRSA.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRSA.Size = new System.Drawing.Size(251, 651);
            this.pnlRSA.TabIndex = 9;
            // 
            // textPublicKey
            // 
            this.textPublicKey.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textPublicKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPublicKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.textPublicKey.Location = new System.Drawing.Point(4, 79);
            this.textPublicKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPublicKey.Multiline = true;
            this.textPublicKey.Name = "textPublicKey";
            this.textPublicKey.ReadOnly = true;
            this.textPublicKey.Size = new System.Drawing.Size(243, 574);
            this.textPublicKey.TabIndex = 7;
            // 
            // lblPublicKey
            // 
            this.lblPublicKey.BackColor = System.Drawing.Color.DimGray;
            this.lblPublicKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublicKey.ForeColor = System.Drawing.Color.White;
            this.lblPublicKey.Location = new System.Drawing.Point(4, 54);
            this.lblPublicKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPublicKey.Name = "lblPublicKey";
            this.lblPublicKey.Size = new System.Drawing.Size(243, 25);
            this.lblPublicKey.TabIndex = 6;
            this.lblPublicKey.Text = "Public Key";
            this.lblPublicKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKeySizeValue
            // 
            this.lblKeySizeValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblKeySizeValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKeySizeValue.Location = new System.Drawing.Point(4, 29);
            this.lblKeySizeValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKeySizeValue.Name = "lblKeySizeValue";
            this.lblKeySizeValue.Size = new System.Drawing.Size(243, 25);
            this.lblKeySizeValue.TabIndex = 5;
            this.lblKeySizeValue.Text = "2048";
            this.lblKeySizeValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKeySize
            // 
            this.lblKeySize.BackColor = System.Drawing.Color.DimGray;
            this.lblKeySize.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKeySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeySize.ForeColor = System.Drawing.Color.White;
            this.lblKeySize.Location = new System.Drawing.Point(4, 4);
            this.lblKeySize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKeySize.Name = "lblKeySize";
            this.lblKeySize.Size = new System.Drawing.Size(243, 25);
            this.lblKeySize.TabIndex = 4;
            this.lblKeySize.Text = "Key Size";
            this.lblKeySize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textContent
            // 
            this.textContent.Location = new System.Drawing.Point(288, 150);
            this.textContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textContent.MaximumSize = new System.Drawing.Size(600, 100);
            this.textContent.MinimumSize = new System.Drawing.Size(600, 100);
            this.textContent.Multiline = true;
            this.textContent.Name = "textContent";
            this.textContent.Size = new System.Drawing.Size(600, 100);
            this.textContent.TabIndex = 10;
            // 
            // textEncrypt
            // 
            this.textEncrypt.Location = new System.Drawing.Point(288, 306);
            this.textEncrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEncrypt.MaximumSize = new System.Drawing.Size(600, 100);
            this.textEncrypt.MinimumSize = new System.Drawing.Size(600, 100);
            this.textEncrypt.Multiline = true;
            this.textEncrypt.Name = "textEncrypt";
            this.textEncrypt.Size = new System.Drawing.Size(600, 100);
            this.textEncrypt.TabIndex = 11;
            // 
            // textDecrypt
            // 
            this.textDecrypt.Location = new System.Drawing.Point(288, 470);
            this.textDecrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textDecrypt.MaximumSize = new System.Drawing.Size(600, 100);
            this.textDecrypt.MinimumSize = new System.Drawing.Size(600, 100);
            this.textDecrypt.Multiline = true;
            this.textDecrypt.Name = "textDecrypt";
            this.textDecrypt.Size = new System.Drawing.Size(600, 100);
            this.textDecrypt.TabIndex = 12;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(589, 32);
            this.textPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(176, 22);
            this.textPort.TabIndex = 17;
            this.textPort.Text = "8910";
            // 
            // textHost
            // 
            this.textHost.Location = new System.Drawing.Point(339, 32);
            this.textHost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textHost.Name = "textHost";
            this.textHost.Size = new System.Drawing.Size(175, 22);
            this.textHost.TabIndex = 16;
            this.textHost.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Port:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(813, 25);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 33);
            this.buttonConnect.TabIndex = 14;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.click_Connect);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Host:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 651);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textHost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textDecrypt);
            this.Controls.Add(this.textEncrypt);
            this.Controls.Add(this.textContent);
            this.Controls.Add(this.pnlRSA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSend);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(949, 698);
            this.MinimumSize = new System.Drawing.Size(949, 698);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlRSA.ResumeLayout(false);
            this.pnlRSA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlRSA;
        private System.Windows.Forms.TextBox textPublicKey;
        private System.Windows.Forms.Label lblPublicKey;
        private System.Windows.Forms.Label lblKeySizeValue;
        private System.Windows.Forms.Label lblKeySize;
        private System.Windows.Forms.TextBox textContent;
        private System.Windows.Forms.TextBox textEncrypt;
        private System.Windows.Forms.TextBox textDecrypt;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label5;
    }
}