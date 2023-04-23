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
using FastFood.Forms;
using FastFood.BS_layer;



namespace FastFood
{
    public partial class Burger : Form
    {
        BLMenu m = new BLMenu();
        string err;

        public Burger()
        {
            InitializeComponent();
        }
        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

    

        private void Burger_Load(object sender, EventArgs e)
        {
        }

        private void btnVegBurger_Click(object sender, EventArgs e)
        {
            double price;
            int id;
            int dishnum = Convert.ToInt32(numericUpDown1.Value.ToString());
            DataTable table = m.getMenu();
            string name = "VEG.BURGER";
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];

                if (name == Convert.ToString(row.ItemArray[1]))
                {
                    
                    price = Convert.ToDouble(row.ItemArray[2]);
                    id = Convert.ToInt32(row.ItemArray[0]);
                    price = dishnum * price;
                    m.addBill_Detail(dishnum, price, id,ref err);
                    MessageBox.Show("thanh cong");
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
