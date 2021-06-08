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

namespace Manager
{
    public partial class Modify_Item : UserControl
    {
        public Modify_Item()
        {
            InitializeComponent();
        }

        private void Modify_Item_Load(object sender, EventArgs e)
        {
            MediumPrice_TxtBx.Enabled = SmallPrice_TxtBx.Enabled = false;
        }

        public void LoadData()
        {
            Cat_SelectName_CmboBx.Items.Clear();
            Cat_SelectName_CmboBx.Items.Add(new ComboBoxItem("Category", -1));
            Cat_SelectName_CmboBx.SelectedIndex = 0;
            Cat_NewName_TxtBx.Text = "";


            Item_SelectItem_CmboBx.Items.Clear();
            Item_SelectItem_CmboBx.Items.Add(new ComboBoxItem("Category", -1));
            Item_SelectItem_CmboBx.SelectedIndex = 0;

            Item_NewCat_CmboBx.Items.Clear();
            Item_NewCat_CmboBx.Items.Add(new ComboBoxItem("Category", -1));
            Item_NewCat_CmboBx.SelectedIndex = 0;

            Item_NewName_TxtBx.Text = "";

            Large_ChkBx.Checked = true;
            Medium_ChkBx.Checked = Small_ChkBx.Checked = false;

            LargePrice_TxtBx.Text = MediumPrice_TxtBx.Text = SmallPrice_TxtBx.Text = "";

            Cat_SelectName_CmboBx.Focus();

            try
            {
                Database.conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT id, name FROM category;", Database.conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cat_SelectName_CmboBx.Items.Add(new ComboBoxItem(reader["name"].ToString(), Convert.ToInt32(reader["id"])));
                            Item_NewCat_CmboBx.Items.Add(new ComboBoxItem(reader["name"].ToString(), Convert.ToInt32(reader["id"])));
                        }
                    }
                }

                using (SqlCommand cmd = new SqlCommand("SELECT id, name FROM item;", Database.conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            Item_SelectItem_CmboBx.Items.Add(new ComboBoxItem(reader["name"].ToString(), Convert.ToInt32(reader["id"])));
                    }
                }

