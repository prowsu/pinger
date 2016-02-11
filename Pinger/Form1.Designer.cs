namespace Pinger
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PingerIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ForkMe = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PingerIcon
            // 
            this.PingerIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("PingerIcon.Icon")));
            this.PingerIcon.Text = "Pinger";
            this.PingerIcon.Visible = true;
            this.PingerIcon.BalloonTipClicked += new System.EventHandler(this.PingerIcon_BalloonTipClicked);
            this.PingerIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PingerIcon_MouseClick);
            // 
            // ForkMe
            // 
            this.ForkMe.Location = new System.Drawing.Point(12, 111);
            this.ForkMe.Name = "ForkMe";
            this.ForkMe.Size = new System.Drawing.Size(260, 16);
            this.ForkMe.TabIndex = 0;
            this.ForkMe.TabStop = true;
            this.ForkMe.Text = "Fork me on GitHub.com";
            this.ForkMe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ForkMe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForkMe_LinkClicked);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pinger 1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "A lightweight tool for infinitely ping 8.8.8.8 IP address. Make a ping.txt file t" +
    "o ping another IP.";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Author: Evgenii Bogdanov <admin@prow.su>";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 136);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ForkMe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Pinger";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon PingerIcon;
        private System.Windows.Forms.LinkLabel ForkMe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

