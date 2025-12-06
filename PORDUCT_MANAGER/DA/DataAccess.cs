using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PORDUCT_MANAGER.DA
{
    internal class DataAccess // هذا الكلاس للاتصال بقاعدة البيانات
    {
        SqlConnection con;
        public DataAccess(){
            con = new SqlConnection("data source=ALBASSAM\\SQLEXPRESS ; initial catalog =products ; integrated security=true");
       
        }
        public void open() // دالة الحذف 
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        public void close()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        public DataTable SelectData(string proc_name, SqlParameter[] parameters)//
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = proc_name;
            if(parameters  !=null)
                for(int i =0;i< parameters.Length; i++)
                {
                    cmd.Parameters.Add(parameters[i]);
                }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
           da.Fill(dt);
            return dt;

        }
        public void Excutecommend(string proc_name, SqlParameter[] parameters)//
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.CommandText = proc_name;
            if (parameters != null)
                for (int i = 0; i < parameters.Length; i++)
                {
                    cmd.Parameters.Add(parameters[i]);
                }
            cmd.ExecuteNonQuery();
        }
    }// end DataAccess here
}
