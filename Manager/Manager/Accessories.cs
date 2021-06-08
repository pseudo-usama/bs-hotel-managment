using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;

namespace Manager
{
    enum ItemSizes
    {
        All,
        Large,
        Medium,
        Small,
        LargeMedium,
        MediumSmall,
        LargeSmall
    }

    enum ItemSize
    {
        Large,
        Medium,
        Small
    }

    enum role
    {
        manager,
        cashier
    }

    class ComboBoxItem
    {
        public string Text;
        public int Id;

        public ComboBoxItem(string Text, int Id)
        {
            this.Text = Text;
            this.Id = Id;
        }

        public override string ToString()
        {
            return Text;
        }
    }

    class Database
    {
        public static SqlConnection conn { get; private set; }
        public static bool Success { get; private set; }

        public static void CreateConnection()
        {
            try
            {
                conn = new SqlConnection("Data Source=pseudo;Initial Catalog=hotel_database;Integrated Security=True");
                Success = true;
            }
            catch
            {
                MessageBox.Show("Database connection failed");
                Success = false;
            }
        }
    }
}
