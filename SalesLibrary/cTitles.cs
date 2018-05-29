using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace SalesLibrary
{
    public class cTitles : cDataBase
    {
        //PROPERTIES
        private string _mv_title_id;
        private string _mv_title;
        private string _mv_type;
        private string _mv_pub_id;
        private float _mv_price;
        private int _mv_advance;
        private int _mv_royalty;
        private int _mv_ytd_sales;
        private string _mv_notes;
        private DateTime _mv_pubdate;
        private DataTable obj_AllBooks;
        public cTitles()
        {
        }
        // GETTERS
        public string gettitle_id() { return _mv_title_id; }
        public string gettitle() { return _mv_title; }
        public string gettype() { return _mv_type; }
        public string getpub_id() { return _mv_pub_id; }
        public float getprice() { return _mv_price; }
        public int getadvance() { return _mv_advance; }
        public int getroyalty() { return _mv_royalty; }
        public int getytd_sales() { return _mv_ytd_sales; }
        public string getnotes() { return _mv_notes; }
        public DateTime getpubdate() { return _mv_pubdate; }
        public DataTable getAllBook()
        {
            return obj_AllBooks;
        }
        // METHODS
        public bool Buscar(string p_str_criterio, bool p_ind_PK)
        {
            try
            {
                string lv_filtro = p_ind_PK ? "title_id='" + p_str_criterio + "'" : "title like '%" +
                p_str_criterio + "%'";
                obj_AllBooks = getData("titles", lv_filtro).Tables[0];
                LlenarAtributos();
                return _mv_title_id != "";
            }
            catch (Exception objError)
            {
                base.mv_str_mensaje_user = objError.Message;
                obj_AllBooks = null;
                return false;
            }
        }
        public bool Agregar(string p_title_id,
        string p_title,
        string p_type,
        string p_pub_id,
        float p_price,
        int p_advance,
        int p_royalty,
        int p_ytd_sales,
        string p_notes,
        DateTime p_pubdate)
        {
            try
            {
                string lv_INSERT_SQL = "INSERT INTO titles VALUES(";
                lv_INSERT_SQL += "'" + p_title_id + "'";
                lv_INSERT_SQL += ",'" + p_title + "'";
                lv_INSERT_SQL += ",'" + p_type + "'";
                lv_INSERT_SQL += ",'" + p_pub_id + "'";
                lv_INSERT_SQL += "," + p_price + "";
                lv_INSERT_SQL += "," + p_advance + "";
                lv_INSERT_SQL += "," + p_royalty + "";
                lv_INSERT_SQL += "," + p_ytd_sales + "'";
                lv_INSERT_SQL += ",'" + p_notes + "'";
                lv_INSERT_SQL += ",'" + p_pubdate + "')";
                return executeDML(lv_INSERT_SQL);
            }
            catch (Exception objError)
            {
                base.mv_str_mensaje_user = objError.Message;
                return false;
            }
        }
        public bool Actualizar(string p_str_criterio)
        {
            return true;
        }
        public bool Eliminar(string p_str_criterio)
        {
            return true;
        }
        private void LlenarAtributos()
        {
            try
            {
                _mv_title_id = "";
                _mv_title = "";
                _mv_type = "";
                _mv_pub_id = "";
                _mv_price = 0;
                _mv_advance = 0;
                _mv_royalty = 0;
                _mv_ytd_sales = 0;
                _mv_notes = "";
                _mv_pubdate = DateTime.Now;
                if (obj_AllBooks.Rows.Count == 0)
                    return;
                DataRow objRecord = obj_AllBooks.Rows[0];
                _mv_title_id = objRecord["title_id"].ToString();
                _mv_title = objRecord["title_id"].ToString();
                _mv_type = objRecord["title_id"].ToString();
                _mv_pub_id = objRecord["title_id"].ToString();
                _mv_price = float.Parse(objRecord["price"].ToString());
                _mv_advance = int.Parse(objRecord["advance"].ToString());
                _mv_royalty = int.Parse(objRecord["royalty"].ToString());
                _mv_ytd_sales = int.Parse(objRecord["ytd_sales"].ToString());
                _mv_notes = objRecord["title_id"].ToString();
                _mv_pubdate = DateTime.Parse(objRecord["pubdate"].ToString());
            }
            catch (Exception objError)
            {
                base.mv_str_mensaje_user = objError.Message;
            }
        }
    }
}
