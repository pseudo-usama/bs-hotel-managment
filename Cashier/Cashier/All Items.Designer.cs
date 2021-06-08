namespace Cashier
{
    partial class All_Items
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SelectCat_CmboBx = new System.Windows.Forms.ComboBox();
            this.SelectCat_lbl = new System.Windows.Forms.Label();
            this.Items_DtaGrdVw = new System.Windows.Forms.DataGridView();
            this.Category_DtaGrdVw = new System.Windows.Forms.DataGridView();
            this.Items_lbl = new System.Windows.Forms.Label();
            this.Categories_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Items_DtaGrdVw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Category_DtaGrdVw)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectCat_CmboBx
            // 
            this.SelectCat_CmboBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.SelectCat_CmboBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectCat_CmboBx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectCat_CmboBx.ForeColor = System.Drawing.Color.White;
            this.SelectCat_CmboBx.FormattingEnabled = true;
            this.SelectCat_CmboBx.Items.AddRange(new object[] {
            "All",
            "cat 1",
            "cat 2",
            "cat 3",
            "cat 4"});
            this.SelectCat_CmboBx.Location = new System.Drawing.Point(670, 24);
            this.SelectCat_CmboBx.Name = "SelectCat_CmboBx";
            this.SelectCat_CmboBx.Size = new System.Drawing.Size(177, 24);
            this.SelectCat_CmboBx.TabIndex = 3;
            this.SelectCat_CmboBx.SelectedIndexChanged += new System.EventHandler(this.SelectCat_CmboBx_SelectedIndexChanged);
            // 
            // SelectCat_lbl
            // 
            this.SelectCat_lbl.AutoSize = true;
            this.SelectCat_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCat_lbl.Location = new System.Drawing.Point(579, 25);
            this.SelectCat_lbl.Name = "SelectCat_lbl";
            this.SelectCat_lbl.Size = new System.Drawing.Size(85, 21);
            this.SelectCat_lbl.TabIndex = 4;
            this.SelectCat_lbl.Text = "Category";
            // 
            // Items_DtaGrdVw
            // 
            this.Items_DtaGrdVw.AllowUserToAddRows = false;
            this.Items_DtaGrdVw.AllowUserToDeleteRows = false;
            this.Items_DtaGrdVw.AllowUserToResizeRows = false;
            this.Items_DtaGrdVw.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Items_DtaGrdVw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.Items_DtaGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Items_DtaGrdVw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Items_DtaGrdVw.Location = new System.Drawing.Point(227, 60);
            this.Items_DtaGrdVw.Name = "Items_DtaGrdVw";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.NullValue = "NaN";
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Items_DtaGrdVw.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.Items_DtaGrdVw.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.NullValue = "NaN";
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.Items_DtaGrdVw.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.Items_DtaGrdVw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Items_DtaGrdVw.Size = new System.Drawing.Size(680, 472);
            this.Items_DtaGrdVw.TabIndex = 6;
            // 
            // Category_DtaGrdVw
            // 
            this.Category_DtaGrdVw.AllowUserToAddRows = false;
            this.Category_DtaGrdVw.AllowUserToDeleteRows = false;
            this.Category_DtaGrdVw.AllowUserToResizeRows = false;
            this.Category_DtaGrdVw.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Category_DtaGrdVw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.Category_DtaGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Category_DtaGrdVw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Category_DtaGrdVw.Location = new System.Drawing.Point(3, 60);
            this.Category_DtaGrdVw.Name = "Category_DtaGrdVw";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.NullValue = "NaN";
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Category_DtaGrdVw.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.Category_DtaGrdVw.RowHeadersVisible = false;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.NullValue = "NaN";
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.Category_DtaGrdVw.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.Category_DtaGrdVw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Category_DtaGrdVw.Size = new System.Drawing.Size(218, 472);
            this.Category_DtaGrdVw.TabIndex = 5;
            // 
            // Items_lbl
            // 
            this.Items_lbl.AutoSize = true;
            this.Items_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items_lbl.Location = new System.Drawing.Point(233, 21);
            this.Items_lbl.Name = "Items_lbl";
            this.Items_lbl.Size = new System.Drawing.Size(66, 26);
            this.Items_lbl.TabIndex = 7;
            this.Items_lbl.Text = "Items";
            // 
            // Categories_lbl
            // 
            this.Categories_lbl.AutoSize = true;
            this.Categories_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories_lbl.Location = new System.Drawing.Point(10, 21);
            this.Categories_lbl.Name = "Categories_lbl";
            this.Categories_lbl.Size = new System.Drawing.Size(117, 26);
            this.Categories_lbl.TabIndex = 8;
            this.Categories_lbl.Text = "Categories";
            // 
            // All_Items
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.Items_lbl);
            this.Controls.Add(this.Categories_lbl);
            this.Controls.Add(this.Items_DtaGrdVw);
            this.Controls.Add(this.Category_DtaGrdVw);
            this.Controls.Add(this.SelectCat_lbl);
            this.Controls.Add(this.SelectCat_CmboBx);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "All_Items";
            this.Size = new System.Drawing.Size(910, 535);
            ((System.ComponentModel.ISupportInitialize)(this.Items_DtaGrdVw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Category_DtaGrdVw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectCat_CmboBx;
        private System.Windows.Forms.Label SelectCat_lbl;
        private System.Windows.Forms.DataGridView Items_DtaGrdVw;
        private System.Windows.Forms.DataGridView Category_DtaGrdVw;
        private System.Windows.Forms.Label Items_lbl;
        private System.Windows.Forms.Label Categories_lbl;
    }
}
