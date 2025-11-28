using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
using System.Data.SqlClient;
namespace PORDUCT_MANAGER.classes
{
    internal class CLS_product // هذا كلاس المنتجات انشاته انا 
    {
        DA.DataAccess da = new DA.DataAccess(); // تستدعيه في كل كلاس لانه توفر قاعدة....
        public void add_product (string id ,string name ,int Qte ,int sale , int buy, byte[] img ,int id_category)// دالة اظافة منتجات
        {
            SqlParameter[] parameters = new SqlParameter[7];// كلاسات جاهزه في المكاتب الاعلى 
            parameters[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
            parameters[0].Value = id;
            parameters[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            parameters[1].Value = name;
            parameters[2] = new SqlParameter("@Qte", SqlDbType.Int);
            parameters[2].Value = Qte;

            parameters[3] = new SqlParameter("@sale", SqlDbType.Int);
            parameters[3].Value = sale;

            parameters[4] = new SqlParameter("@buy", SqlDbType.Int);
            parameters[4].Value = buy;
            parameters[5] = new SqlParameter("@img", SqlDbType.VarBinary);
            parameters[5].Value = img;

            parameters[6] = new SqlParameter("@id_category", SqlDbType.Int);
            parameters[6].Value = id_category;

            da.open();
            da.Excutecommend("add_product", parameters);//دالة تنفيذ الاستعلام 
            da.close();


       }
        public DataTable  Get_All_Product() // هذة دالة الاجراء اللي عملناها في قاعدة البيانات وهي تبع ادارة المنتجات
        {
            return da.SelectData("Get_all_product", null);

        }

        public DataTable Search_product(string keyword ) // دالة بنفس الكلاس ولكن للبحث عن اسم المنتج حسب اسم المنتج اوالمعرف او الصنف والاجراء تم في قاعدة البيانات
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@keyword", SqlDbType.NVarChar , 50);
            p[0].Value = keyword;

            return da.SelectData("Search_pruduct", p);

        }
        public void delete_product(int id)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@id", SqlDbType.Int);
            p[0].Value = id ;
            da.open();
            da.Excutecommend("delete_product" ,  p);
            da.close();
        }
    }
}
