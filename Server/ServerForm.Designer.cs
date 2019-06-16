namespace Server
{
    partial class FormServer
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textHost = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.textDecrypt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(570, 20);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 33);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ClickStart);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(664, 20);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 33);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ClickStop);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port:";
            // 
            // textHost
            // 
            this.textHost.Location = new System.Drawing.Point(96, 28);
            this.textHost.Name = "textHost";
            this.textHost.Size = new System.Drawing.Size(174, 22);
            this.textHost.TabIndex = 4;
            this.textHost.Text = "127.0.0.1";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(347, 28);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(176, 22);
            this.textPort.TabIndex = 5;
            this.textPort.Text = "8910";
            // 
            // textStatus
            // 
            this.textStatus.Location = new System.Drawing.Point(46, 117);
            this.textStatus.Multiline = true;
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(693, 115);
            this.textStatus.TabIndex = 6;
            // 
            // textDecrypt
            // 
            this.textDecrypt.Location = new System.Drawing.Point(46, 291);
            this.textDecrypt.Multiline = true;
            this.textDecrypt.Name = "textDecrypt";
            this.textDecrypt.Size = new System.Drawing.Size(693, 115);
            this.textDecrypt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "textStatus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "textDecrypt";
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textDecrypt);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textHost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormServer";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.FormServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textHost;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.TextBox textDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

