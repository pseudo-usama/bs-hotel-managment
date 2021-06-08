using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Highlight_Pnl.Location = new Point(0, 0);
            Highlight_Pnl.Parent = Home_Btn;

            Items_UsrCntrl.Left = -1 * Items_UsrCntrl.Width;
            AllOrders_UsrCntrl.Left = -1 * AllOrders_UsrCntrl.Width;
            Settings_UsrCntrl.Left = -1 * Settings_UsrCntrl.Width;
            AllItem_UsrCntrl.Left = -1 * AllItem_UsrCntrl.Width;
            Items_UsrCntrl.TabStop = AllOrders_UsrCntrl.TabStop = Settings_UsrCntrl.TabStop = Items_UsrCntrl.TabStop = false;

            pictureBox1.Image = Image.FromFile("Home.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            MainPnl_Manager_lbl.Parent = pictureBox1;

            Show();
            Database.CreateConnection();
        }

        #region User Controls Show & Hide

        private void Home_Btn_Click(object sender, EventArgs e)
        {
            if/***/ (Items_UsrCntrl.Left == 0)/******/ { Highlight_Pnl.Parent = Slide.Hide(Items_UsrCntrl)/******/ ? Home_Btn : Highlight_Pnl.Parent; Items_UsrCntrl.TabStop = false;/******/ }
            else if (AllOrders_UsrCntrl.Left == 0)/**/ { Highlight_Pnl.Parent = Slide.Hide(AllOrders_UsrCntrl)/**/ ? Home_Btn : Highlight_Pnl.Parent; AllOrders_UsrCntrl.TabStop = false;/**/ }
            else if (Settings_UsrCntrl.Left == 0)/***/ { Highlight_Pnl.Parent = Slide.Hide(Settings_UsrCntrl)/***/ ? Home_Btn : Highlight_Pnl.Parent; Settings_UsrCntrl.TabStop = false;/***/ }
            else if (AllItem_UsrCntrl.Left == 0)/****/ { Highlight_Pnl.Parent = Slide.Hide(AllItem_UsrCntrl)/****/ ? Home_Btn : Highlight_Pnl.Parent; AllItem_UsrCntrl.TabStop = false;/****/ }
        }

        private void Show_UsrCntrl(object sender, EventArgs e)
        {
            Button Btn = sender as Button;

            if (Settings_UsrCntrl.IsLoggedIn)
            {
                if/***/ (Btn.Name == Items_Btn.Name)/*****/ { Highlight_Pnl.Parent = Slide.Show(Items_UsrCntrl, SlideCompleted)/******/ ? Btn : Highlight_Pnl.Parent; Items_UsrCntrl.TabStop = true;/******/  }
                else if (Btn.Name == AllOrder_Btn.Name)/**/ { Highlight_Pnl.Parent = Slide.Show(AllOrders_UsrCntrl, SlideCompleted)/**/ ? Btn : Highlight_Pnl.Parent; AllOrders_UsrCntrl.TabStop = true;/**/  }
                else if (Btn.Name == AllItems_Btn.Name)/**/ { Highlight_Pnl.Parent = Slide.Show(AllItem_UsrCntrl, SlideCompleted)/****/ ? Btn : Highlight_Pnl.Parent; AllOrders_UsrCntrl.TabStop = true;/**/  }
                else if (Btn.Name == Setting_Btn.Name)/***/ { Highlight_Pnl.Parent = Slide.Show(Settings_UsrCntrl, SlideCompleted)/***/ ? Btn : Highlight_Pnl.Parent; Settings_UsrCntrl.TabStop = true;/***/  }
            }
            else
            {
                if/***/ (Btn.Name == Setting_Btn.Name)/***/ { Highlight_Pnl.Parent = Slide.Show(Settings_UsrCntrl, SlideCompleted)/***/ ? Btn : Highlight_Pnl.Parent; Settings_UsrCntrl.TabStop = true;/***/  }
            }
        }

        void SlideCompleted(string UsrCntrlName)
        {
            if (UsrCntrlName == Items_UsrCntrl.Name)
            {
                AllOrders_UsrCntrl.Left = -1 * AllOrders_UsrCntrl.Width;
                Settings_UsrCntrl.Left = -1 * Settings_UsrCntrl.Width;
                AllItem_UsrCntrl.Left = -1 * AllItem_UsrCntrl.Width;
                AllOrders_UsrCntrl.TabStop = Settings_UsrCntrl.TabStop = AllItem_UsrCntrl.TabStop = false;
            }
            else if (UsrCntrlName == AllOrders_UsrCntrl.Name)
            {
                Items_UsrCntrl.Left = -1 * Items_UsrCntrl.Width;
                Settings_UsrCntrl.Left = -1 * Settings_UsrCntrl.Width;
                AllItem_UsrCntrl.Left = -1 * AllItem_UsrCntrl.Width;
                Items_UsrCntrl.TabStop = Settings_UsrCntrl.TabStop = AllItem_UsrCntrl.TabStop = false;

                AllOrders_UsrCntrl.LoadData();
            }
            else if (UsrCntrlName == Settings_UsrCntrl.Name)
            {
                Items_UsrCntrl.Left = -1 * Items_UsrCntrl.Width;
                AllOrders_UsrCntrl.Left = -1 * AllOrders_UsrCntrl.Width;
                AllItem_UsrCntrl.Left = -1 * AllItem_UsrCntrl.Width;
                Items_UsrCntrl.TabStop = AllOrders_UsrCntrl.TabStop = AllItem_UsrCntrl.TabStop = false;
            }
            else if (UsrCntrlName == AllItem_UsrCntrl.Name)
            {
                Items_UsrCntrl.Left = -1 * Items_UsrCntrl.Width;
                AllOrders_UsrCntrl.Left = -1 * AllOrders_UsrCntrl.Width;
                Settings_UsrCntrl.Left = -1 * Settings_UsrCntrl.Width;
                Items_UsrCntrl.TabStop = AllOrders_UsrCntrl.TabStop = Items_UsrCntrl.TabStop = false;

                // Loading Data From Database
                AllItem_UsrCntrl.LoadItems();
            }
        }

        #endregion

        #region Close & Minimize

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Move Application

        bool IsMouseDown = false;
        int MouseX;
        int MouseY;

        private void Header_Pnl_MouseDown(object sender, MouseEventArgs e)
        {
            this.IsMouseDown = true;
            MouseX = e.X;
            MouseY = e.Y;
        }

        private void Header_Pnl_MouseUp(object sender, MouseEventArgs e)
        {
            this.IsMouseDown = false;

            if (this.Location.Y < 0)
                this.SetDesktopLocation(this.Location.X, 0);
        }

        private void Header_Pnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.IsMouseDown)
                this.SetDesktopLocation(MousePosition.X - MouseX, MousePosition.Y - MouseY);
        }

        #endregion
    }
}
