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
    public partial class Add_Item : UserControl
    {
        public Add_Item()
        {
            InitializeComponent();
        }

        private void Add_Item_Load(object sender, EventArgs e)
        {
            Item_CatName_CmboBx.SelectedIndex = 0;

            SmallPrice_TxtBx.Enabled = SmallPrice_TxtBx.Enabled = false;
        }

        public void LoadData()
        {
            Item_CatName_CmboBx.Items.Clear();
            Item_CatName_CmboBx.Items.Add(new ComboBoxItem("Categories", -1));
            Item_CatName_CmboBx.SelectedIndex = 0;

            try
            {
                Database.conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT id, name FROM category;", Database.conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            Item_CatName_CmboBx.Items.Add(new ComboBoxItem(reader["name"].ToString(), Convert.ToInt32(reader["id"])));
                    }
                }
                Database.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CheckChanged(object sender, EventArgs e)
        {
            if (!(Large_ChkBx.Checked || Medium_ChkBx.Checked || Small_ChkBx.Checked))
                (sender as CheckBox).Checked = true;

            LargePrice_TxtBx.Enabled = Large_ChkBx.Checked;
            SmallPrice_TxtBx.Enabled = Medium_ChkBx.Checked;
            SmallPrice_TxtBx.Enabled = Small_ChkBx.Checked;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawLine(new Pen(Color.White), this.Width / 2 - 25, 20, this.Width / 2 - 25, this.Height - 20);
        }

        private void AddItem_Btn_Click(object sender, EventArgs e)
        {
            if (Item_CatName_CmboBx.SelectedIndex == 0)
                Item_CatName_CmboBx.Focus();
            else if (Item_ItemName_TxtBx.Text.Length < 3)
                Item_ItemName_TxtBx.Focus();
            else if (Large_ChkBx.Checked && (LargePrice_TxtBx.Text.Length == 0 || (LargePrice_TxtBx.Text.Length == 1 && LargePrice_TxtBx.Text == ".")))
                LargePrice_TxtBx.Focus();
            else if (Medium_ChkBx.Checked && (MediumPrice_TxtBx.Text.Length == 0 || (MediumPrice_TxtBx.Text.Length == 1 && MediumPrice_TxtBx.Text == ".")))
                MediumPrice_TxtBx.Focus();
            else if (Small_ChkBx.Checked && (SmallPrice_TxtBx.Text.Length == 0 || (SmallPrice_TxtBx.Text.Length == 1 && SmallPrice_TxtBx.Text == ".")))
                SmallPrice_TxtBx.Focus();


            else
            {
                Database.conn.Open();
                // First we check wheather item already exists of not
                using (SqlCommand cmd = new SqlCommand("SELECT name FROM item WHERE name = @name", Database.conn))
                {
                    cmd.Parameters.AddWithValue("@name", Item_ItemName_TxtBx.Text);
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

                // Now we insert the item
                string query = "INSERT INTO item(name, category_id, sizes";

                if (Large_ChkBx.Checked && Medium_ChkBx.Checked && Small_ChkBx.Checked)
                    query += ", large_price, medium_price, small_price) VALUES(@name, @category_id, @sizes, @large_price, @medium_price, @small_price)";
                else if (Large_ChkBx.Checked && Medium_ChkBx.Checked)
                    query += ", large_price, medium_price) VALUES(@name, @category_id, @sizes, @large_price, @medium_price)";
                else if (Medium_ChkBx.Checked && Small_ChkBx.Checked)
                    query += ", medium_price, small_price) VALUES(@name, @category_id, @sizes, @medium_price, @small_price)";
                else if (Large_ChkBx.Checked && Small_ChkBx.Checked)
                    query += ", large_price, small_price) VALUES(@name, @category_id, @sizes, @large_price, @medium_price, @small_price)";
                else if (Large_ChkBx.Checked)
                    query += ", large_price) VALUES(@name, @category_id, @sizes, @large_price)";
                else if (Medium_ChkBx.Checked)
                    query += ", medium_price) VALUES(@name, @category_id, @sizes, @medium_price)";
                else
                    query += ", small_price) VALUES(@name, @category_id, @sizes, @small_price)";

                using (SqlCommand cmd = new SqlCommand(query, Database.conn))
                {
                    if (Large_ChkBx.Checked && Medium_ChkBx.Checked && Small_ChkBx.Checked)
                    {
                        cmd.Parameters.AddWithValue("@sizes", ItemSizes.All);
                        cmd.Parameters.AddWithValue("@large_price", float.Parse(LargePrice_TxtBx.Text));
                        cmd.Parameters.AddWithValue("@medium_price", float.Parse(SmallPrice_TxtBx.Text));
                        cmd.Parameters.AddWithValue("@small_price", float.Parse(SmallPrice_TxtBx.Text));
                    }
                    else if (Large_ChkBx.Checked && Medium_ChkBx.Checked)
                    {
                        cmd.Parameters.AddWithValue("@sizes", ItemSizes.LargeMedium);
                        cmd.Parameters.AddWithValue("@large_price", float.Parse(LargePrice_TxtBx.Text));
                        cmd.Parameters.AddWithValue("@medium_price", float.Parse(SmallPrice_TxtBx.Text));
                    }
                    else if (Medium_ChkBx.Checked && Small_ChkBx.Checked)
                    {
                        cmd.Parameters.AddWithValue("@sizes", ItemSizes.MediumSmall);
                        cmd.Parameters.AddWithValue("@medium_price", float.Parse(SmallPrice_TxtBx.Text));
                        cmd.Parameters.AddWithValue("@small_price", float.Parse(SmallPrice_TxtBx.Text));
                    }
                    else if (Large_ChkBx.Checked && Small_ChkBx.Checked)
                    {
                        cmd.Parameters.AddWithValue("@sizes", ItemSizes.LargeSmall);
                        cmd.Parameters.AddWithValue("@large_price", float.Parse(LargePrice_TxtBx.Text));
                        cmd.Parameters.AddWithValue("@small_price", float.Parse(SmallPrice_TxtBx.Text));
                    }
                    else if (Large_ChkBx.Checked)
                    {
                        cmd.Parameters.AddWithValue("@sizes", ItemSizes.Large);
                        cmd.Parameters.AddWithValue("@large_price", float.Parse(LargePrice_TxtBx.Text));
                    }
                    else if (Medium_ChkBx.Checked)
                    {
                        cmd.Parameters.AddWithValue("@sizes", ItemSizes.Medium);
                        cmd.Parameters.AddWithValue("@medium_price", float.Parse(SmallPrice_TxtBx.Text));
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@sizes", ItemSizes.Small);
                        cmd.Parameters.AddWithValue("@small_price", float.Parse(SmallPrice_TxtBx.Text));
                    }

                    cmd.Parameters.AddWithValue("@name", Item_ItemName_TxtBx.Text);
                    cmd.Parameters.AddWithValue("@category_id", (Item_CatName_CmboBx.SelectedItem as ComboBoxItem).Id);                    

                    cmd.ExecuteNonQuery();
                }
                Database.conn.Close();

                this.Item_CatName_CmboBx.SelectedIndex = 0;
                this.Item_ItemName_TxtBx.Text = string.Empty;
                this.Large_ChkBx.Checked = true;
                this.Medium_ChkBx.Checked =
                this.Small_ChkBx.Checked = false;

                this.Item_CatName_CmboBx.Focus();
            }
        }

        private void AddCategory_Btn_Click(object sender, EventArgs e)
        {
            if (Cat_Name_TxtBx.Text.Length > 2)
            {
                Database.conn.Open();

                // First we check either entered category already exists or not
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM category WHERE name = @name", Database.conn))
                {
                    cmd.Parameters.AddWithValue("@name", Cat_Name_TxtBx.Text);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Category already exists");
                            Database.conn.Close();
                            return;
                        }
                    }
                }

                // Now we insert the category
                using (SqlCommand cmd = new SqlCommand("INSERT INTO category(name) VALUES(@name)", Database.conn))
                {
                    cmd.Parameters.AddWithValue("@name", Cat_Name_TxtBx.Text);
                    cmd.ExecuteNonQuery();

                    this.Cat_Name_TxtBx.Text = string.Empty;
                    this.Cat_Name_TxtBx.Focus();
                }
                Database.conn.Close();

                LoadData();
            }
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            // Only one decimal point
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }
    }
}
