namespace Cashier
{
    partial class settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_Pnl = new System.Windows.Forms.Panel();
            this.Username_lbl = new System.Windows.Forms.Label();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.Passowrd_TxtBx = new System.Windows.Forms.TextBox();
            this.Username_TxtBx = new System.Windows.Forms.TextBox();
            this.Settings_Pnl = new System.Windows.Forms.Panel();
            this.Logout_Btn = new System.Windows.Forms.Button();
            this.Change_Btn = new System.Windows.Forms.Button();
            this.Change_Password_TxtBx = new System.Windows.Forms.TextBox();
            this.Change_Username_TxtBx = new System.Windows.Forms.TextBox();
            this.Change_Password_lbl = new System.Windows.Forms.Label();
            this.Change_Username_lbl = new System.Windows.Forms.Label();
            this.ChangeUsernameAndPassword_lbl = new System.Windows.Forms.Label();
            this.Login_Pnl.SuspendLayout();
            this.Settings_Pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_Pnl
            // 
            this.Login_Pnl.Controls.Add(this.Username_lbl);
            this.Login_Pnl.Controls.Add(this.Login_Btn);
            this.Login_Pnl.Controls.Add(this.Password_lbl);
            this.Login_Pnl.Controls.Add(this.Passowrd_TxtBx);
            this.Login_Pnl.Controls.Add(this.Username_TxtBx);
            this.Login_Pnl.Location = new System.Drawing.Point(256, 156);
            this.Login_Pnl.Name = "Login_Pnl";
            this.Login_Pnl.Size = new System.Drawing.Size(399, 222);
            this.Login_Pnl.TabIndex = 3;
            // 
            // Username_lbl
            // 
            this.Username_lbl.AutoSize = true;
            this.Username_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_lbl.Location = new System.Drawing.Point(16, 40);
            this.Username_lbl.Name = "Username_lbl";
            this.Username_lbl.Size = new System.Drawing.Size(113, 23);
            this.Username_lbl.TabIndex = 0;
            this.Username_lbl.Text = "Username:";
            // 
            // Login_Btn
            // 
            this.Login_Btn.FlatAppearance.BorderSize = 0;
            this.Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Btn.Location = new System.Drawing.Point(264, 157);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(112, 43);
            this.Login_Btn.TabIndex = 2;
            this.Login_Btn.Text = "Login";
            this.Login_Btn.UseVisualStyleBackColor = true;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lbl.Location = new System.Drawing.Point(16, 100);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(108, 23);
            this.Password_lbl.TabIndex = 0;
            this.Password_lbl.Text = "Password:";
            // 
            // Passowrd_TxtBx
            // 
            this.Passowrd_TxtBx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passowrd_TxtBx.Location = new System.Drawing.Point(160, 97);
            this.Passowrd_TxtBx.MaxLength = 20;
            this.Passowrd_TxtBx.Name = "Passowrd_TxtBx";
            this.Passowrd_TxtBx.PasswordChar = '•';
            this.Passowrd_TxtBx.Size = new System.Drawing.Size(216, 32);
            this.Passowrd_TxtBx.TabIndex = 1;
            // 
            // Username_TxtBx
            // 
            this.Username_TxtBx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_TxtBx.Location = new System.Drawing.Point(160, 37);
            this.Username_TxtBx.MaxLength = 20;
            this.Username_TxtBx.Name = "Username_TxtBx";
            this.Username_TxtBx.Size = new System.Drawing.Size(216, 32);
            this.Username_TxtBx.TabIndex = 0;
            // 
            // Settings_Pnl
            // 
            this.Settings_Pnl.Controls.Add(this.Logout_Btn);
            this.Settings_Pnl.Controls.Add(this.Change_Btn);
            this.Settings_Pnl.Controls.Add(this.Change_Password_TxtBx);
            this.Settings_Pnl.Controls.Add(this.Change_Username_TxtBx);
            this.Settings_Pnl.Controls.Add(this.Change_Password_lbl);
            this.Settings_Pnl.Controls.Add(this.Change_Username_lbl);
            this.Settings_Pnl.Controls.Add(this.ChangeUsernameAndPassword_lbl);
            this.Settings_Pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Settings_Pnl.Location = new System.Drawing.Point(0, 0);
            this.Settings_Pnl.Name = "Settings_Pnl";
            this.Settings_Pnl.Size = new System.Drawing.Size(910, 535);
            this.Settings_Pnl.TabIndex = 4;
            // 
            // Logout_Btn
            // 
            this.Logout_Btn.FlatAppearance.BorderSize = 0;
            this.Logout_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_Btn.Location = new System.Drawing.Point(753, 445);
            this.Logout_Btn.Name = "Logout_Btn";
            this.Logout_Btn.Size = new System.Drawing.Size(106, 52);
            this.Logout_Btn.TabIndex = 6;
            this.Logout_Btn.Text = "Logout";
            this.Logout_Btn.UseVisualStyleBackColor = true;
            this.Logout_Btn.Click += new System.EventHandler(this.Logout_Btn_Click);
            // 
            // Change_Btn
            // 
            this.Change_Btn.FlatAppearance.BorderSize = 0;
            this.Change_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_Btn.Location = new System.Drawing.Point(292, 269);
            this.Change_Btn.Name = "Change_Btn";
            this.Change_Btn.Size = new System.Drawing.Size(106, 52);
            this.Change_Btn.TabIndex = 2;
            this.Change_Btn.Text = "Update";
            this.Change_Btn.UseVisualStyleBackColor = true;
            this.Change_Btn.Click += new System.EventHandler(this.Change_Btn_Click);
            // 
            // Change_Password_TxtBx
            // 
            this.Change_Password_TxtBx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_Password_TxtBx.Location = new System.Drawing.Point(230, 225);
            this.Change_Password_TxtBx.MaxLength = 20;
            this.Change_Password_TxtBx.Name = "Change_Password_TxtBx";
            this.Change_Password_TxtBx.PasswordChar = '•';
            this.Change_Password_TxtBx.Size = new System.Drawing.Size(168, 32);
            this.Change_Password_TxtBx.TabIndex = 1;
            // 
            // Change_Username_TxtBx
            // 
            this.Change_Username_TxtBx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_Username_TxtBx.Location = new System.Drawing.Point(230, 182);
            this.Change_Username_TxtBx.MaxLength = 20;
            this.Change_Username_TxtBx.Name = "Change_Username_TxtBx";
            this.Change_Username_TxtBx.Size = new System.Drawing.Size(168, 32);
            this.Change_Username_TxtBx.TabIndex = 0;
            // 
            // Change_Password_lbl
            // 
            this.Change_Password_lbl.AutoSize = true;
            this.Change_Password_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_Password_lbl.Location = new System.Drawing.Point(111, 228);
            this.Change_Password_lbl.Name = "Change_Password_lbl";
            this.Change_Password_lbl.Size = new System.Drawing.Size(108, 23);
            this.Change_Password_lbl.TabIndex = 0;
            this.Change_Password_lbl.Text = "Password:";
            // 
            // Change_Username_lbl
            // 
            this.Change_Username_lbl.AutoSize = true;
            this.Change_Username_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_Username_lbl.Location = new System.Drawing.Point(111, 185);
            this.Change_Username_lbl.Name = "Change_Username_lbl";
            this.Change_Username_lbl.Size = new System.Drawing.Size(113, 23);
            this.Change_Username_lbl.TabIndex = 0;
            this.Change_Username_lbl.Text = "Username:";
            // 
            // ChangeUsernameAndPassword_lbl
            // 
            this.ChangeUsernameAndPassword_lbl.AutoSize = true;
            this.ChangeUsernameAndPassword_lbl.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeUsernameAndPassword_lbl.Location = new System.Drawing.Point(110, 99);
            this.ChangeUsernameAndPassword_lbl.Name = "ChangeUsernameAndPassword_lbl";
            this.ChangeUsernameAndPassword_lbl.Size = new System.Drawing.Size(362, 30);
            this.ChangeUsernameAndPassword_lbl.TabIndex = 0;
            this.ChangeUsernameAndPassword_lbl.Text = "Change username, password";
            // 
            // settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.Settings_Pnl);
            this.Controls.Add(this.Login_Pnl);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "settings";
            this.Size = new System.Drawing.Size(910, 535);
            this.Load += new System.EventHandler(this.settings_Load);
            this.Login_Pnl.ResumeLayout(false);
            this.Login_Pnl.PerformLayout();
            this.Settings_Pnl.ResumeLayout(false);
            this.Settings_Pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Login_Pnl;
        private System.Windows.Forms.Label Username_lbl;
        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.TextBox Passowrd_TxtBx;
        private System.Windows.Forms.TextBox Username_TxtBx;
        private System.Windows.Forms.Panel Settings_Pnl;
        private System.Windows.Forms.Button Logout_Btn;
        private System.Windows.Forms.Button Change_Btn;
        private System.Windows.Forms.TextBox Change_Password_TxtBx;
        private System.Windows.Forms.TextBox Change_Username_TxtBx;
        private System.Windows.Forms.Label Change_Password_lbl;
        private System.Windows.Forms.Label Change_Username_lbl;
        private System.Windows.Forms.Label ChangeUsernameAndPassword_lbl;

    }
}
