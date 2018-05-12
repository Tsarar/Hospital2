namespace Hospital
{
    partial class Authorization
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
            this.bEnter = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.bRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bEnter
            // 
            this.bEnter.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(128)))), ((int)(((byte)(130)))));
            this.bEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bEnter.Location = new System.Drawing.Point(220, 161);
            this.bEnter.Margin = new System.Windows.Forms.Padding(4);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(155, 29);
            this.bEnter.TabIndex = 0;
            this.bEnter.Text = "Войти";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.ForeColor = System.Drawing.Color.DimGray;
            this.tbLogin.Location = new System.Drawing.Point(57, 42);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(4);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(260, 25);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Text = "Введите логин";
            this.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPassword
            // 
            this.tbPassword.ForeColor = System.Drawing.Color.DimGray;
            this.tbPassword.Location = new System.Drawing.Point(57, 109);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(260, 25);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "Введите пароль";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bRegistration
            // 
            this.bRegistration.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(128)))), ((int)(((byte)(130)))));
            this.bRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRegistration.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bRegistration.Location = new System.Drawing.Point(11, 161);
            this.bRegistration.Margin = new System.Windows.Forms.Padding(4);
            this.bRegistration.Name = "bRegistration";
            this.bRegistration.Size = new System.Drawing.Size(155, 29);
            this.bRegistration.TabIndex = 3;
            this.bRegistration.Text = "Зарегистрироваться";
            this.bRegistration.UseVisualStyleBackColor = true;
            this.bRegistration.Click += new System.EventHandler(this.bRegistration_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(128)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(385, 198);
            this.Controls.Add(this.bRegistration);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.bEnter);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button bRegistration;
    }
}

