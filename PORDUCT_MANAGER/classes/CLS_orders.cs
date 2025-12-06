using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PORDUCT_MANAGER.classes
{
    internal class CLS_orders// عملت هنا كلاس خاص با اظافة فاتورة شراء 
    {
        DA.DataAccess da = new DA.DataAccess();

        public void add_purchase_order(string seller_name, int customer_id, string notes)// اظافة  فاتورة شراء 
        {
            SqlParameter[] parameters = new SqlParameter[3];

            parameters[0] = new SqlParameter("@Seller_name", SqlDbType.NVarChar, 50);
            parameters[0].Value = seller_name;

            parameters[1] = new SqlParameter("@ID_customer", SqlDbType.Int);
            parameters[1].Value = customer_id;

            parameters[2] = new SqlParameter("@notes", SqlDbType.NVarChar, 50);
            parameters[2].Value = notes;

            da.open();
            da.Excutecommend("add_purchase_order", parameters);
            da.close();
        }

        public void add_order_detail(string id_product, int id_order, int qte, int price, int total_price) //  اظافة تفاصيل الفاتورة 
        {
            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@Id_product", SqlDbType.NVarChar, 50);
            parameters[0].Value = id_product;

            parameters[1] = new SqlParameter("@Id_order", SqlDbType.Int);
            parameters[1].Value = id_order;

            parameters[2] = new SqlParameter("@qte", SqlDbType.Int);
            parameters[2].Value = qte;

            parameters[3] = new SqlParameter("@price", SqlDbType.Int);
            parameters[3].Value = price;

            parameters[4] = new SqlParameter("@total_price", SqlDbType.Int);
            parameters[4].Value = total_price;

            da.open();
            da.Excutecommend("add_order_detail", parameters);
            da.close();
        }

        public DataTable get_last_order() // للحصول على اخر فاتورة 
        {
            DataTable dt = new DataTable();
            dt = da.SelectData("get_last_order", null);
            return dt;
        }

        public void update_product_qte(string id_product, int qte) //  لتعديل كمية المنتج 
        {
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@Id_product", SqlDbType.NVarChar, 50);
            parameters[0].Value = id_product;

            parameters[1] = new SqlParameter("@qte", SqlDbType.Int);
            parameters[1].Value = qte;

            da.open();
            da.Excutecommend("update_product_qte", parameters);
            da.close();
        }
    }
}
