namespace Client
{
    partial class Form1
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
            this.TxtIp = new System.Windows.Forms.TextBox();
            this.TxtMess = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.ListSent = new System.Windows.Forms.ListBox();
            this.Connect = new System.Windows.Forms.Button();
            this.tb_Mess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtIp
            // 
            this.TxtIp.Location = new System.Drawing.Point(585, 165);
            this.TxtIp.Name = "TxtIp";
            this.TxtIp.Size = new System.Drawing.Size(192, 22);
            this.TxtIp.TabIndex = 1;
            // 
            // TxtMess
            // 
            this.TxtMess.Location = new System.Drawing.Point(27, 407);
            this.TxtMess.Name = "TxtMess";
            this.TxtMess.Size = new System.Drawing.Size(526, 22);
            this.TxtMess.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(602, 406);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // ListSent
            // 
            this.ListSent.FormattingEnabled = true;
            this.ListSent.ItemHeight = 16;
            this.ListSent.Location = new System.Drawing.Point(27, 51);
            this.ListSent.Name = "ListSent";
            this.ListSent.Size = new System.Drawing.Size(526, 52);
            this.ListSent.TabIndex = 5;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(644, 207);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 6;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // tb_Mess
            // 
            this.tb_Mess.Location = new System.Drawing.Point(27, 128);
            this.tb_Mess.Multiline = true;
            this.tb_Mess.Name = "tb_Mess";
            this.tb_Mess.Size = new System.Drawing.Size(526, 224);
            this.tb_Mess.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Your message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Send your message here";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ip Address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Mess);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.ListSent);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.TxtMess);
            this.Controls.Add(this.TxtIp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtIp;
        private System.Windows.Forms.TextBox TxtMess;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox ListSent;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox tb_Mess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

