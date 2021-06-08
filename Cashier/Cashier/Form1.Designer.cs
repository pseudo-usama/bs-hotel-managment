namespace Cashier
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
            this.Header_Pnl = new System.Windows.Forms.Panel();
            this.Minimize_Btn = new System.Windows.Forms.Button();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.Menu_Pnl = new System.Windows.Forms.Panel();
            this.Settings_Btn = new System.Windows.Forms.Button();
            this.ViewItems_Btn = new System.Windows.Forms.Button();
            this.AllOrders_Btn = new System.Windows.Forms.Button();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Home_Btn = new System.Windows.Forms.Button();
            this.ForSpace_Pnl = new System.Windows.Forms.Panel();
            this.Highlight_Pnl = new System.Windows.Forms.Panel();
            this.Main_Pnl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Settings_UsrCntrl = new Cashier.settings();
            this.AllItems_UsrCntrl = new Cashier.All_Items();
            this.AllOrders_UsrCntrl = new Cashier.AllOrder();
            this.Add_UsrCntrl = new Cashier.Add();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomeHeading_lbl = new System.Windows.Forms.Label();
            this.Header_Pnl.SuspendLayout();
            this.Menu_Pnl.SuspendLayout();
            this.ForSpace_Pnl.SuspendLayout();
            this.Main_Pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Header_Pnl
            // 
            this.Header_Pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Header_Pnl.Controls.Add(this.Minimize_Btn);
            this.Header_Pnl.Controls.Add(this.Close_Btn);
            this.Header_Pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Pnl.Location = new System.Drawing.Point(0, 0);
            this.Header_Pnl.Name = "Header_Pnl";
            this.Header_Pnl.Size = new System.Drawing.Size(1000, 35);
            this.Header_Pnl.TabIndex = 0;
            this.Header_Pnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_Pnl_MouseDown);
            this.Header_Pnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_Pnl_MouseMove);
            this.Header_Pnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_Pnl_MouseUp);
            // 
            // Minimize_Btn
            // 
            this.Minimize_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize_Btn.FlatAppearance.BorderSize = 0;
            this.Minimize_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize_Btn.ForeColor = System.Drawing.Color.Black;
            this.Minimize_Btn.Location = new System.Drawing.Point(934, 0);
            this.Minimize_Btn.Name = "Minimize_Btn";
            this.Minimize_Btn.Size = new System.Drawing.Size(33, 35);
            this.Minimize_Btn.TabIndex = 0;
            this.Minimize_Btn.TabStop = false;
            this.Minimize_Btn.Text = "🗕";
            this.Minimize_Btn.UseVisualStyleBackColor = true;
            this.Minimize_Btn.Click += new System.EventHandler(this.Minimize_Btn_Click);
            // 
            // Close_Btn
            // 
            this.Close_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_Btn.FlatAppearance.BorderSize = 0;
            this.Close_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Btn.ForeColor = System.Drawing.Color.Black;
            this.Close_Btn.Location = new System.Drawing.Point(967, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(33, 35);
            this.Close_Btn.TabIndex = 0;
            this.Close_Btn.TabStop = false;
            this.Close_Btn.Text = "✖";
            this.Close_Btn.UseVisualStyleBackColor = true;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // Menu_Pnl
            // 
            this.Menu_Pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Menu_Pnl.Controls.Add(this.Settings_Btn);
            this.Menu_Pnl.Controls.Add(this.ViewItems_Btn);
            this.Menu_Pnl.Controls.Add(this.AllOrders_Btn);
            this.Menu_Pnl.Controls.Add(this.Add_Btn);
            this.Menu_Pnl.Controls.Add(this.Home_Btn);
            this.Menu_Pnl.Controls.Add(this.ForSpace_Pnl);
            this.Menu_Pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_Pnl.Location = new System.Drawing.Point(0, 35);
            this.Menu_Pnl.Name = "Menu_Pnl";
            this.Menu_Pnl.Size = new System.Drawing.Size(90, 535);
            this.Menu_Pnl.TabIndex = 0;
            this.Menu_Pnl.TabStop = true;
            // 
            // Settings_Btn
            // 
            this.Settings_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings_Btn.FlatAppearance.BorderSize = 0;
            this.Settings_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_Btn.ForeColor = System.Drawing.Color.White;
            this.Settings_Btn.Location = new System.Drawing.Point(0, 368);
            this.Settings_Btn.Name = "Settings_Btn";
            this.Settings_Btn.Size = new System.Drawing.Size(90, 75);
            this.Settings_Btn.TabIndex = 4;
            this.Settings_Btn.Text = "settign";
            this.Settings_Btn.UseVisualStyleBackColor = true;
            this.Settings_Btn.Click += new System.EventHandler(this.Show_UsrCntrl);
            // 
            // ViewItems_Btn
            // 
            this.ViewItems_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ViewItems_Btn.FlatAppearance.BorderSize = 0;
            this.ViewItems_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewItems_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewItems_Btn.ForeColor = System.Drawing.Color.White;
            this.ViewItems_Btn.Location = new System.Drawing.Point(0, 293);
            this.ViewItems_Btn.Name = "ViewItems_Btn";
            this.ViewItems_Btn.Size = new System.Drawing.Size(90, 75);
            this.ViewItems_Btn.TabIndex = 3;
            this.ViewItems_Btn.Text = "view all items";
            this.ViewItems_Btn.UseVisualStyleBackColor = true;
            this.ViewItems_Btn.Click += new System.EventHandler(this.Show_UsrCntrl);
            // 
            // AllOrders_Btn
            // 
            this.AllOrders_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AllOrders_Btn.FlatAppearance.BorderSize = 0;
            this.AllOrders_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllOrders_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllOrders_Btn.ForeColor = System.Drawing.Color.White;
            this.AllOrders_Btn.Location = new System.Drawing.Point(0, 218);
            this.AllOrders_Btn.Name = "AllOrders_Btn";
            this.AllOrders_Btn.Size = new System.Drawing.Size(90, 75);
            this.AllOrders_Btn.TabIndex = 2;
            this.AllOrders_Btn.Text = "all orders";
            this.AllOrders_Btn.UseVisualStyleBackColor = true;
            this.AllOrders_Btn.Click += new System.EventHandler(this.Show_UsrCntrl);
            // 
            // Add_Btn
            // 
            this.Add_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Add_Btn.FlatAppearance.BorderSize = 0;
            this.Add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Btn.ForeColor = System.Drawing.Color.White;
            this.Add_Btn.Location = new System.Drawing.Point(0, 143);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(90, 75);
            this.Add_Btn.TabIndex = 1;
            this.Add_Btn.Text = "add";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Show_UsrCntrl);
            // 
            // Home_Btn
            // 
            this.Home_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home_Btn.FlatAppearance.BorderSize = 0;
            this.Home_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_Btn.ForeColor = System.Drawing.Color.White;
            this.Home_Btn.Location = new System.Drawing.Point(0, 68);
            this.Home_Btn.Name = "Home_Btn";
            this.Home_Btn.Size = new System.Drawing.Size(90, 75);
            this.Home_Btn.TabIndex = 0;
            this.Home_Btn.Text = "home";
            this.Home_Btn.UseVisualStyleBackColor = true;
            this.Home_Btn.Click += new System.EventHandler(this.Home_Btn_Click);
            // 
            // ForSpace_Pnl
            // 
            this.ForSpace_Pnl.Controls.Add(this.Highlight_Pnl);
            this.ForSpace_Pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ForSpace_Pnl.Location = new System.Drawing.Point(0, 0);
            this.ForSpace_Pnl.Name = "ForSpace_Pnl";
            this.ForSpace_Pnl.Size = new System.Drawing.Size(90, 68);
            this.ForSpace_Pnl.TabIndex = 0;
            // 
            // Highlight_Pnl
            // 
            this.Highlight_Pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Highlight_Pnl.Location = new System.Drawing.Point(31, 16);
            this.Highlight_Pnl.Name = "Highlight_Pnl";
            this.Highlight_Pnl.Size = new System.Drawing.Size(10, 75);
            this.Highlight_Pnl.TabIndex = 2;
            // 
            // Main_Pnl
            // 
            this.Main_Pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(52)))), ((int)(((byte)(50)))));
            this.Main_Pnl.Controls.Add(this.label1);
            this.Main_Pnl.Controls.Add(this.Settings_UsrCntrl);
            this.Main_Pnl.Controls.Add(this.AllItems_UsrCntrl);
            this.Main_Pnl.Controls.Add(this.AllOrders_UsrCntrl);
            this.Main_Pnl.Controls.Add(this.Add_UsrCntrl);
            this.Main_Pnl.Controls.Add(this.pictureBox1);
            this.Main_Pnl.Controls.Add(this.HomeHeading_lbl);
            this.Main_Pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Pnl.Location = new System.Drawing.Point(90, 35);
            this.Main_Pnl.Name = "Main_Pnl";
            this.Main_Pnl.Size = new System.Drawing.Size(910, 535);
            this.Main_Pnl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Developed By: Pseudo.Usama@gmail.com";
            // 
            // Settings_UsrCntrl
            // 
            this.Settings_UsrCntrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Settings_UsrCntrl.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_UsrCntrl.ForeColor = System.Drawing.Color.White;
            this.Settings_UsrCntrl.Location = new System.Drawing.Point(0, 0);
            this.Settings_UsrCntrl.Name = "Settings_UsrCntrl";
            this.Settings_UsrCntrl.Size = new System.Drawing.Size(910, 535);
            this.Settings_UsrCntrl.TabIndex = 5;
            // 
            // AllItems_UsrCntrl
            // 
            this.AllItems_UsrCntrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.AllItems_UsrCntrl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllItems_UsrCntrl.ForeColor = System.Drawing.Color.White;
            this.AllItems_UsrCntrl.Location = new System.Drawing.Point(0, 0);
            this.AllItems_UsrCntrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AllItems_UsrCntrl.Name = "AllItems_UsrCntrl";
            this.AllItems_UsrCntrl.Size = new System.Drawing.Size(910, 535);
            this.AllItems_UsrCntrl.TabIndex = 3;
            // 
            // AllOrders_UsrCntrl
            // 
            this.AllOrders_UsrCntrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.AllOrders_UsrCntrl.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllOrders_UsrCntrl.ForeColor = System.Drawing.Color.White;
            this.AllOrders_UsrCntrl.Location = new System.Drawing.Point(0, 0);
            this.AllOrders_UsrCntrl.Name = "AllOrders_UsrCntrl";
            this.AllOrders_UsrCntrl.Size = new System.Drawing.Size(910, 535);
            this.AllOrders_UsrCntrl.TabIndex = 4;
            // 
            // Add_UsrCntrl
            // 
            this.Add_UsrCntrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Add_UsrCntrl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_UsrCntrl.ForeColor = System.Drawing.Color.White;
            this.Add_UsrCntrl.Location = new System.Drawing.Point(0, 0);
            this.Add_UsrCntrl.Name = "Add_UsrCntrl";
            this.Add_UsrCntrl.Size = new System.Drawing.Size(910, 535);
            this.Add_UsrCntrl.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(159, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 415);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // HomeHeading_lbl
            // 
            this.HomeHeading_lbl.AutoSize = true;
            this.HomeHeading_lbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeHeading_lbl.Location = new System.Drawing.Point(67, 42);
            this.HomeHeading_lbl.Name = "HomeHeading_lbl";
            this.HomeHeading_lbl.Size = new System.Drawing.Size(135, 39);
            this.HomeHeading_lbl.TabIndex = 0;
            this.HomeHeading_lbl.Text = "Cashier";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1000, 570);
            this.Controls.Add(this.Main_Pnl);
            this.Controls.Add(this.Menu_Pnl);
            this.Controls.Add(this.Header_Pnl);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Header_Pnl.ResumeLayout(false);
            this.Menu_Pnl.ResumeLayout(false);
            this.ForSpace_Pnl.ResumeLayout(false);
            this.Main_Pnl.ResumeLayout(false);
            this.Main_Pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header_Pnl;
        private System.Windows.Forms.Panel Menu_Pnl;
        private System.Windows.Forms.Button Home_Btn;
        private System.Windows.Forms.Panel ForSpace_Pnl;
        private System.Windows.Forms.Button Close_Btn;
        private System.Windows.Forms.Button Minimize_Btn;
        private System.Windows.Forms.Button AllOrders_Btn;
        private System.Windows.Forms.Panel Main_Pnl;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Label HomeHeading_lbl;
        private Add Add_UsrCntrl;
        private System.Windows.Forms.Panel Highlight_Pnl;
        private System.Windows.Forms.Button ViewItems_Btn;
        private All_Items AllItems_UsrCntrl;
        private AllOrder AllOrders_UsrCntrl;
        private System.Windows.Forms.Button Settings_Btn;
        private settings Settings_UsrCntrl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

