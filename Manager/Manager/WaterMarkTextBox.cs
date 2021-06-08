using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace Manager
{
    class WaterMarkTextBox : TextBox
    {
        private bool IsWaterMark;
        private string waterMark = "";
        public string WaterMark
        {
            get { return waterMark; }
            set
            {
                waterMark = value;
                SetWaterMark();
            }
        }

        private Color normalColor = Color.Black;
        public Color NormalColor
        {
            get { return normalColor; }
            set { normalColor = value; }
        }

        public Color NormalBackColor = Color.White;

        public WaterMarkTextBox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            Enter += new System.EventHandler(WaterMarkTextBox_Enter);
            KeyDown += new KeyEventHandler(keyDown);
            MouseDown += new MouseEventHandler(mouseDown);
            MouseMove += new MouseEventHandler(mouseMove);
            TextChanged += new EventHandler(textChanged);
            ResumeLayout(false);
        }

        private void SetWaterMark()
        {
            IsWaterMark = true;
            ForeColor = Color.Gray;
            Text = waterMark;
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (IsWaterMark)
                SelectionLength = 0;
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            if (IsWaterMark)
                SelectionStart = SelectionLength = 0;
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                (TopLevelControl as Form).Close();
            else if (IsWaterMark && (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right))
                e.Handled = true;


            if (e.KeyCode != Keys.Back)
            {
                if (IsWaterMark && ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)))
                {
                    IsWaterMark = false;
                    ForeColor = normalColor;
                    Text = "";
                }
            }
            else if (Text.Length == 1 || SelectionLength == Text.Length)
            {

            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            if (Text.Length == 0)
            {
                IsWaterMark = true;
                ForeColor = Color.Gray;
                Text = waterMark;
            }
        }

        private void WaterMarkTextBox_Enter(object sender, EventArgs e)
        {
            if (IsWaterMark)
                SelectionStart = SelectionLength = 0;
        }
    }
}
