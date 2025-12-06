using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PORDUCT_MANAGER.classes
{
    internal class CLS_Sales
    {
        DA.DataAccess da = new DA.DataAccess();

        // إضافة فاتورة بيع
        public void add_sale_order(string seller_name, int customer_id, string notes)
        {
            SqlParameter[] parameters = new SqlParameter[3];

            parameters[0] = new SqlParameter("@Seller_name", SqlDbType.NVarChar, 50);
            parameters[0].Value = seller_name;

            parameters[1] = new SqlParameter("@ID_customer", SqlDbType.Int);
            parameters[1].Value = customer_id;

            parameters[2] = new SqlParameter("@notes", SqlDbType.NVarChar, 50);
            parameters[2].Value = notes;

            da.open();
            da.Excutecommend("add_sale_order", parameters);
            da.close();
        }

        // إضافة تفاصيل فاتورة البيع
        public void add_sale_detail(string id_product, int id_order, int qte, int price, int total_price)
        {
           

            SqlParameter[] parameters = new SqlParameter[5];

            parameters[0] = new SqlParameter("@Id_product", SqlDbType.NVarChar, 50);
            parameters[0].Value = id_product;

            parameters[1] = new SqlParameter("@Id_order", SqlDbType.Int);
            parameters[1].Value = id_order;

            parameters[2] = new SqlParameter("@qte", SqlDbType.Int);
            parameters[2].Value = qte;

            parameters[3] = new SqlParameter("@price", SqlDbType.Int);
            parameters[3].Value = price;  // ← بدون Convert.ToInt32 لأنها int أصلاً

            parameters[4] = new SqlParameter("@total_price", SqlDbType.Int);
            parameters[4].Value = total_price;  // ← بدون Convert.ToInt32 لأنها int أصلاً

            da.open();
            da.Excutecommend("add_sale_detail", parameters);
            da.close();
        }
        

        // الحصول على آخر فاتورة (يمكن استخدام نفس الدالة في CLS_orders)
        public DataTable get_last_sale_order()
        {
            DataTable dt = new DataTable();
            dt = da.SelectData("get_last_sale_order", null);
            return dt;
        }

        // تحديث كمية المنتج بعد البيع
        public void update_product_qte_after_sale(string id_product, int qte)
        {
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@Id_product", SqlDbType.NVarChar, 50);
            parameters[0].Value = id_product;

            parameters[1] = new SqlParameter("@qte", SqlDbType.Int);
            parameters[1].Value = qte;

            da.open();
            da.Excutecommend("update_product_qte_after_sale", parameters);
            da.close();
        }

        // البحث عن منتج للبيع (بسعر البيع)
        public DataTable Search_product_for_sale(string keyword)
        {
            SqlParameter[] p = new SqlParameter[1];
            p[0] = new SqlParameter("@keyword", SqlDbType.NVarChar, 50);
            p[0].Value = keyword;

            return da.SelectData("Search_product_for_sale", p);
        }
    }
}