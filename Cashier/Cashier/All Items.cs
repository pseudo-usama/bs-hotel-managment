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
    public partial class All_Items : UserControl
    {
        public All_Items()
        {
            InitializeComponent();
        }

        public void LoadItems()
        {
            try
            {
                Database.conn.Open();

                // Fetching Categories
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM category;", Database.conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        Category_DtaGrdVw.DataSource = dt;

                        SelectCat_CmboBx.Items.Clear();
                        SelectCat_CmboBx.Items.Add(new ComboBoxItem("All", -1));

                        SqlDataReader reader2 = cmd.ExecuteReader();

                        if (reader2.HasRows)
                            while (reader2.Read())
                                SelectCat_CmboBx.Items.Add(new ComboBoxItem(reader2["name"].ToString(), Convert.ToInt32(reader2["id"])));

                        reader.Close();
                        reader2.Close();
                    }
                }

                Database.conn.Close();

                SelectCat_CmboBx.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Database.conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        private void SelectCat_CmboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query;
                if (SelectCat_CmboBx.SelectedIndex == 0)
                    query =
@"
SELECT item.name AS Name, category.name AS Category,
CASE item.sizes
    WHEN " + (int)ItemSizes.All + @" THEN 'All'
    WHEN " + (int)ItemSizes.Large + @" THEN 'Large'
    WHEN " + (int)ItemSizes.Medium + @" THEN 'Medium'
    WHEN " + (int)ItemSizes.Small + @" THEN 'Small'
    WHEN " + (int)ItemSizes.LargeMedium + @" THEN 'Large, Medium'
    WHEN " + (int)ItemSizes.MediumSmall + @" THEN 'Medium, Small'
    WHEN " + (int)ItemSizes.LargeSmall + @" THEN 'Large, Small'
END AS Sizes,
item.large_price AS 'Large Price', item.medium_price AS 'Medium Price', item.small_price AS 'Small Price'
FROM item
LEFT JOIN category
ON item.category_id = category.id;
";
                else
                    query =
@"
SELECT item.name AS Name, category.name AS Category,
CASE item.sizes
    WHEN " + (int)ItemSizes.All + @" THEN 'All'
    WHEN " + (int)ItemSizes.Large + @" THEN 'Large'
    WHEN " + (int)ItemSizes.Medium + @" THEN 'Medium'
    WHEN " + (int)ItemSizes.Small + @" THEN 'Small'
    WHEN " + (int)ItemSizes.LargeMedium + @" THEN 'Large, Medium'
    WHEN " + (int)ItemSizes.MediumSmall + @" THEN 'Medium, Small'
    WHEN " + (int)ItemSizes.LargeSmall + @" THEN 'Large, Small'
END AS Sizes,
item.large_price AS 'Large Price', item.medium_price AS 'Medium Price', item.small_price AS 'Small Price'
FROM category
RIGHT JOIN (
    SELECT * FROM item WHERE category_id = " + (SelectCat_CmboBx.SelectedItem as ComboBoxItem).Id + @"
) AS item
ON item.category_id = category.id;
";

                Database.conn.Open();
                // Fetching Items
                using (SqlCommand cmd = new SqlCommand(query, Database.conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        Items_DtaGrdVw.DataSource = dt;
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
    }
}
