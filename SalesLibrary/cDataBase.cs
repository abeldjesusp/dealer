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
    public class cDataBase
    {
        protected string mv_str_mensaje_user;
        private string mv_str_current_DB;
        /// <summary>
        /// default constructor
        /// </summary>
        public cDataBase()
        {
            mv_str_current_DB = "PUBS";
        }
        public cDataBase(string p_str_DB)
        {
            mv_str_current_DB = p_str_DB;
        }
        /// <summary>
        /// Metodo que corre el query en si....
        /// </summary>
        /// <param name="p_str_sqlQuery"></param>
        /// <returns></returns>
        public DataSet getData(string p_str_sqlQuery)
        {
            try
            {
                SqlConnection objConn = new SqlConnection();
                //objConn.ConnectionString = System.Configuration.ConfigurationManager.AppSettings["DeJesus100315452_WinDealer.Properties.Settings.pubsConnectionString" +
                objConn.ConnectionString = "Data Source=LAPTOP-197OCJ1F;Initial Catalog=pubs; Integrated Security=True";
                //mv_str_current_DB];
                objConn.Open();
                SqlCommand objCmd = new SqlCommand(p_str_sqlQuery, objConn);
                SqlDataAdapter objAdapt = new SqlDataAdapter(objCmd);
                DataSet objDatos = new DataSet();
                objAdapt.Fill(objDatos);
                objConn.Close();
                objCmd.Dispose();
                objAdapt.Dispose();
                return objDatos;
            }
            catch (SqlException objError)
            {
                mv_str_mensaje_user = objError.Message;
                return null;
            }
        }
        /// <summary>
        /// Metodo que corre el query en si....
        /// tipo alta baja (update, insert, delete)
        /// puede ser un select, pero no captura resultSet.
        /// </summary>
        /// <param name="p_str_sqlQuery"></param>
        /// <returns></returns>
        public bool executeDML(string p_str_sqlQuery)
        {
            try
            {
                SqlConnection objConn = new SqlConnection();
                //objConn.ConnectionString = System.Configuration.ConfigurationManager.AppSettings["DeJesus100315452_WinDealer.Properties.Settings.pubsConnectionString" +
                objConn.ConnectionString = "Data Source=LAPTOP-197OCJ1F;Initial Catalog=pubs; Integrated Security=True";
               // mv_str_current_DB];
                objConn.Open();
                SqlCommand objCmd = new SqlCommand(p_str_sqlQuery, objConn);
                objCmd.ExecuteNonQuery();
                objConn.Close();
                objCmd.Dispose();
                return true;
            }
            catch (SqlException objError)
            {
                mv_str_mensaje_user = objError.Message;
                return false;
            }
        }
        /// <summary>
        /// este metodo solo prepara where.....
        /// </summary>
        /// <param name="p_str_tablas"></param>
        /// <param name="p_str_cols"></param>
        /// <param name="p_str_where"></param>
        /// <returns></returns>
        public DataSet getData(string p_str_tablas, string p_str_cols, string p_str_where)
        {
            string lv_str_sql = "SELECT \n";
            if (p_str_tablas.IndexOf(" ") >= 0)
            {
                p_str_tablas = "[" + p_str_tablas + "]";
                p_str_tablas = p_str_tablas.Replace(".", "].[");
            }
            if (p_str_cols == null || p_str_cols.Trim() == "")
                p_str_cols += " * \n";
            if (p_str_where == null || p_str_where.Trim() == "")
            {
                p_str_where = " 1 =1 \n ORDER by 1";
                // solo para ms sql
                p_str_cols = " Top 10 " + p_str_cols;
            }
            lv_str_sql += p_str_cols + " \n";
            lv_str_sql += " FROM " + p_str_tablas + "\n";
            lv_str_sql += " WHERE " + p_str_where;
            return getData(lv_str_sql);
        }
        /// <summary>
        /// Este siempre considera que las columnas son *
        /// </summary>
        /// <param name="p_str_tablas"></param>
        /// <param name="p_str_where"></param>
        /// <returns></returns>
        public DataSet getData(string p_str_tablas, string p_str_where)
        {
            return getData(p_str_tablas, "*", p_str_where);
        }
        public DataTable getTablaSistema()
        {
            string lv_sql = "select schemas.name + '.' + sysobjects.name as name\n" +
            "from sys.sysobjects \n" +
            "inner join sys.schemas\n" +
            "on schemas.schema_id = sysobjects.uid\n" +
            "where type = 'U'\n";
            DataTable objTablaSist = getData(lv_sql).Tables[0];
            return objTablaSist;
        }
        public DataTable getTablaSistema(bool p_indCompile)
        {
            string lv_sql = "execute get_sys_tables;";
            DataTable objTablaSist = getData(lv_sql).Tables[0];
            return objTablaSist;
        }
        public string getMensaje()
        {
            return mv_str_mensaje_user;
        }
        // busca un record
    }
}
