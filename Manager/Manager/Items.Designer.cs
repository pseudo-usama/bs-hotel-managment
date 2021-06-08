namespace Manager
{
    partial class Items
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
            this.HeaderItem_Btn = new System.Windows.Forms.Button();
            this.HeaderArrow_Btn = new System.Windows.Forms.Button();
            this.HeaderSubMenu_Btn = new System.Windows.Forms.Button();
            this.Header_Pnl = new System.Windows.Forms.Panel();
            this.Main_Pnl = new System.Windows.Forms.Panel();
            this.DeleteItem_UsrCntrl = new Manager.Delete_Item();
            this.ModifyItem_UsrCntrl = new Manager.Modify_Item();
            this.AddItem_UsrCntrl = new Manager.Add_Item();
            this.Modify_Btn = new System.Windows.Forms.Button();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Header_Pnl.SuspendLayout();
            this.Main_Pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderItem_Btn
            // 
            this.HeaderItem_Btn.FlatAppearance.BorderSize = 0;
            this.HeaderItem_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeaderItem_Btn.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderItem_Btn.Location = new System.Drawing.Point(0, 0);
            this.HeaderItem_Btn.Name = "HeaderItem_Btn";
            this.HeaderItem_Btn.Size = new System.Drawing.Size(121, 78);
            this.HeaderItem_Btn.TabIndex = 1;
            this.HeaderItem_Btn.Text = "Items";
            this.HeaderItem_Btn.UseVisualStyleBackColor = true;
            this.HeaderItem_Btn.Click += new System.EventHandler(this.HeaderItem_Btn_Click);
            // 
            // HeaderArrow_Btn
            // 
            this.HeaderArrow_Btn.FlatAppearance.BorderSize = 0;
            this.HeaderArrow_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeaderArrow_Btn.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderArrow_Btn.Location = new System.Drawing.Point(117, 3);
            this.HeaderArrow_Btn.Name = "HeaderArrow_Btn";
            this.HeaderArrow_Btn.Size = new System.Drawing.Size(42, 78);
            this.HeaderArrow_Btn.TabIndex = 1;
            this.HeaderArrow_Btn.TabStop = false;
            this.HeaderArrow_Btn.Text = ">";
            this.HeaderArrow_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HeaderArrow_Btn.UseVisualStyleBackColor = true;
            // 
            // HeaderSubMenu_Btn
            // 
            this.HeaderSubMenu_Btn.FlatAppearance.BorderSize = 0;
            this.HeaderSubMenu_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeaderSubMenu_Btn.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderSubMenu_Btn.Location = new System.Drawing.Point(156, 0);
            this.HeaderSubMenu_Btn.Name = "HeaderSubMenu_Btn";
            this.HeaderSubMenu_Btn.Size = new System.Drawing.Size(148, 78);
            this.HeaderSubMenu_Btn.TabIndex = 1;
            this.HeaderSubMenu_Btn.TabStop = false;
            this.HeaderSubMenu_Btn.Text = "Add";
            this.HeaderSubMenu_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HeaderSubMenu_Btn.UseVisualStyleBackColor = true;
            // 
            // Header_Pnl
            // 
            this.Header_Pnl.Controls.Add(this.HeaderItem_Btn);
            this.Header_Pnl.Controls.Add(this.HeaderSubMenu_Btn);
            this.Header_Pnl.Controls.Add(this.HeaderArrow_Btn);
            this.Header_Pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_Pnl.Location = new System.Drawing.Point(0, 0);
            this.Header_Pnl.Name = "Header_Pnl";
            this.Header_Pnl.Size = new System.Drawing.Size(910, 78);
            this.Header_Pnl.TabIndex = 1;
            // 
            // Main_Pnl
            // 
            this.Main_Pnl.Controls.Add(this.DeleteItem_UsrCntrl);
            this.Main_Pnl.Controls.Add(this.ModifyItem_UsrCntrl);
            this.Main_Pnl.Controls.Add(this.AddItem_UsrCntrl);
            this.Main_Pnl.Controls.Add(this.Modify_Btn);
            this.Main_Pnl.Controls.Add(this.Delete_Btn);
            this.Main_Pnl.Controls.Add(this.Add_Btn);
            this.Main_Pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Pnl.Location = new System.Drawing.Point(0, 78);
            this.Main_Pnl.Name = "Main_Pnl";
            this.Main_Pnl.Size = new System.Drawing.Size(910, 457);
            this.Main_Pnl.TabIndex = 0;
            // 
            // DeleteItem_UsrCntrl
            // 
            this.DeleteItem_UsrCntrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.DeleteItem_UsrCntrl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteItem_UsrCntrl.ForeColor = System.Drawing.Color.White;
            this.DeleteItem_UsrCntrl.Location = new System.Drawing.Point(0, 0);
            this.DeleteItem_UsrCntrl.Name = "DeleteItem_UsrCntrl";
            this.DeleteItem_UsrCntrl.Size = new System.Drawing.Size(910, 457);
            this.DeleteItem_UsrCntrl.TabIndex = 7;
            // 
            // ModifyItem_UsrCntrl
            // 
            this.ModifyItem_UsrCntrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.ModifyItem_UsrCntrl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyItem_UsrCntrl.ForeColor = System.Drawing.Color.White;
            this.ModifyItem_UsrCntrl.Location = new System.Drawing.Point(0, 0);
            this.ModifyItem_UsrCntrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ModifyItem_UsrCntrl.Name = "ModifyItem_UsrCntrl";
            this.ModifyItem_UsrCntrl.Size = new System.Drawing.Size(910, 457);
            this.ModifyItem_UsrCntrl.TabIndex = 6;
            // 
            // AddItem_UsrCntrl
            // 
            this.AddItem_UsrCntrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.AddItem_UsrCntrl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem_UsrCntrl.ForeColor = System.Drawing.Color.White;
            this.AddItem_UsrCntrl.Location = new System.Drawing.Point(0, 0);
            this.AddItem_UsrCntrl.Name = "AddItem_UsrCntrl";
            this.AddItem_UsrCntrl.Size = new System.Drawing.Size(910, 457);
            this.AddItem_UsrCntrl.TabIndex = 5;
            // 
            // Modify_Btn
            // 
            this.Modify_Btn.FlatAppearance.BorderSize = 0;
            this.Modify_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modify_Btn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modify_Btn.Location = new System.Drawing.Point(0, 137);
            this.Modify_Btn.Name = "Modify_Btn";
            this.Modify_Btn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.Modify_Btn.Size = new System.Drawing.Size(904, 78);
            this.Modify_Btn.TabIndex = 1;
            this.Modify_Btn.Text = "Modify";
            this.Modify_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Modify_Btn.UseVisualStyleBackColor = true;
            this.Modify_Btn.Click += new System.EventHandler(this.Show_UsrCntrl);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.FlatAppearance.BorderSize = 0;
            this.Delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Btn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Btn.Location = new System.Drawing.Point(0, 221);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.Delete_Btn.Size = new System.Drawing.Size(904, 78);
            this.Delete_Btn.TabIndex = 2;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Show_UsrCntrl);
            // 
            // Add_Btn
            // 
            this.Add_Btn.FlatAppearance.BorderSize = 0;
            this.Add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Btn.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Btn.Location = new System.Drawing.Point(0, 53);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.Add_Btn.Size = new System.Drawing.Size(904, 78);
            this.Add_Btn.TabIndex = 0;
            this.Add_Btn.Text = "Add";
            this.Add_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Show_UsrCntrl);
            // 
            // Items
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.Main_Pnl);
            this.Controls.Add(this.Header_Pnl);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Items";
            this.Size = new System.Drawing.Size(910, 535);
            this.Load += new System.EventHandler(this.Items_Load);
            this.Header_Pnl.ResumeLayout(false);
            this.Main_Pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HeaderItem_Btn;
        private System.Windows.Forms.Button HeaderArrow_Btn;
        private System.Windows.Forms.Button HeaderSubMenu_Btn;
        private System.Windows.Forms.Panel Header_Pnl;
        private System.Windows.Forms.Panel Main_Pnl;
        private System.Windows.Forms.Button Modify_Btn;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Button Add_Btn;
        private Add_Item AddItem_UsrCntrl;
        private Modify_Item ModifyItem_UsrCntrl;
        private Delete_Item DeleteItem_UsrCntrl;
    }
}
