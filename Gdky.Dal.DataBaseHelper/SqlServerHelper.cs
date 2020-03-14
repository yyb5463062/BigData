using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gdky.TJ.DataBaseHelper
{
    public class SqlServerHelper
    {
        private static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString); //连接字符串
        private static SqlCommand cmd = new SqlCommand();

        /// <summary>
        /// 数据库的插入、删除、修改操作
        /// </summary>
        /// <param name="cmdStr"></param>
        public void InsertOrDeleteOrUpdate(string cmdStr)
        {
            cmd.Connection = con;
            cmd.CommandText = cmdStr;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e) //捕抓异常
            {
                throw e;
            }
            finally //数据库操作后关闭连接
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="cmdStr"></param>
        /// <returns></returns>
        public DataTable Query(string cmdStr)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                //数据适配器，填充DataSet.参数1：SQL查询语句，参数2：数据库连接.
                SqlDataAdapter sda = new SqlDataAdapter(cmdStr, con);
                //实例化数据集.
                DataSet ds = new DataSet();
                //将数据适配器中的数据填充到数据集.
                sda.Fill(ds);
                return ds.Tables[0];
            }
            catch (Exception e)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                throw e;
            }
        }

    }
}
