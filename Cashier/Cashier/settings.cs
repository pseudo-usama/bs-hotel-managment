using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Cashier
{
    public partial class settings : UserControl
    {
        public bool IsLoggedIn = false;

        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            if (IsLoggedIn)
            {
                Settings_Pnl.Visible = true;
                Login_Pnl.Visible = false;
            }
            else
            {
                Login_Pnl.Visible = true;
                Settings_Pnl.Visible = false;
            }
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Database.conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM account WHERE username = '" + Username_TxtBx.Text + "' AND password = '" + Passowrd_TxtBx.Text + "' AND role = " + (int)role.cashier, Database.conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            IsLoggedIn = true;
                            Login_Pnl.Visible = false;
                            Settings_Pnl.Visible = true;
                            Settings_Pnl.Focus();

                            Username_TxtBx.Text = "";
                            Passowrd_TxtBx.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("User not found!");
                        }
                    }
                }

                Database.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Change_Btn_Click(object sender, EventArgs e)
        {
            if (Change_Username_TxtBx.Text.Length < 3)
                Change_Username_TxtBx.Focus();
            else if (Change_Password_TxtBx.Text.Length < 3)
                Change_Password_TxtBx.Focus();
            else
            {
                try
                {
                    Database.conn.Open();

                    using (SqlCommand cmd = new SqlCommand("UPDATE account SET username = '" + Change_Username_TxtBx.Text + "', password = '" + Change_Password_TxtBx.Text + "' WHERE role = " + (int)role.cashier, Database.conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    Database.conn.Close();

                    Change_Username_TxtBx.Text = "";
                    Change_Password_TxtBx.Text = "";
                    Change_Username_TxtBx.Focus();
                }
                catch (Exception ex)
                {
                    Database.conn.Close();
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Logout_Btn_Click(object sender, EventArgs e)
        {
            IsLoggedIn = false;
            Settings_Pnl.Visible = false;
            Login_Pnl.Visible = true;
        }
    }
}
