namespace EKVI_redact
{
    partial class Login
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
            this.login_text = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.error_text = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangePassword = new System.Windows.Forms.Button();
            this.ChangePass = new System.Windows.Forms.TextBox();
            this.SavePas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_text
            // 
            this.login_text.BackColor = System.Drawing.Color.WhiteSmoke;
            this.login_text.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.login_text.Location = new System.Drawing.Point(22, 68);
            this.login_text.Name = "login_text";
            this.login_text.Size = new System.Drawing.Size(123, 21);
            this.login_text.TabIndex = 0;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.login_button.Location = new System.Drawing.Point(151, 68);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 1;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // error_text
            // 
            this.error_text.AutoSize = true;
            this.error_text.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.error_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.error_text.Location = new System.Drawing.Point(38, 92);
            this.error_text.Name = "error_text";
            this.error_text.Size = new System.Drawing.Size(89, 15);
            this.error_text.TabIndex = 2;
            this.error_text.Text = "Wrong password";
            this.error_text.Visible = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exit.Location = new System.Drawing.Point(90, 130);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(69, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "EVKI redact\r\n";
            // 
            // ChangePassword
            // 
            this.ChangePassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ChangePassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChangePassword.Location = new System.Drawing.Point(151, 92);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(75, 39);
            this.ChangePassword.TabIndex = 5;
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.UseVisualStyleBackColor = false;
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // ChangePass
            // 
            this.ChangePass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ChangePass.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChangePass.Location = new System.Drawing.Point(22, 68);
            this.ChangePass.Name = "ChangePass";
            this.ChangePass.Size = new System.Drawing.Size(123, 21);
            this.ChangePass.TabIndex = 6;
            // 
            // SavePas
            // 
            this.SavePas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SavePas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SavePas.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SavePas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SavePas.Location = new System.Drawing.Point(151, 68);
            this.SavePas.Name = "SavePas";
            this.SavePas.Size = new System.Drawing.Size(75, 23);
            this.SavePas.TabIndex = 7;
            this.SavePas.Text = "Save";
            this.SavePas.UseVisualStyleBackColor = false;
            this.SavePas.Click += new System.EventHandler(this.SavePas_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(235, 165);
            this.ControlBox = false;
            this.Controls.Add(this.SavePas);
            this.Controls.Add(this.ChangePass);
            this.Controls.Add(this.ChangePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.error_text);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.login_text);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EKVI redact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox login_text;
        private Button login_button;
        private Label error_text;
        private Button exit;
        private Label label1;
        private Button ChangePassword;
        private TextBox ChangePass;
        private Button SavePas;
    }
}