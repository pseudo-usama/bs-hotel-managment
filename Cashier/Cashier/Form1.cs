using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Highlight_Pnl.Location = new Point(0, 0);
            Highlight_Pnl.Parent = Home_Btn;

            Add_UsrCntrl.Left = -1 * Add_UsrCntrl.Width;
            AllOrders_UsrCntrl.Left = -1 * AllOrders_UsrCntrl.Width;
            AllItems_UsrCntrl.Left = -1 * AllItems_UsrCntrl.Width;
            Settings_UsrCntrl.Left = -1 * Settings_UsrCntrl.Width;

            Add_UsrCntrl.TabStop = AllOrders_UsrCntrl.TabStop = AllItems_UsrCntrl.TabStop = Settings_UsrCntrl.TabStop = false;

            pictureBox1.Image = Image.FromFile("Home.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            HomeHeading_lbl.Parent = pictureBox1;

            Menu_Pnl.Focus();

            Show();
            Database.CreateConnection();
        }

        #region Show & Hide User Controls

        private void Home_Btn_Click(object sender, EventArgs e)
        {
            if/***/ (Add_UsrCntrl.Left == 0)/********/ { Highlight_Pnl.Parent = Slide.Hide(Add_UsrCntrl)/********/ ? Home_Btn : Highlight_Pnl.Parent; Add_UsrCntrl.TabStop = false;/********/ }
            else if (AllOrders_UsrCntrl.Left == 0)/**/ { Highlight_Pnl.Parent = Slide.Hide(AllOrders_UsrCntrl)/**/ ? Home_Btn : Highlight_Pnl.Parent; AllOrders_UsrCntrl.TabStop = false;/**/ }
            else if (AllItems_UsrCntrl.Left == 0)/***/ { Highlight_Pnl.Parent = Slide.Hide(AllItems_UsrCntrl)/***/ ? Home_Btn : Highlight_Pnl.Parent; AllItems_UsrCntrl.TabStop = false;/***/ }
            else if (Settings_UsrCntrl.Left == 0)/***/ { Highlight_Pnl.Parent = Slide.Hide(Settings_UsrCntrl)/***/ ? Home_Btn : Highlight_Pnl.Parent; Settings_UsrCntrl.TabStop = false;/***/ }
        }

        private void Show_UsrCntrl(object sender, EventArgs e)
        {
            Button Btn = sender as Button;

            if (Settings_UsrCntrl.IsLoggedIn)
            {
                if/***/ (Btn.Name == Add_Btn.Name)/********/ { Highlight_Pnl.Parent = Slide.Show(Add_UsrCntrl, SlideCompleted)/********/ ? Btn : Highlight_Pnl.Parent; Add_UsrCntrl.TabStop = true;/********/ }
                else if (Btn.Name == AllOrders_Btn.Name)/**/ { Highlight_Pnl.Parent = Slide.Show(AllOrders_UsrCntrl, SlideCompleted)/**/ ? Btn : Highlight_Pnl.Parent; AllOrders_UsrCntrl.TabStop = true;/**/ }
                else if (Btn.Name == ViewItems_Btn.Name)/**/ { Highlight_Pnl.Parent = Slide.Show(AllItems_UsrCntrl, SlideCompleted)/***/ ? Btn : Highlight_Pnl.Parent; AllItems_UsrCntrl.TabStop = true;/***/ }
                else if (Btn.Name == Settings_Btn.Name)/***/ { Highlight_Pnl.Parent = Slide.Show(Settings_UsrCntrl, SlideCompleted)/**/ ? Btn : Highlight_Pnl.Parent; Settings_UsrCntrl.TabStop = true;/****/ }
            }
            else
            {
                if/***/ (Btn.Name == Settings_Btn.Name)/***/ { Highlight_Pnl.Parent = Slide.Show(Settings_UsrCntrl, SlideCompleted)/**/ ? Btn : Highlight_Pnl.Parent; Settings_UsrCntrl.TabStop = true;/****/ }
            }
        }

        void SlideCompleted(string UsrCntrllName)
        {
            if (UsrCntrllName == Add_UsrCntrl.Name)
            {
                AllOrders_UsrCntrl.Left = -1 * AllOrders_UsrCntrl.Width;
                AllItems_UsrCntrl.Left = -1 * AllItems_UsrCntrl.Width;
                Settings_UsrCntrl.Left = -1 * Settings_UsrCntrl.Width;
                AllOrders_UsrCntrl.TabStop = AllItems_UsrCntrl.TabStop = Settings_UsrCntrl.TabStop = false;

                Add_UsrCntrl.LoadData();
            }
            else if (UsrCntrllName == AllOrders_UsrCntrl.Name)
            {
                Add_UsrCntrl.Left = -1 * Add_UsrCntrl.Width;
                AllItems_UsrCntrl.Left = -1 * AllItems_UsrCntrl.Width;
                Settings_UsrCntrl.Left = -1 * Settings_UsrCntrl.Width;
                Add_UsrCntrl.TabStop = AllItems_UsrCntrl.TabStop = Settings_UsrCntrl.TabStop = false;

                AllOrders_UsrCntrl.LoadData();
            }
            else if (UsrCntrllName == AllItems_UsrCntrl.Name)
            {
                Add_UsrCntrl.Left = -1 * Add_UsrCntrl.Width;
                AllOrders_UsrCntrl.Left = -1 * AllOrders_UsrCntrl.Width;
                Settings_UsrCntrl.Left = -1 * Settings_UsrCntrl.Width;
                Add_UsrCntrl.TabStop = AllOrders_UsrCntrl.TabStop = Settings_UsrCntrl.TabStop = false;

                AllItems_UsrCntrl.LoadItems();
            }
            else if (UsrCntrllName == Settings_UsrCntrl.Name)
            {
                Add_UsrCntrl.Left = -1 * Add_UsrCntrl.Width;
                AllOrders_UsrCntrl.Left = -1 * AllOrders_UsrCntrl.Width;
                AllItems_UsrCntrl.Left = -1 * AllItems_UsrCntrl.Width;
                Add_UsrCntrl.TabStop = AllOrders_UsrCntrl.TabStop = AllItems_UsrCntrl.TabStop = false;
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
            IsMouseDown = false;

            if (this.Location.Y < 0)
                this.SetDesktopLocation(this.Location.X, 0);
        }

        private void Header_Pnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
                this.SetDesktopLocation(MousePosition.X - MouseX, MousePosition.Y - MouseY);
        }


        #endregion
    }
}
