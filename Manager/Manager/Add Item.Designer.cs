namespace Manager
{
    partial class Add_Item
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
            this.Cat_Heading_lbl = new System.Windows.Forms.Label();
            this.Item_Heading_lbl = new System.Windows.Forms.Label();
            this.Cat_Name_TxtBx = new System.Windows.Forms.TextBox();
            this.Cat_Name_lbl = new System.Windows.Forms.Label();
            this.Cat_Add_Btn = new System.Windows.Forms.Button();
            this.Item_CatName_CmboBx = new System.Windows.Forms.ComboBox();
            this.Item_ItemName_TxtBx = new System.Windows.Forms.TextBox();
            this.Item_ItemName_lbl = new System.Windows.Forms.Label();
            this.Item_CatName_lbl = new System.Windows.Forms.Label();
            this.Item_Add_Btn = new System.Windows.Forms.Button();
            this.Large_ChkBx = new System.Windows.Forms.CheckBox();
            this.Medium_ChkBx = new System.Windows.Forms.CheckBox();
            this.Small_ChkBx = new System.Windows.Forms.CheckBox();
            this.Item_Price_lbl = new System.Windows.Forms.Label();
            this.LargePrice_TxtBx = new System.Windows.Forms.TextBox();
            this.SmallPrice_TxtBx = new System.Windows.Forms.TextBox();
            this.MediumPrice_TxtBx = new System.Windows.Forms.TextBox();
            this.LargePrice_lbl = new System.Windows.Forms.Label();
            this.MediumPrice_lbl = new System.Windows.Forms.Label();
            this.SmallPrice_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cat_Heading_lbl
            // 
            this.Cat_Heading_lbl.AutoSize = true;
            this.Cat_Heading_lbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cat_Heading_lbl.Location = new System.Drawing.Point(112, 74);
            this.Cat_Heading_lbl.Name = "Cat_Heading_lbl";
            this.Cat_Heading_lbl.Size = new System.Drawing.Size(206, 33);
            this.Cat_Heading_lbl.TabIndex = 0;
            this.Cat_Heading_lbl.Text = "Add Category";
            // 
            // Item_Heading_lbl
            // 
            this.Item_Heading_lbl.AutoSize = true;
            this.Item_Heading_lbl.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Heading_lbl.Location = new System.Drawing.Point(509, 74);
            this.Item_Heading_lbl.Name = "Item_Heading_lbl";
            this.Item_Heading_lbl.Size = new System.Drawing.Size(139, 33);
            this.Item_Heading_lbl.TabIndex = 0;
            this.Item_Heading_lbl.Text = "Add Item";
            // 
            // Cat_Name_TxtBx
            // 
            this.Cat_Name_TxtBx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cat_Name_TxtBx.Location = new System.Drawing.Point(117, 181);
            this.Cat_Name_TxtBx.MaxLength = 20;
            this.Cat_Name_TxtBx.Name = "Cat_Name_TxtBx";
            this.Cat_Name_TxtBx.Size = new System.Drawing.Size(235, 32);
            this.Cat_Name_TxtBx.TabIndex = 0;
            // 
            // Cat_Name_lbl
            // 
            this.Cat_Name_lbl.AutoSize = true;
            this.Cat_Name_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cat_Name_lbl.Location = new System.Drawing.Point(113, 154);
            this.Cat_Name_lbl.Name = "Cat_Name_lbl";
            this.Cat_Name_lbl.Size = new System.Drawing.Size(71, 23);
            this.Cat_Name_lbl.TabIndex = 2;
            this.Cat_Name_lbl.Text = "Name";
            // 
            // Cat_Add_Btn
            // 
            this.Cat_Add_Btn.FlatAppearance.BorderSize = 0;
            this.Cat_Add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cat_Add_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cat_Add_Btn.Location = new System.Drawing.Point(268, 228);
            this.Cat_Add_Btn.Name = "Cat_Add_Btn";
            this.Cat_Add_Btn.Size = new System.Drawing.Size(84, 40);
            this.Cat_Add_Btn.TabIndex = 1;
            this.Cat_Add_Btn.Text = "Add";
            this.Cat_Add_Btn.UseVisualStyleBackColor = true;
            this.Cat_Add_Btn.Click += new System.EventHandler(this.AddCategory_Btn_Click);
            // 
            // Item_CatName_CmboBx
            // 
            this.Item_CatName_CmboBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Item_CatName_CmboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Item_CatName_CmboBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item_CatName_CmboBx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_CatName_CmboBx.ForeColor = System.Drawing.Color.White;
            this.Item_CatName_CmboBx.FormattingEnabled = true;
            this.Item_CatName_CmboBx.Items.AddRange(new object[] {
            "Category"});
            this.Item_CatName_CmboBx.Location = new System.Drawing.Point(514, 181);
            this.Item_CatName_CmboBx.Name = "Item_CatName_CmboBx";
            this.Item_CatName_CmboBx.Size = new System.Drawing.Size(235, 31);
            this.Item_CatName_CmboBx.TabIndex = 2;
            // 
            // Item_ItemName_TxtBx
            // 
            this.Item_ItemName_TxtBx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_ItemName_TxtBx.Location = new System.Drawing.Point(514, 260);
            this.Item_ItemName_TxtBx.MaxLength = 20;
            this.Item_ItemName_TxtBx.Name = "Item_ItemName_TxtBx";
            this.Item_ItemName_TxtBx.Size = new System.Drawing.Size(235, 32);
            this.Item_ItemName_TxtBx.TabIndex = 3;
            // 
            // Item_ItemName_lbl
            // 
            this.Item_ItemName_lbl.AutoSize = true;
            this.Item_ItemName_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_ItemName_lbl.Location = new System.Drawing.Point(510, 233);
            this.Item_ItemName_lbl.Name = "Item_ItemName_lbl";
            this.Item_ItemName_lbl.Size = new System.Drawing.Size(118, 23);
            this.Item_ItemName_lbl.TabIndex = 2;
            this.Item_ItemName_lbl.Text = "Item name";
            // 
            // Item_CatName_lbl
            // 
            this.Item_CatName_lbl.AutoSize = true;
            this.Item_CatName_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_CatName_lbl.Location = new System.Drawing.Point(510, 154);
            this.Item_CatName_lbl.Name = "Item_CatName_lbl";
            this.Item_CatName_lbl.Size = new System.Drawing.Size(167, 23);
            this.Item_CatName_lbl.TabIndex = 2;
            this.Item_CatName_lbl.Text = "Category name";
            // 
            // Item_Add_Btn
            // 
            this.Item_Add_Btn.FlatAppearance.BorderSize = 0;
            this.Item_Add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item_Add_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Add_Btn.Location = new System.Drawing.Point(781, 394);
            this.Item_Add_Btn.Name = "Item_Add_Btn";
            this.Item_Add_Btn.Size = new System.Drawing.Size(84, 40);
            this.Item_Add_Btn.TabIndex = 10;
            this.Item_Add_Btn.Text = "Add";
            this.Item_Add_Btn.UseVisualStyleBackColor = true;
            this.Item_Add_Btn.Click += new System.EventHandler(this.AddItem_Btn_Click);
            // 
            // Large_ChkBx
            // 
            this.Large_ChkBx.AutoSize = true;
            this.Large_ChkBx.Checked = true;
            this.Large_ChkBx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Large_ChkBx.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Large_ChkBx.Location = new System.Drawing.Point(513, 312);
            this.Large_ChkBx.Name = "Large_ChkBx";
            this.Large_ChkBx.Size = new System.Drawing.Size(69, 23);
            this.Large_ChkBx.TabIndex = 4;
            this.Large_ChkBx.Text = "Large";
            this.Large_ChkBx.UseVisualStyleBackColor = true;
            this.Large_ChkBx.CheckedChanged += new System.EventHandler(this.CheckChanged);
            // 
            // Medium_ChkBx
            // 
            this.Medium_ChkBx.AutoSize = true;
            this.Medium_ChkBx.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medium_ChkBx.Location = new System.Drawing.Point(588, 312);
            this.Medium_ChkBx.Name = "Medium_ChkBx";
            this.Medium_ChkBx.Size = new System.Drawing.Size(88, 23);
            this.Medium_ChkBx.TabIndex = 5;
            this.Medium_ChkBx.Text = "Medium";
            this.Medium_ChkBx.UseVisualStyleBackColor = true;
            this.Medium_ChkBx.CheckedChanged += new System.EventHandler(this.CheckChanged);
            // 
            // Small_ChkBx
            // 
            this.Small_ChkBx.AutoSize = true;
            this.Small_ChkBx.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Small_ChkBx.Location = new System.Drawing.Point(682, 312);
            this.Small_ChkBx.Name = "Small_ChkBx";
            this.Small_ChkBx.Size = new System.Drawing.Size(67, 23);
            this.Small_ChkBx.TabIndex = 6;
            this.Small_ChkBx.Text = "Small";
            this.Small_ChkBx.UseVisualStyleBackColor = true;
            this.Small_ChkBx.CheckedChanged += new System.EventHandler(this.CheckChanged);
            // 
            // Item_Price_lbl
            // 
            this.Item_Price_lbl.AutoSize = true;
            this.Item_Price_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_Price_lbl.Location = new System.Drawing.Point(767, 154);
            this.Item_Price_lbl.Name = "Item_Price_lbl";
            this.Item_Price_lbl.Size = new System.Drawing.Size(105, 23);
            this.Item_Price_lbl.TabIndex = 2;
            this.Item_Price_lbl.Text = "Prices (Rs)";
            // 
            // LargePrice_TxtBx
            // 
            this.LargePrice_TxtBx.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LargePrice_TxtBx.Location = new System.Drawing.Point(771, 212);
            this.LargePrice_TxtBx.MaxLength = 20;
            this.LargePrice_TxtBx.Name = "LargePrice_TxtBx";
            this.LargePrice_TxtBx.Size = new System.Drawing.Size(94, 28);
            this.LargePrice_TxtBx.TabIndex = 7;
            // 
            // SmallPrice_TxtBx
            // 
            this.SmallPrice_TxtBx.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmallPrice_TxtBx.Location = new System.Drawing.Point(771, 330);
            this.SmallPrice_TxtBx.MaxLength = 20;
            this.SmallPrice_TxtBx.Name = "SmallPrice_TxtBx";
            this.SmallPrice_TxtBx.Size = new System.Drawing.Size(94, 28);
            this.SmallPrice_TxtBx.TabIndex = 9;
            // 
            // MediumPrice_TxtBx
            // 
            this.MediumPrice_TxtBx.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumPrice_TxtBx.Location = new System.Drawing.Point(771, 271);
            this.MediumPrice_TxtBx.MaxLength = 20;
            this.MediumPrice_TxtBx.Name = "MediumPrice_TxtBx";
            this.MediumPrice_TxtBx.Size = new System.Drawing.Size(94, 28);
            this.MediumPrice_TxtBx.TabIndex = 8;
            // 
            // LargePrice_lbl
            // 
            this.LargePrice_lbl.AutoSize = true;
            this.LargePrice_lbl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LargePrice_lbl.Location = new System.Drawing.Point(767, 190);
            this.LargePrice_lbl.Name = "LargePrice_lbl";
            this.LargePrice_lbl.Size = new System.Drawing.Size(84, 19);
            this.LargePrice_lbl.TabIndex = 2;
            this.LargePrice_lbl.Text = "Large Price";
            // 
            // MediumPrice_lbl
            // 
            this.MediumPrice_lbl.AutoSize = true;
            this.MediumPrice_lbl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumPrice_lbl.Location = new System.Drawing.Point(767, 249);
            this.MediumPrice_lbl.Name = "MediumPrice_lbl";
            this.MediumPrice_lbl.Size = new System.Drawing.Size(103, 19);
            this.MediumPrice_lbl.TabIndex = 2;
            this.MediumPrice_lbl.Text = "Medium Price";
            // 
            // SmallPrice_lbl
            // 
            this.SmallPrice_lbl.AutoSize = true;
            this.SmallPrice_lbl.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmallPrice_lbl.Location = new System.Drawing.Point(769, 308);
            this.SmallPrice_lbl.Name = "SmallPrice_lbl";
            this.SmallPrice_lbl.Size = new System.Drawing.Size(82, 19);
            this.SmallPrice_lbl.TabIndex = 2;
            this.SmallPrice_lbl.Text = "Small Price";
            // 
            // Add_Item
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.Small_ChkBx);
            this.Controls.Add(this.Medium_ChkBx);
            this.Controls.Add(this.Large_ChkBx);
            this.Controls.Add(this.Item_CatName_CmboBx);
            this.Controls.Add(this.Item_Add_Btn);
            this.Controls.Add(this.Cat_Add_Btn);
            this.Controls.Add(this.SmallPrice_lbl);
            this.Controls.Add(this.MediumPrice_lbl);
            this.Controls.Add(this.LargePrice_lbl);
            this.Controls.Add(this.Item_Price_lbl);
            this.Controls.Add(this.Item_CatName_lbl);
            this.Controls.Add(this.Item_ItemName_lbl);
            this.Controls.Add(this.Cat_Name_lbl);
            this.Controls.Add(this.MediumPrice_TxtBx);
            this.Controls.Add(this.SmallPrice_TxtBx);
            this.Controls.Add(this.LargePrice_TxtBx);
            this.Controls.Add(this.Item_ItemName_TxtBx);
            this.Controls.Add(this.Cat_Name_TxtBx);
            this.Controls.Add(this.Item_Heading_lbl);
            this.Controls.Add(this.Cat_Heading_lbl);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Add_Item";
            this.Size = new System.Drawing.Size(910, 457);
            this.Load += new System.EventHandler(this.Add_Item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cat_Heading_lbl;
        private System.Windows.Forms.Label Item_Heading_lbl;
        private System.Windows.Forms.TextBox Cat_Name_TxtBx;
        private System.Windows.Forms.Label Cat_Name_lbl;
        private System.Windows.Forms.Button Cat_Add_Btn;
        private System.Windows.Forms.ComboBox Item_CatName_CmboBx;
        private System.Windows.Forms.TextBox Item_ItemName_TxtBx;
        private System.Windows.Forms.Label Item_ItemName_lbl;
        private System.Windows.Forms.Label Item_CatName_lbl;
        private System.Windows.Forms.Button Item_Add_Btn;
        private System.Windows.Forms.CheckBox Large_ChkBx;
        private System.Windows.Forms.CheckBox Medium_ChkBx;
        private System.Windows.Forms.CheckBox Small_ChkBx;
        private System.Windows.Forms.Label Item_Price_lbl;
        private System.Windows.Forms.TextBox LargePrice_TxtBx;
        private System.Windows.Forms.TextBox SmallPrice_TxtBx;
        private System.Windows.Forms.TextBox MediumPrice_TxtBx;
        private System.Windows.Forms.Label LargePrice_lbl;
        private System.Windows.Forms.Label MediumPrice_lbl;
        private System.Windows.Forms.Label SmallPrice_lbl;

    }
}
