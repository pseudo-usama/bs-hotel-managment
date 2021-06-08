namespace Manager
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
            this.Setting_Btn = new System.Windows.Forms.Button();
            this.AllItems_Btn = new System.Windows.Forms.Button();
            this.AllOrder_Btn = new System.Windows.Forms.Button();
            this.Items_Btn = new System.Windows.Forms.Button();
            this.Home_Btn = new System.Windows.Forms.Button();
            this.ForSpace_Pnl = new System.Windows.Forms.Panel();
            this.Highlight_Pnl = new System.Windows.Forms.Panel();
            this.Main_Pnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPnl_Manager_lbl = new System.Windows.Forms.Label();
            this.Settings_UsrCntrl = new Manager.Settings();
            this.AllItem_UsrCntrl = new Manager.AllItems();
            this.AllOrders_UsrCntrl = new Manager.All_Orders();
            this.Items_UsrCntrl = new Manager.Items();
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
            this.Minimize_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize_Btn.ForeColor = System.Drawing.Color.Black;
            this.Minimize_Btn.Location = new System.Drawing.Point(934, 0);
            this.Minimize_Btn.Name = "Minimize_Btn";
            this.Minimize_Btn.Size = new System.Drawing.Size(33, 35);
            this.Minimize_Btn.TabIndex = 2;
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
            this.Close_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Btn.ForeColor = System.Drawing.Color.Black;
            this.Close_Btn.Location = new System.Drawing.Point(967, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(33, 35);
            this.Close_Btn.TabIndex = 2;
            this.Close_Btn.TabStop = false;
            this.Close_Btn.Text = "✖";
            this.Close_Btn.UseVisualStyleBackColor = true;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // Menu_Pnl
            // 
            this.Menu_Pnl.Controls.Add(this.Setting_Btn);
            this.Menu_Pnl.Controls.Add(this.AllItems_Btn);
            this.Menu_Pnl.Controls.Add(this.AllOrder_Btn);
            this.Menu_Pnl.Controls.Add(this.Items_Btn);
            this.Menu_Pnl.Controls.Add(this.Home_Btn);
            this.Menu_Pnl.Controls.Add(this.ForSpace_Pnl);
            this.Menu_Pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_Pnl.Location = new System.Drawing.Point(0, 35);
            this.Menu_Pnl.Name = "Menu_Pnl";
            this.Menu_Pnl.Size = new System.Drawing.Size(90, 535);
            this.Menu_Pnl.TabIndex = 0;
            // 
            // Setting_Btn
            // 
            this.Setting_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Setting_Btn.FlatAppearance.BorderSize = 0;
            this.Setting_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setting_Btn.Location = new System.Drawing.Point(0, 368);
            this.Setting_Btn.Name = "Setting_Btn";
            this.Setting_Btn.Size = new System.Drawing.Size(90, 75);
            this.Setting_Btn.TabIndex = 4;
            this.Setting_Btn.Text = "Setting";
            this.Setting_Btn.UseVisualStyleBackColor = true;
            this.Setting_Btn.Click += new System.EventHandler(this.Show_UsrCntrl);
            // 
            // AllItems_Btn
            // 
            this.AllItems_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AllItems_Btn.FlatAppearance.BorderSize = 0;
            this.AllItems_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllItems_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllItems_Btn.Location = new System.Drawing.Point(0, 293);
            this.AllItems_Btn.Name = "AllItems_Btn";
            this.AllItems_Btn.Size = new System.Drawing.Size(90, 75);
            this.AllItems_Btn.TabIndex = 3;
            this.AllItems_Btn.Text = "Items";
            this.AllItems_Btn.UseVisualStyleBackColor = true;
            this.AllItems_Btn.Click += new System.EventHandler(this.Show_UsrCntrl);
            // 
            // AllOrder_Btn
            // 
            this.AllOrder_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AllOrder_Btn.FlatAppearance.BorderSize = 0;
            this.AllOrder_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllOrder_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllOrder_Btn.Location = new System.Drawing.Point(0, 218);
            this.AllOrder_Btn.Name = "AllOrder_Btn";
            this.AllOrder_Btn.Size = new System.Drawing.Size(90, 75);
            this.AllOrder_Btn.TabIndex = 2;
            this.AllOrder_Btn.Text = "Orders";
            this.AllOrder_Btn.UseVisualStyleBackColor = true;
            this.AllOrder_Btn.Click += new System.EventHandler(this.Show_UsrCntrl);
            // 
            // Items_Btn
            // 
            this.Items_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Items_Btn.FlatAppearance.BorderSize = 0;
            this.Items_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Items_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items_Btn.Location = new System.Drawing.Point(0, 143);
            this.Items_Btn.Name = "Items_Btn";
            this.Items_Btn.Size = new System.Drawing.Size(90, 75);
            this.Items_Btn.TabIndex = 1;
            this.Items_Btn.Text = "Add\r\nItem";
            this.Items_Btn.UseVisualStyleBackColor = true;
            this.Items_Btn.Click += new System.EventHandler(this.Show_UsrCntrl);
            // 
            // Home_Btn
            // 
            this.Home_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home_Btn.FlatAppearance.BorderSize = 0;
            this.Home_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_Btn.Location = new System.Drawing.Point(0, 68);
            this.Home_Btn.Name = "Home_Btn";
            this.Home_Btn.Size = new System.Drawing.Size(90, 75);
            this.Home_Btn.TabIndex = 0;
            this.Home_Btn.Text = "Home";
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
            this.ForSpace_Pnl.TabIndex = 2;
            // 
            // Highlight_Pnl
            // 
            this.Highlight_Pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.Highlight_Pnl.Location = new System.Drawing.Point(36, 16);
            this.Highlight_Pnl.Name = "Highlight_Pnl";
            this.Highlight_Pnl.Size = new System.Drawing.Size(10, 75);
            this.Highlight_Pnl.TabIndex = 3;
            // 
            // Main_Pnl
            // 
            this.Main_Pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(52)))), ((int)(((byte)(50)))));
            this.Main_Pnl.Controls.Add(this.Settings_UsrCntrl);
            this.Main_Pnl.Controls.Add(this.AllItem_UsrCntrl);
            this.Main_Pnl.Controls.Add(this.AllOrders_UsrCntrl);
            this.Main_Pnl.Controls.Add(this.Items_UsrCntrl);
            this.Main_Pnl.Controls.Add(this.label2);
            this.Main_Pnl.Controls.Add(this.pictureBox1);
            this.Main_Pnl.Controls.Add(this.MainPnl_Manager_lbl);
            this.Main_Pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Pnl.Location = new System.Drawing.Point(90, 35);
            this.Main_Pnl.Name = "Main_Pnl";
            this.Main_Pnl.Size = new System.Drawing.Size(910, 535);
            this.Main_Pnl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(740, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Developed By: Pseudo.Usama@gmail.com";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(160, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 415);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainPnl_Manager_lbl
            // 
            this.MainPnl_Manager_lbl.AutoSize = true;
            this.MainPnl_Manager_lbl.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPnl_Manager_lbl.Location = new System.Drawing.Point(6, 19);
            this.MainPnl_Manager_lbl.Name = "MainPnl_Manager_lbl";
            this.MainPnl_Manager_lbl.Size = new System.Drawing.Size(202, 49);
            this.MainPnl_Manager_lbl.TabIndex = 3;
            this.MainPnl_Manager_lbl.Text = "Manager";
            // 
            // Settings_UsrCntrl
            // 
            this.Settings_UsrCntrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Settings_UsrCntrl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_UsrCntrl.ForeColor = System.Drawing.Color.White;
            this.Settings_UsrCntrl.Location = new System.Drawing.Point(0, 0);
            this.Settings_UsrCntrl.Name = "Settings_UsrCntrl";
            this.Settings_UsrCntrl.Size = new System.Drawing.Size(910, 535);
            this.Settings_UsrCntrl.TabIndex = 2;
            // 
            // AllItem_UsrCntrl
            // 
            this.AllItem_UsrCntrl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AllItem_UsrCntrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.AllItem_UsrCntrl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllItem_UsrCntrl.ForeColor = System.Drawing.Color.White;
            this.AllItem_UsrCntrl.Location = new System.Drawing.Point(0, 0);
            this.AllItem_UsrCntrl.Name = "AllItem_UsrCntrl";
            this.AllItem_UsrCntrl.Size = new System.Drawing.Size(910, 535);
            this.AllItem_UsrCntrl.TabIndex = 4;
            // 
            // AllOrders_UsrCntrl
            // 
            this.AllOrders_UsrCntrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.AllOrders_UsrCntrl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllOrders_UsrCntrl.ForeColor = System.Drawing.Color.White;
            this.AllOrders_UsrCntrl.Location = new System.Drawing.Point(0, 0);
            this.AllOrders_UsrCntrl.Name = "AllOrders_UsrCntrl";
            this.AllOrders_UsrCntrl.Size = new System.Drawing.Size(910, 535);
            this.AllOrders_UsrCntrl.TabIndex = 1;
            // 
            // Items_UsrCntrl
            // 
            this.Items_UsrCntrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Items_UsrCntrl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items_UsrCntrl.ForeColor = System.Drawing.Color.White;
            this.Items_UsrCntrl.Location = new System.Drawing.Point(-3, 0);
            this.Items_UsrCntrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Items_UsrCntrl.Name = "Items_UsrCntrl";
            this.Items_UsrCntrl.Size = new System.Drawing.Size(910, 535);
            this.Items_UsrCntrl.TabIndex = 0;
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
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.Panel ForSpace_Pnl;
        private System.Windows.Forms.Button Home_Btn;
        private System.Windows.Forms.Button Setting_Btn;
        private System.Windows.Forms.Button AllOrder_Btn;
        private System.Windows.Forms.Button Items_Btn;
        private System.Windows.Forms.Button Minimize_Btn;
        private System.Windows.Forms.Button Close_Btn;
        private System.Windows.Forms.Panel Main_Pnl;
        private Items Items_UsrCntrl;
        private System.Windows.Forms.Panel Highlight_Pnl;
        private All_Orders AllOrders_UsrCntrl;
        private Settings Settings_UsrCntrl;
        private System.Windows.Forms.Button AllItems_Btn;
        private AllItems AllItem_UsrCntrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MainPnl_Manager_lbl;
    }
}

