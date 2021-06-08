namespace Cashier
{
    partial class Item
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
            this.Category_CmboBx = new System.Windows.Forms.ComboBox();
            this.Item_CmboBx = new System.Windows.Forms.ComboBox();
            this.NoOfItems_NumrcUpDwn = new System.Windows.Forms.NumericUpDown();
            this.Large_RadioBtn = new System.Windows.Forms.RadioButton();
            this.Medium_RadioBtn = new System.Windows.Forms.RadioButton();
            this.Small_RadioBtn = new System.Windows.Forms.RadioButton();
            this.Size_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NoOfItems_NumrcUpDwn)).BeginInit();
            this.SuspendLayout();
            // 
            // Category_CmboBx
            // 
            this.Category_CmboBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Category_CmboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category_CmboBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Category_CmboBx.ForeColor = System.Drawing.Color.White;
            this.Category_CmboBx.FormattingEnabled = true;
            this.Category_CmboBx.Location = new System.Drawing.Point(2, 3);
            this.Category_CmboBx.Name = "Category_CmboBx";
            this.Category_CmboBx.Size = new System.Drawing.Size(121, 24);
            this.Category_CmboBx.TabIndex = 0;
            this.Category_CmboBx.SelectedIndexChanged += new System.EventHandler(this.Category_CmboBx_SelectedIndexChanged);
            // 
            // Item_CmboBx
            // 
            this.Item_CmboBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Item_CmboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Item_CmboBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item_CmboBx.ForeColor = System.Drawing.Color.White;
            this.Item_CmboBx.FormattingEnabled = true;
            this.Item_CmboBx.Location = new System.Drawing.Point(129, 3);
            this.Item_CmboBx.Name = "Item_CmboBx";
            this.Item_CmboBx.Size = new System.Drawing.Size(121, 24);
            this.Item_CmboBx.TabIndex = 1;
            this.Item_CmboBx.SelectedIndexChanged += new System.EventHandler(this.Item_CmboBx_SelectedIndexChanged);
            // 
            // NoOfItems_NumrcUpDwn
            // 
            this.NoOfItems_NumrcUpDwn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.NoOfItems_NumrcUpDwn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoOfItems_NumrcUpDwn.ForeColor = System.Drawing.Color.White;
            this.NoOfItems_NumrcUpDwn.Location = new System.Drawing.Point(256, 3);
            this.NoOfItems_NumrcUpDwn.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NoOfItems_NumrcUpDwn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NoOfItems_NumrcUpDwn.Name = "NoOfItems_NumrcUpDwn";
            this.NoOfItems_NumrcUpDwn.Size = new System.Drawing.Size(41, 28);
            this.NoOfItems_NumrcUpDwn.TabIndex = 2;
            this.NoOfItems_NumrcUpDwn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Large_RadioBtn
            // 
            this.Large_RadioBtn.AutoSize = true;
            this.Large_RadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.Large_RadioBtn.Location = new System.Drawing.Point(55, 30);
            this.Large_RadioBtn.Name = "Large_RadioBtn";
            this.Large_RadioBtn.Size = new System.Drawing.Size(66, 21);
            this.Large_RadioBtn.TabIndex = 3;
            this.Large_RadioBtn.Text = "Large";
            this.Large_RadioBtn.UseVisualStyleBackColor = false;
            // 
            // Medium_RadioBtn
            // 
            this.Medium_RadioBtn.AutoSize = true;
            this.Medium_RadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.Medium_RadioBtn.Location = new System.Drawing.Point(127, 30);
            this.Medium_RadioBtn.Name = "Medium_RadioBtn";
            this.Medium_RadioBtn.Size = new System.Drawing.Size(78, 21);
            this.Medium_RadioBtn.TabIndex = 4;
            this.Medium_RadioBtn.TabStop = true;
            this.Medium_RadioBtn.Text = "Medium";
            this.Medium_RadioBtn.UseVisualStyleBackColor = false;
            // 
            // Small_RadioBtn
            // 
            this.Small_RadioBtn.AutoSize = true;
            this.Small_RadioBtn.BackColor = System.Drawing.Color.Transparent;
            this.Small_RadioBtn.Location = new System.Drawing.Point(211, 31);
            this.Small_RadioBtn.Name = "Small_RadioBtn";
            this.Small_RadioBtn.Size = new System.Drawing.Size(63, 21);
            this.Small_RadioBtn.TabIndex = 5;
            this.Small_RadioBtn.TabStop = true;
            this.Small_RadioBtn.Text = "Small";
            this.Small_RadioBtn.UseVisualStyleBackColor = false;
            // 
            // Size_lbl
            // 
            this.Size_lbl.AutoSize = true;
            this.Size_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Size_lbl.Location = new System.Drawing.Point(14, 30);
            this.Size_lbl.Name = "Size_lbl";
            this.Size_lbl.Size = new System.Drawing.Size(42, 20);
            this.Size_lbl.TabIndex = 4;
            this.Size_lbl.Text = "Size";
            // 
            // Item
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.Size_lbl);
            this.Controls.Add(this.Small_RadioBtn);
            this.Controls.Add(this.Medium_RadioBtn);
            this.Controls.Add(this.Large_RadioBtn);
            this.Controls.Add(this.NoOfItems_NumrcUpDwn);
            this.Controls.Add(this.Item_CmboBx);
            this.Controls.Add(this.Category_CmboBx);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Item";
            this.Size = new System.Drawing.Size(300, 48);
            this.Load += new System.EventHandler(this.Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NoOfItems_NumrcUpDwn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Category_CmboBx;
        private System.Windows.Forms.ComboBox Item_CmboBx;
        private System.Windows.Forms.NumericUpDown NoOfItems_NumrcUpDwn;
        private System.Windows.Forms.RadioButton Large_RadioBtn;
        private System.Windows.Forms.RadioButton Medium_RadioBtn;
        private System.Windows.Forms.RadioButton Small_RadioBtn;
        private System.Windows.Forms.Label Size_lbl;

    }
}
