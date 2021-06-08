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
    public partial class Delete_Item : UserControl
    {
        public Delete_Item()
        {
            InitializeComponent();
        }

        private void Delete_Item_Load(object sender, EventArgs e)
        {

        }

        public void LoadData()
        {
            Cat_Name_CmboBx.Items.Clear();
            Cat_Name_CmboBx.Items.Add(new ComboBoxItem("Category", -1));
            Cat_Name_CmboBx.SelectedIndex = 0;

            Item_ItemName_CmboBx.Items.Clear();
            Item_ItemName_CmboBx.Items.Add(new ComboBoxItem("Category", -1));
            Item_ItemName_CmboBx.SelectedIndex = 0;

            try
            {
                Database.conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT id, name FROM category;", Database.conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                            Cat_Name_CmboBx.Items.Add(new ComboBoxItem(reader["name"].ToString(), Convert.ToInt32(reader["id"])));
                    }
                }

                using (SqlCommand cmd = new SqlCommand("SELECT id, name FROM item;", Database.conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Item_ItemName_CmboBx.Items.Add(new ComboBoxItem(reader["name"].ToString(), Convert.ToInt32(reader["id"])));
                        }
                    }
                }
                Database.conn.Close();
            }
            catch (Exception ex)
            {
                Database.conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawLine(new Pen(Color.White), this.Width / 2, 20, this.Width / 2, this.Height - 20);
        }

        private void Cat_Delete_Btn_Click(object sender, EventArgs e)
        {
            if (Cat_Name_CmboBx.SelectedIndex == 0)
                Cat_Name_CmboBx.Focus();
            else
            {
                try
                {
                    Database.conn.Open();

                    using (SqlCommand command = new SqlCommand("DELETE FROM item WHERE category_id = " + (Cat_Name_CmboBx.SelectedItem as ComboBoxItem).Id, Database.conn))
                    {
                        command.ExecuteNonQuery();
                    }
                    using (SqlCommand command = new SqlCommand("DELETE FROM category WHERE id = " + (Cat_Name_CmboBx.SelectedItem as ComboBoxItem).Id, Database.conn))
                    {
                        command.ExecuteNonQuery();
                    }

                    this.Cat_Name_CmboBx.SelectedIndex = 0;
                    this.Cat_Name_CmboBx.Focus();

                    Database.conn.Close();
                    LoadData();
                }
                catch (Exception ex)
                {
                    Database.conn.Close();
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void Item_Delete_Btn_Click(object sender, EventArgs e)
        {
            if (Item_ItemName_CmboBx.SelectedIndex == 0)
                Item_ItemName_CmboBx.Focus();
            else
            {
                try
                {
                    Database.conn.Open();

                    using (SqlCommand command = new SqlCommand("DELETE FROM item WHERE id = " + (Item_ItemName_CmboBx.SelectedItem as ComboBoxItem).Id, Database.conn))
                    {
                        command.ExecuteNonQuery();
                    }

                    this.Cat_Name_CmboBx.SelectedIndex = 0;
                    this.Cat_Name_CmboBx.Focus();

                    Database.conn.Close();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                this.Item_ItemName_CmboBx.SelectedIndex = 0;
                Item_ItemName_CmboBx.Focus();
            }
        }
    }
}
