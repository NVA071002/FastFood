using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FastFood.DBLayer;

namespace FastFood.BS_layer
{
class BLMenu
    {
        int id = 0;
        DBMain db = null;
        public BLMenu()
        {
            db = new DBMain();
        }
        public DataTable getMenu()
        {
            return db.getData("SELECT * FROM MENU");
        }
        public void addBill_Detail(int dishNum, double price, int dish_ID, ref string err)
        {
            id++;
            string sqlString = "Insert Into BILL_DETAIL Values('" + id + "',N'" + dish_ID + "',N'" + dishNum + "',N'" + price + "')";
             db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);

        }
      

    }
}
