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
    public partial class All_Orders : UserControl
    {
        public All_Orders()
        {
            InitializeComponent();
        }


        public void LoadData()
        {
            RevenueAmount_lbl.Text = "";

            try
            {
                Database.conn.Open();
                Orders_DtaGrdVw.SelectionChanged -= Orders_DtaGrdVw_SelectionChanged;

                // Fetching Categories
                using (SqlCommand cmd = new SqlCommand("SELECT id, customer_name AS 'Customer Name', datetime AS 'Date Time' FROM [order];", Database.conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        Orders_DtaGrdVw.DataSource = dt;

                        reader.Close();
                    }
                }

                using (SqlCommand cmd = new SqlCommand("SELECT item_price FROM [order_items];", Database.conn))
                {
                    float revenue = 0.0f;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                revenue += float.Parse(reader["item_price"].ToString());
                            }
                        }
                        reader.Close();
                        RevenueAmount_lbl.Text = revenue.ToString() + " Rs";
                    }
                }

                Database.conn.Close();

                Orders_DtaGrdVw_SelectionChanged(new object(), new EventArgs());
                Orders_DtaGrdVw.SelectionChanged += Orders_DtaGrdVw_SelectionChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Orders_DtaGrdVw_SelectionChanged(object sender, EventArgs e)
        {
            Orders_DtaGrdVw.Columns["id"].Visible = true;

            try
            {
                string query =
@"SELECT item_name AS Item, item_price AS Price,
CASE item_size
    WHEN " + (int)ItemSize.Large + @" THEN 'Large'
    WHEN " + (int)ItemSize.Medium + @" THEN 'Medium'
    WHEN " + (int)ItemSize.Small + @" THEN 'Small'
END AS Size,
category_name AS Category, amount AS Amount FROM order_items
WHERE order_id = " + Orders_DtaGrdVw.CurrentRow.Cells["id"].Value.ToString();

                Database.conn.Open();

                // Fetching Categories
                using (SqlCommand cmd = new SqlCommand(query, Database.conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        OrderDetails_DtaGrdVw.DataSource = dt;

                        reader.Close();
                    }
                }

                Database.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            Orders_DtaGrdVw.Columns["id"].Visible = false;
        }
    }
}
