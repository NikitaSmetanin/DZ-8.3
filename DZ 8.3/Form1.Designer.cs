namespace DZ_8._3
{
    partial class Form1
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
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.EnterInfo = new System.Windows.Forms.Label();
            this.PlsEnterLogin = new System.Windows.Forms.Label();
            this.PassowdLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(136, 63);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(385, 34);
            this.EmailBox.TabIndex = 0;
            // 
            // EnterInfo
            // 
            this.EnterInfo.AutoSize = true;
            this.EnterInfo.Location = new System.Drawing.Point(36, 20);
            this.EnterInfo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.EnterInfo.MaximumSize = new System.Drawing.Size(20001, 2000);
            this.EnterInfo.Name = "EnterInfo";
            this.EnterInfo.Size = new System.Drawing.Size(503, 26);
            this.EnterInfo.TabIndex = 1;
            this.EnterInfo.Text = "Будь ласка, введіть ваші данні для входу чи реєстрації";
            // 
            // PlsEnterLogin
            // 
            this.PlsEnterLogin.AutoSize = true;
            this.PlsEnterLogin.Location = new System.Drawing.Point(50, 66);
            this.PlsEnterLogin.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.PlsEnterLogin.Name = "PlsEnterLogin";
            this.PlsEnterLogin.Size = new System.Drawing.Size(64, 26);
            this.PlsEnterLogin.TabIndex = 2;
            this.PlsEnterLogin.Text = "Email:";
            // 
            // PassowdLabel
            // 
            this.PassowdLabel.AutoSize = true;
            this.PassowdLabel.Location = new System.Drawing.Point(50, 127);
            this.PassowdLabel.Name = "PassowdLabel";
            this.PassowdLabel.Size = new System.Drawing.Size(87, 26);
            this.PassowdLabel.TabIndex = 3;
            this.PassowdLabel.Text = "Пароль:";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(136, 124);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(385, 34);
            this.PasswordBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(50, 196);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(59, 26);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Ім\'я:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(136, 188);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(385, 34);
            this.NameBox.TabIndex = 6;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(41, 262);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(240, 38);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Увійти";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(288, 262);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(233, 38);
            this.SignInButton.TabIndex = 8;
            this.SignInButton.Text = "Зареєструватися";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 331);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.PassowdLabel);
            this.Controls.Add(this.PlsEnterLogin);
            this.Controls.Add(this.EnterInfo);
            this.Controls.Add(this.EmailBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "Form1";
            this.Text = "Форма реєстрації/авторизації";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label EnterInfo;
        private System.Windows.Forms.Label PlsEnterLogin;
        private System.Windows.Forms.Label PassowdLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button SignInButton;
    }
}

