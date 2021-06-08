using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class Items : UserControl
    {
        public Items()
        {
            InitializeComponent();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            AddItem_UsrCntrl.Left = -1 * AddItem_UsrCntrl.Width;
            ModifyItem_UsrCntrl.Left = -1 * ModifyItem_UsrCntrl.Width;
            DeleteItem_UsrCntrl.Left = -1 * DeleteItem_UsrCntrl.Width;

            AddItem_UsrCntrl.TabStop = ModifyItem_UsrCntrl.TabStop = DeleteItem_UsrCntrl.TabStop = false;

            this.HeaderSubMenu_Btn.Visible = this.HeaderArrow_Btn.Visible = false;
        }

        #region Show & Hide User Controls

        private void HeaderItem_Btn_Click(object sender, EventArgs e)
        {
            Add_Btn.TabStop = Modify_Btn.TabStop = Delete_Btn.TabStop = true;

            if/***/ (AddItem_UsrCntrl.Left == 0)/*****/ { Slide.Hide(AddItem_UsrCntrl); /*****/ HeaderArrow_Btn.Visible = HeaderSubMenu_Btn.Visible = false; AddItem_UsrCntrl.TabStop = false;/*****/Add_Btn.Focus();/**/ }
            else if (ModifyItem_UsrCntrl.Left == 0)/*****/ { Slide.Hide(ModifyItem_UsrCntrl); /*****/ HeaderArrow_Btn.Visible = HeaderSubMenu_Btn.Visible = false; ModifyItem_UsrCntrl.TabStop = false;/*****/ Modify_Btn.Focus(); }
            else if (DeleteItem_UsrCntrl.Left == 0)/**/ { Slide.Hide(DeleteItem_UsrCntrl); /**/ HeaderArrow_Btn.Visible = HeaderSubMenu_Btn.Visible = false; DeleteItem_UsrCntrl.TabStop = false;/**/ Delete_Btn.Focus(); }
        }

        private void Show_UsrCntrl(object sender, EventArgs e)
        {
            Button Btn = sender as Button;
            Add_Btn.TabStop = Modify_Btn.TabStop = Delete_Btn.TabStop = false;

            if/***/ (Btn.Name == Add_Btn.Name)/*****/ { HeaderSubMenu_Btn.Text = Slide.Show(AddItem_UsrCntrl, SlideCompleted)/*****/ ? "Add" :/*****/ HeaderSubMenu_Btn.Text; AddItem_UsrCntrl.TabStop = true;/*****/ }
            else if (Btn.Name == Modify_Btn.Name)/**/ { HeaderSubMenu_Btn.Text = Slide.Show(ModifyItem_UsrCntrl, SlideCompleted)/*****/ ? "Modify" :/**/ HeaderSubMenu_Btn.Text; ModifyItem_UsrCntrl.TabStop = true;/*****/ }
            else if (Btn.Name == Delete_Btn.Name)/**/ { HeaderSubMenu_Btn.Text = Slide.Show(DeleteItem_UsrCntrl, SlideCompleted)/**/ ? "Delete" :/**/ HeaderSubMenu_Btn.Text; DeleteItem_UsrCntrl.TabStop = true;/**/ }

            this.HeaderSubMenu_Btn.Visible = this.HeaderArrow_Btn.Visible = true;
        }

        void SlideCompleted(string UsrCntrlName)
        {
            if (UsrCntrlName == AddItem_UsrCntrl.Name)
            {
                ModifyItem_UsrCntrl.TabStop = DeleteItem_UsrCntrl.TabStop = false;

                AddItem_UsrCntrl.LoadData();
            }
            else if (UsrCntrlName == ModifyItem_UsrCntrl.Name)
            {
                AddItem_UsrCntrl.TabStop = DeleteItem_UsrCntrl.TabStop = false;

                ModifyItem_UsrCntrl.LoadData();
            }
            else if (UsrCntrlName == DeleteItem_UsrCntrl.Name)
            {
                AddItem_UsrCntrl.TabStop = DeleteItem_UsrCntrl.TabStop = false;

                DeleteItem_UsrCntrl.LoadData();
            }
        }

        #endregion
    }
}
