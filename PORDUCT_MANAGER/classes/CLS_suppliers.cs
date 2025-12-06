using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PORDUCT_MANAGER.classes
{
    internal class CLS_suppliers
    {
        DA.DataAccess da = new DA.DataAccess();

        public void add_supplier(string supplier_name, string phone, string address = "", string email = "")
        {
            SqlParameter[] parameters = new SqlParameter[4];

            parameters[0] = new SqlParameter("@supplier_name", SqlDbType.NVarChar, 100);
            parameters[0].Value = supplier_name;

            parameters[1] = new SqlParameter("@phone", SqlDbType.NVarChar, 20);
            parameters[1].Value = phone;

            parameters[2] = new SqlParameter("@address", SqlDbType.NVarChar, 100);
            parameters[2].Value = address;

            parameters[3] = new SqlParameter("@email", SqlDbType.NVarChar, 50);
            parameters[3].Value = email;

            da.open();
            da.Excutecommend("add_supplier", parameters);
            da.close();
        }

        public DataTable show_suppliers()
        {
            DataTable dt = new DataTable();
            dt = da.SelectData("show_suppliers", null);
            return dt;
        }

        public void edit_supplier(int id, string supplier_name, string phone, string address = "", string email = "")
        {
            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;

            parameters[1] = new SqlParameter("@supplier_name", SqlDbType.NVarChar, 100);
            parameters[1].Value = supplier_name;

            parameters[2] = new SqlParameter("@phone", SqlDbType.NVarChar, 20);
            parameters[2].Value = phone;

            parameters[3] = new SqlParameter("@address", SqlDbType.NVarChar, 100);
            parameters[3].Value = address;

            parameters[4] = new SqlParameter("@email", SqlDbType.NVarChar, 50);
            parameters[4].Value = email;

            da.open();
            da.Excutecommend("edit_supplier", parameters);
            da.close();
        }

        public void delete_supplier(int id)//
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;

            da.open();
            da.Excutecommend("delete_supplier", parameters);
            da.close();
        }
    }
}