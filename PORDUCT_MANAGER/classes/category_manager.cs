using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace PORDUCT_MANAGER.classes
{
    internal class category_manager
    {
        DA.DataAccess da = new DA.DataAccess();
        public void add_category(string name)// اظافة صنف جديد
        {
            SqlParameter[] parameter = new SqlParameter[1];
            parameter[0] = new SqlParameter("@category_name ", SqlDbType.NVarChar, 50);
            parameter[0].Value = name;
            da.open(); // دالة فتح الاتصال مع قاعدة ال..
            da.Excutecommend("add_category", parameter);
            da.close();// اغلاق الاتصال 



        }
        public DataTable show_categories() // عرض الصنف الجديد واظهاره في القايمه
        {

            DataTable dt = new DataTable();
            dt = da.SelectData("show_category", null);
            return dt;


        }
        public void edit_category(int id , string name)//لتعديل العنصر المحدد 
        {
            //SqlParameter[] parameters = new SqlParameter[2];
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;

            parameters[1] = new SqlParameter("@new_name ", SqlDbType.NVarChar ,50);
            parameters[1].Value = name ;

            da.open(); 
            da.Excutecommend("edit_category", parameters);
            da.close();
        }
        public void delete_category(int id) // ح دالة لحذف عنصر من الاصناف
        {
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int);
            parameters[0].Value = id;
            da.open();
            da.Excutecommend("delete_category", parameters);
            da.close();

        }
            }
}
