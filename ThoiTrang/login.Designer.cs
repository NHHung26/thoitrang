namespace ThoiTrang
{
    partial class login
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txttk = new TextBox();
            txtmk = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.logashop;
            pictureBox1.Location = new Point(140, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 156);
            label1.Name = "label1";
            label1.Size = new Size(340, 38);
            label1.TabIndex = 1;
            label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 224);
            label2.Name = "label2";
            label2.Size = new Size(115, 31);
            label2.TabIndex = 2;
            label2.Text = "Tài Khoản";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 296);
            label3.Name = "label3";
            label3.Size = new Size(113, 31);
            label3.TabIndex = 3;
            label3.Text = "Mật Khẩu";
            // 
            // txttk
            // 
            txttk.Location = new Point(140, 217);
            txttk.Multiline = true;
            txttk.Name = "txttk";
            txttk.Size = new Size(255, 38);
            txttk.TabIndex = 4;
            // 
            // txtmk
            // 
            txtmk.Location = new Point(140, 289);
            txtmk.Multiline = true;
            txtmk.Name = "txtmk";
            txtmk.Size = new Size(255, 38);
            txtmk.TabIndex = 5;
            txtmk.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(57, 376);
            button1.Name = "button1";
            button1.Size = new Size(133, 46);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(264, 376);
            button2.Name = "button2";
            button2.Size = new Size(133, 46);
            button2.TabIndex = 7;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 495);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtmk);
            Controls.Add(txttk);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "login";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txttk;
        private TextBox txtmk;
        private Button button1;
        private Button button2;
    }
}