                Database.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawLine(new Pen(Color.White), this.Width / 2 - 25, 20, this.Width / 2 - 25, this.Height - 20);
        }

        private void Cat_Modify_Btn_Click(object sender, EventArgs e)
        {
            if (Cat_SelectName_CmboBx.SelectedIndex == 0)
                Cat_SelectName_CmboBx.Focus();
            else if (Cat_NewName_TxtBx.Text.Length < 3)
                Cat_NewName_TxtBx.Focus();

            else
            {
                try
                {
                    Database.conn.Open();

                    using (SqlCommand cmd = new SqlCommand("UPDATE category SET name = '" + Cat_NewName_TxtBx.Text + "' WHERE id = " + (Cat_SelectName_CmboBx.SelectedItem as ComboBoxItem).Id, Database.conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    Database.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


                Cat_SelectName_CmboBx.SelectedIndex = 0;
                Cat_NewName_TxtBx.Text = string.Empty;

                Cat_SelectName_CmboBx.Focus();

                LoadData();
            }
        }

        private void Item_Modify_Btn_Click(object sender, EventArgs e)
        {
            if (Item_SelectItem_CmboBx.SelectedIndex == 0)
                Item_SelectItem_CmboBx.Focus();
            else if (Item_NewCat_CmboBx.SelectedIndex == 0)
                Item_NewCat_CmboBx.Focus();
            else if (Item_NewName_TxtBx.Text.Length < 3)
                Item_NewName_TxtBx.Focus();
            else if (Large_ChkBx.Checked && (LargePrice_TxtBx.Text.Length == 0 || (LargePrice_TxtBx.Text.Length == 1 && LargePrice_TxtBx.Text == ".")))
                LargePrice_TxtBx.Focus();
            else if (Medium_ChkBx.Checked && (MediumPrice_TxtBx.Text.Length == 0 || (MediumPrice_TxtBx.Text.Length == 1 && MediumPrice_TxtBx.Text == ".")))
                MediumPrice_TxtBx.Focus();
            else if (Small_ChkBx.Checked && (SmallPrice_TxtBx.Text.Length == 0 || (SmallPrice_TxtBx.Text.Length == 1 && SmallPrice_TxtBx.Text == ".")))
                SmallPrice_TxtBx.Focus();

            else
            {
                try
                {
                    Database.conn.Open();

                    // First we check wheather item already exists of not
                    using (SqlCommand cmd = new SqlCommand("SELECT name FROM item WHERE name = '" + Item_NewName_TxtBx.Text + "';", Database.conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Item already exists");
                                Database.conn.Close();
                                return;
                            }
                        }
                    }

                    // Now we update the item
                    string query = "UPDATE item SET name='" + Item_NewName_TxtBx.Text + "', category_id=" + (Item_NewCat_CmboBx.SelectedItem as ComboBoxItem).Id + ", sizes = ";

                    if (Large_ChkBx.Checked && Medium_ChkBx.Checked && Small_ChkBx.Checked)
                        query += (int)ItemSizes.All + ", large_price = " + float.Parse(LargePrice_TxtBx.Text) + ", medium_price = " + float.Parse(MediumPrice_TxtBx.Text) + ", small_price = " + float.Parse(SmallPrice_TxtBx.Text);
                    else if (Large_ChkBx.Checked && Medium_ChkBx.Checked)
                        query += (int)ItemSizes.LargeMedium + ", large_price = " + float.Parse(LargePrice_TxtBx.Text) + ", medium_price = " + float.Parse(MediumPrice_TxtBx.Text);
                    else if (Medium_ChkBx.Checked && Small_ChkBx.Checked)
                        query += (int)ItemSizes.MediumSmall + ", medium_price = " + float.Parse(MediumPrice_TxtBx.Text) + ", small_price = " + float.Parse(SmallPrice_TxtBx.Text);
                    else if (Large_ChkBx.Checked && Small_ChkBx.Checked)
                        query += (int)ItemSizes.LargeSmall + ", large_price = " + float.Parse(LargePrice_TxtBx.Text) + ", small_price = " + float.Parse(SmallPrice_TxtBx.Text);
                    else if (Large_ChkBx.Checked)
                        query += (int)ItemSizes.Large + ", large_price = " + float.Parse(LargePrice_TxtBx.Text);
                    else if (Medium_ChkBx.Checked)
                        query += (int)ItemSizes.Medium + ", medium_price = " + float.Parse(MediumPrice_TxtBx.Text);
                    else
                        query += (int)ItemSizes.Small + ", small_price = " + float.Parse(SmallPrice_TxtBx.Text);

                    query += " WHERE id = " + (Item_SelectItem_CmboBx.SelectedItem as ComboBoxItem).Id;

                    using (SqlCommand cmd = new SqlCommand(query, Database.conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    Database.conn.Close();

                    Item_SelectItem_CmboBx.SelectedIndex =
                    Item_NewCat_CmboBx.SelectedIndex = 0;
                    Item_NewName_TxtBx.Text = string.Empty;

                    Large_ChkBx.Checked = true;
                    Medium_ChkBx.Checked =
                    Small_ChkBx.Checked = false;

                    LargePrice_TxtBx.Text =
                    MediumPrice_TxtBx.Text =
                    SmallPrice_TxtBx.Text = "";

                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void ChkChanged(object sender, EventArgs e)
        {
            if (!(Large_ChkBx.Checked || Medium_ChkBx.Checked || Small_ChkBx.Checked))
                (sender as CheckBox).Checked = true;

            LargePrice_TxtBx.Enabled = Large_ChkBx.Checked;
            MediumPrice_TxtBx.Enabled = Medium_ChkBx.Checked;
            SmallPrice_TxtBx.Enabled = Small_ChkBx.Checked;
        }

        private void LargePrice_TxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            // Only one decimal point
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }
    }
}
