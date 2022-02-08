using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            //string conString = "Data Source = DESKTOP-4TPED8O;database = Products;User ID = ranadheer;Password = ravan2451";
            string conString = ConfigurationManager.ConnectionStrings["msdb"].ConnectionString;
            string query = "select * from product";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conString);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "product");
            dgvProduct.DataSource = ds.Tables["product"];

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string name = txtNames.Text;
            int price = Convert.ToInt32(txtCost.Text);

            string conString = ConfigurationManager.ConnectionStrings["msdb"].ConnectionString;
            string query = "select * from product";

            SqlDataAdapter adapter = new SqlDataAdapter(query, conString);
            DataSet dset = new DataSet();

            adapter.Fill(dset, "product");

            DataRow row = dset.Tables["product"].NewRow();
            row["pid"] = id;
            row["pname"] = name;
            row["pcost"] = price;

            dset.Tables["product"].Rows.Add(row);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(dset.Tables["product"]);

            dgvProduct.DataSource = dset.Tables["product"];
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
