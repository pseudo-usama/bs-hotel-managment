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
    public partial class Item : UserControl
    {
        Graphics grp = null;

        public Item()
        {
            InitializeComponent();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            Large_RadioBtn.Visible = Medium_RadioBtn.Visible = Small_RadioBtn.Visible = Size_lbl.Visible = false;
        }

        public void Reset()
        {
            Category_CmboBx.SelectedIndex = Item_CmboBx.SelectedIndex = 0;
            NoOfItems_NumrcUpDwn.Value = 1;
            Large_RadioBtn.Checked = Medium_RadioBtn.Checked = Small_RadioBtn.Checked =
            Large_RadioBtn.Visible = Medium_RadioBtn.Visible = Small_RadioBtn.Visible = Size_lbl.Visible = false;
        }

        public object GetItem()
        {
            if (Category_CmboBx.SelectedIndex == 0 && Item_CmboBx.SelectedIndex == 0)
                return new { };
            else if (Category_CmboBx.SelectedIndex != 0 && Item_CmboBx.SelectedIndex == 0)
                return null;
            else
            {
                return new
                {
                    item_id = (Item_CmboBx.SelectedItem as ComboBoxItem).Id,
                    Size = Large_RadioBtn.Checked ? ItemSize.Large : Medium_RadioBtn.Checked ? ItemSize.Medium : ItemSize.Small,
                    CategoryName = (Category_CmboBx.SelectedItem as ComboBoxItem).Text,
                    amount = NoOfItems_NumrcUpDwn.Value
                };
            }
        }

        public static void LoadData(Item[] items)
        {
            try
            {
                foreach (Item item in items)
                {
                    item.Category_CmboBx.Items.Clear();
                    item.Category_CmboBx.Items.Add(new ComboBoxItem("Category", -1));
                    item.Category_CmboBx.SelectedIndex = 0;

                    item.Item_CmboBx.Items.Clear();
                    item.Item_CmboBx.Items.Add(new ComboBoxItem("Item", -1));
                    item.Item_CmboBx.SelectedIndex = 0;
                }

                Database.conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT * FROM category;", Database.conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            foreach (Item item in items)
                                item.Category_CmboBx.Items.Add(new ComboBoxItem(reader["name"].ToString(), Convert.ToInt32(reader["id"])));
                        reader.Close();
                    }
                }

                Database.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Item_CmboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Item_CmboBx.SelectedIndex == 0)
            {
                Large_RadioBtn.Visible = Medium_RadioBtn.Visible = Small_RadioBtn.Visible =
                Large_RadioBtn.Checked = Medium_RadioBtn.Checked = Small_RadioBtn.Checked =
                Size_lbl.Visible = false;

                if (Category_CmboBx.SelectedIndex != 0)
                {
                    grp = CreateGraphics();
                    grp.DrawRectangle(new Pen(Color.FromArgb(178, 8, 55), 3), 0, 0, Width, Height);
                }
            }
            else
            {
                Invalidate();

                Size_lbl.Visible = true;

                try
                {
                    Database.conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT sizes FROM item WHERE id = " + (Item_CmboBx.SelectedItem as ComboBoxItem).Id, Database.conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();

                            switch ((ItemSizes)Convert.ToInt32(reader["sizes"]))
                            {
                                case ItemSizes.All:
                                    Large_RadioBtn.Enabled = Medium_RadioBtn.Enabled = Small_RadioBtn.Enabled = true;
                                    break;
                                case ItemSizes.Large:
                                    Medium_RadioBtn.Visible = Small_RadioBtn.Visible = Medium_RadioBtn.Checked = Small_RadioBtn.Checked = false;
                                    Large_RadioBtn.Visible = Large_RadioBtn.Checked = true;
                                    break;
                                case ItemSizes.Medium:
                                    Large_RadioBtn.Visible = Small_RadioBtn.Visible = Large_RadioBtn.Checked = Small_RadioBtn.Checked = false;
                                    Medium_RadioBtn.Visible = Medium_RadioBtn.Checked = true;
                                    break;
                                case ItemSizes.Small:
                                    Large_RadioBtn.Visible = Medium_RadioBtn.Visible = Large_RadioBtn.Checked = Medium_RadioBtn.Checked = false;
                                    Small_RadioBtn.Visible = Small_RadioBtn.Checked = true;
                                    break;
                                case ItemSizes.LargeMedium:
                                    Small_RadioBtn.Visible = Small_RadioBtn.Checked = false;
                                    Large_RadioBtn.Visible = Medium_RadioBtn.Visible = Large_RadioBtn.Checked = true;
                                    Medium_RadioBtn.Checked = false;
                                    break;
                                case ItemSizes.MediumSmall:
                                    Large_RadioBtn.Visible = Large_RadioBtn.Checked = false;
                                    Medium_RadioBtn.Visible = Small_RadioBtn.Visible = Medium_RadioBtn.Checked = true;
                                    Small_RadioBtn.Checked = false;
                                    break;
                                case ItemSizes.LargeSmall:
                                    Medium_RadioBtn.Visible = Medium_RadioBtn.Checked = false;
                                    Large_RadioBtn.Visible = Small_RadioBtn.Visible = Large_RadioBtn.Checked = true;
                                    Small_RadioBtn.Checked = false;
                                    break;
                            }

                            reader.Close();
                        }
                    }

                    Database.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void Category_CmboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Category_CmboBx.SelectedIndex != 0)
                {
                    grp = CreateGraphics();
                    grp.DrawRectangle(new Pen(Color.FromArgb(178, 8, 55), 3), 0, 0, Width, Height);
                }
                else
                    Invalidate();

                Item_CmboBx.Items.Clear();
                Item_CmboBx.Items.Add(new ComboBoxItem("Item", -1));
                Item_CmboBx.SelectedIndex = 0;

                Database.conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT id, name FROM item WHERE category_id = " + (Category_CmboBx.SelectedItem as ComboBoxItem).Id, Database.conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            Item_CmboBx.Items.Add(new ComboBoxItem(reader["name"].ToString(), Convert.ToInt32(reader["id"])));
                        reader.Close();
                    }
                }

                Database.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
