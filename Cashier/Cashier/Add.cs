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
using System.Drawing.Printing;

namespace Cashier
{
    public partial class Add : UserControl
    {
        Item[] items = new Item[8];
        dynamic[] results;

        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            items[0] = Item1;
            items[1] = Item2;
            items[2] = Item3;
            items[3] = Item4;
            items[4] = Item5;
            items[5] = Item6;
            items[6] = Item7;
            items[7] = Item8;

            Item3.Visible =
            Item4.Visible =
            Item5.Visible =
            Item6.Visible =
            Item7.Visible =
            Item8.Visible = false;

            InnerItems_Pnl.Height = 48;
            this.InnerItems_Pnl.Location = new Point(InnerItems_Pnl.Location.X, OuterItems_Pnl.Height / 2 - InnerItems_Pnl.Height / 2);
        }

        public void LoadData()
        {
            Item.LoadData(items);
        }

        private void AddItem_Btn_Click(object sender, EventArgs e)
        {
            if (Item8.Visible)
                return;

            if (!Item3.Visible)
            {
                Item3.Visible = true;
                InnerItems_Pnl.Height += 70;
            }
            else if (!Item4.Visible)
            {
                Item4.Visible = true;
            }
            else if (!Item5.Visible)
            {
                Item5.Visible = true;
                InnerItems_Pnl.Height += 70;
            }
            else if (!Item6.Visible)
            {
                Item6.Visible = true;
            }
            else if (!Item7.Visible)
            {
                Item7.Visible = true;
                InnerItems_Pnl.Height += 70;
            }
            else
            {
                Item8.Visible = true;
                AddItem_Btn.Enabled = false;
            }

            this.InnerItems_Pnl.Location = new Point(InnerItems_Pnl.Location.X, OuterItems_Pnl.Height / 2 - InnerItems_Pnl.Height / 2);
        }

        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            foreach (Item item in items)
            {
                item.Reset();
                item.Visible = false;
            }

            InnerItems_Pnl.Height = 48;
            this.InnerItems_Pnl.Location = new Point(InnerItems_Pnl.Location.X, OuterItems_Pnl.Height / 2 - InnerItems_Pnl.Height / 2);

            AddItem_Btn.Enabled = true;
        }

        private void Order_Btn_Click(object sender, EventArgs e)
        {
            if (CustomerName_WtrMrkTxtBx.Text.Length == 0)
            {
                CustomerName_WtrMrkTxtBx.Focus();
                return;
            }
                        
            bool flag = false;
            results = new object[8];

            for (int i = 0; i < 8; i++)
            {
                object returned = items[i].GetItem();

                if (returned == null)
                    return;
                else if (!object.Equals(returned, new { }))
                {
                    results[i] = returned;
                    flag = true;
                }
                else
                    results[i] = null;
            }

            if (!flag)
                return;

            int OrderId;

            // First insert record in order table
            try
            {
                Database.conn.Open();
                using (SqlCommand cmd = new SqlCommand("INSERT INTO [order](customer_name, datetime) VALUES(@customer_name, getdate());", Database.conn))
                {
                    cmd.Parameters.AddWithValue("@customer_name", CustomerName_WtrMrkTxtBx.Text);
                    cmd.ExecuteNonQuery();
                }

                // Fetch the inserted order id
                using (SqlCommand cmd = new SqlCommand("SELECT MAX(id) AS id FROM [order];", Database.conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        OrderId = Convert.ToInt32(reader["id"]);
                        reader.Close();
                    }
                }
                Database.conn.Close();
            }
            catch (Exception ex)
            {
                Database.conn.Close();
                MessageBox.Show(ex.ToString());
                return;
            }

            // Now we insert each item in order_item table
            foreach (dynamic result in results)
            {
                break;
                if (result == null)
                    continue;

                try
                {
                    // First we fetch some info about item
                    Database.conn.Open();

                    string query;
                    string ItemName;
                    float Price;

                    if (result.Size == ItemSize.Large)
                        query = "SELECT name, large_price AS price FROM item WHERE id = " + result.item_id;
                    else if (result.Size == ItemSize.Medium)
                        query = "SELECT name, medium_price AS price FROM item WHERE id = " + result.item_id;
                    else
                        query = "SELECT name, small_price AS price FROM item WHERE id = " + result.item_id;

                    using (SqlCommand cmd = new SqlCommand(query, Database.conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            reader.Read();
                            ItemName = reader["name"].ToString();
                            Price = float.Parse(reader["price"].ToString());
                            reader.Close();
                        }
                    }

                    // Now we insert item in order_items table
                    query =
@"INSERT INTO order_items(order_id, item_name, item_price, item_size, category_name, amount)
VALUES(" + OrderId + ", '" + ItemName + "', " + Price + ", " + (int)result.Size + ", '" + result.CategoryName + "', " + result.amount + ")";
                    
                    using (SqlCommand cmd = new SqlCommand(query, Database.conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    Database.conn.Close();
                }
                catch (Exception ex)
                {
                    Database.conn.Close();
                    MessageBox.Show(ex.ToString());
                }
            }

            PrintDocument Bill = new PrintDocument();
            PrintPreviewDialog BillPreview = new PrintPreviewDialog();
            BillPreview.Document = Bill;
            Bill.PrintPage += new PrintPageEventHandler(PrintPage);
            BillPreview.ShowDialog();

            results = null;
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            //e.Graphics.DrawString(CustomerName_WtrMrkTxtBx.Text, new Font("Arail", 12, FontStyle.Regular), Brushes.Black, new System.Drawing.RectangleF(0, 100, 100, 50), StringAlignment.Center);

            foreach (dynamic result in results)
            {
                if(result==null)
                    continue;
            }

            //e.Graphics.DrawString("Contact us: pseudo.developers@gmail.com", new Font("Arail", 12, FontStyle.Regular), Brushes.Black, new Point(0, 0));
            //e.Graphics.DrawString("            GulfamSidhu0@gmail.com", new Font("Arail", 12, FontStyle.Regular), Brushes.Black, new Point(0, 10));
        }
    }
}
