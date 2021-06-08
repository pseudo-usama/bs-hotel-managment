namespace Cashier
{
    partial class AllOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Orders_DtaGrdVw = new System.Windows.Forms.DataGridView();
            this.Orders_lbl = new System.Windows.Forms.Label();
            this.OrderDetails_DtaGrdVw = new System.Windows.Forms.DataGridView();
            this.OrderDetails_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Orders_DtaGrdVw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetails_DtaGrdVw)).BeginInit();
            this.SuspendLayout();
            // 
            // Orders_DtaGrdVw
            // 
            this.Orders_DtaGrdVw.AllowUserToAddRows = false;
            this.Orders_DtaGrdVw.AllowUserToDeleteRows = false;
            this.Orders_DtaGrdVw.AllowUserToResizeRows = false;
            this.Orders_DtaGrdVw.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Orders_DtaGrdVw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Orders_DtaGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Orders_DtaGrdVw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Orders_DtaGrdVw.Location = new System.Drawing.Point(3, 60);
            this.Orders_DtaGrdVw.Name = "Orders_DtaGrdVw";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "NaN";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Orders_DtaGrdVw.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Orders_DtaGrdVw.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = "NaN";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Orders_DtaGrdVw.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Orders_DtaGrdVw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Orders_DtaGrdVw.Size = new System.Drawing.Size(218, 472);
            this.Orders_DtaGrdVw.TabIndex = 6;
            this.Orders_DtaGrdVw.SelectionChanged += new System.EventHandler(this.Orders_DtaGrdVw_SelectionChanged);
            // 
            // Orders_lbl
            // 
            this.Orders_lbl.AutoSize = true;
            this.Orders_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orders_lbl.Location = new System.Drawing.Point(10, 21);
            this.Orders_lbl.Name = "Orders_lbl";
            this.Orders_lbl.Size = new System.Drawing.Size(101, 32);
            this.Orders_lbl.TabIndex = 9;
            this.Orders_lbl.Text = "Orders";
            // 
            // OrderDetails_DtaGrdVw
            // 
            this.OrderDetails_DtaGrdVw.AllowUserToAddRows = false;
            this.OrderDetails_DtaGrdVw.AllowUserToDeleteRows = false;
            this.OrderDetails_DtaGrdVw.AllowUserToResizeRows = false;
            this.OrderDetails_DtaGrdVw.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDetails_DtaGrdVw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.OrderDetails_DtaGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrderDetails_DtaGrdVw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.OrderDetails_DtaGrdVw.Location = new System.Drawing.Point(227, 60);
            this.OrderDetails_DtaGrdVw.Name = "OrderDetails_DtaGrdVw";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.NullValue = "NaN";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDetails_DtaGrdVw.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.OrderDetails_DtaGrdVw.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.NullValue = "NaN";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.OrderDetails_DtaGrdVw.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.OrderDetails_DtaGrdVw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDetails_DtaGrdVw.Size = new System.Drawing.Size(680, 472);
            this.OrderDetails_DtaGrdVw.TabIndex = 10;
            // 
            // OrderDetails_lbl
            // 
            this.OrderDetails_lbl.AutoSize = true;
            this.OrderDetails_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDetails_lbl.Location = new System.Drawing.Point(233, 21);
            this.OrderDetails_lbl.Name = "OrderDetails_lbl";
            this.OrderDetails_lbl.Size = new System.Drawing.Size(182, 32);
            this.OrderDetails_lbl.TabIndex = 11;
            this.OrderDetails_lbl.Text = "Order Details";
            // 
            // AllOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(40)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.OrderDetails_lbl);
            this.Controls.Add(this.OrderDetails_DtaGrdVw);
            this.Controls.Add(this.Orders_lbl);
            this.Controls.Add(this.Orders_DtaGrdVw);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AllOrder";
            this.Size = new System.Drawing.Size(910, 535);
            ((System.ComponentModel.ISupportInitialize)(this.Orders_DtaGrdVw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetails_DtaGrdVw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Orders_DtaGrdVw;
        private System.Windows.Forms.Label Orders_lbl;
        private System.Windows.Forms.DataGridView OrderDetails_DtaGrdVw;
        private System.Windows.Forms.Label OrderDetails_lbl;
    }
}
