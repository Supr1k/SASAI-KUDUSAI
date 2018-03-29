namespace WindowsFormsApp1
{
    partial class Registration
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Accept = new System.Windows.Forms.Button();
            this.Cancle = new System.Windows.Forms.Button();
            this.Enter_login = new System.Windows.Forms.Label();
            this.enter_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(23, 152);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 2;
            this.Accept.Text = "Принять";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancle
            // 
            this.Cancle.Location = new System.Drawing.Point(115, 152);
            this.Cancle.Name = "Cancle";
            this.Cancle.Size = new System.Drawing.Size(75, 23);
            this.Cancle.TabIndex = 3;
            this.Cancle.Text = "Отмена";
            this.Cancle.UseVisualStyleBackColor = true;
            this.Cancle.Click += new System.EventHandler(this.button2_Click);
            // 
            // Enter_login
            // 
            this.Enter_login.AutoSize = true;
            this.Enter_login.Location = new System.Drawing.Point(12, 40);
            this.Enter_login.Name = "Enter_login";
            this.Enter_login.Size = new System.Drawing.Size(81, 13);
            this.Enter_login.TabIndex = 4;
            this.Enter_login.Text = "Введите логин";
            this.Enter_login.Click += new System.EventHandler(this.label1_Click);
            // 
            // enter_password
            // 
            this.enter_password.AutoSize = true;
            this.enter_password.Location = new System.Drawing.Point(12, 81);
            this.enter_password.Name = "enter_password";
            this.enter_password.Size = new System.Drawing.Size(88, 13);
            this.enter_password.TabIndex = 5;
            this.enter_password.Text = "Введите пароль";
            this.enter_password.Click += new System.EventHandler(this.enter_password_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 254);
            this.Controls.Add(this.enter_password);
            this.Controls.Add(this.Enter_login);
            this.Controls.Add(this.Cancle);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Cancle;
        private System.Windows.Forms.Label Enter_login;
        private System.Windows.Forms.Label enter_password;
    }
}