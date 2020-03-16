using Gdky.Tj.IDal;
using Gdky.TJ.DataBaseHelper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gdky.TJ.Dal
{
    /// <summary>
    /// dal层操作类
    /// </summary>
    public class TestDal : BaseDal,ITestDal
    {
        #region 旧
        ////从webconfig中读取连接数据库字符串;
        //private static readonly string connStr_HW_AI = ConfigurationManager.ConnectionStrings["ConnStr_HW_AI"].ConnectionString;
        //private static readonly string connStr_KY_AI = ConfigurationManager.ConnectionStrings["ConnStr_KY_AI"].ConnectionString;
        //private static readonly string connStr_HW_Stattion = ConfigurationManager.ConnectionStrings["ConnStr_HW_Stattion"].ConnectionString;
        //private static readonly string connStr_KY_Stattion = ConfigurationManager.ConnectionStrings["ConnStr_KY_Stattion"].ConnectionString;
        //private static readonly string connStr_HW_Bas = ConfigurationManager.ConnectionStrings["ConnStr_HW_Bas"].ConnectionString;
        //private static readonly string connStr_KY_Bas = ConfigurationManager.ConnectionStrings["ConnStr_KY_Bas"].ConnectionString;
        //private static readonly string connStr_HW_Hecm = ConfigurationManager.ConnectionStrings["ConnStr_HW_Hecm"].ConnectionString;
        //private static readonly string connStr_KY_Hecm = ConfigurationManager.ConnectionStrings["ConnStr_KY_Hecm"].ConnectionString;
        ////实例化连接数据库对象;
        //private SqlServerHelper db_HW_AI = new SqlServerHelper(connStr_HW_AI);
        //private SqlServerHelper db_KY_AI = new SqlServerHelper(connStr_KY_AI);
        //private SqlServerHelper db_HW_Stattion = new SqlServerHelper(connStr_HW_Stattion);
        //private SqlServerHelper db_KY_Stattion = new SqlServerHelper(connStr_KY_Stattion);
        //private SqlServerHelper db_HW_Bas = new SqlServerHelper(connStr_HW_Bas);
        //private SqlServerHelper db_KY_Bas = new SqlServerHelper(connStr_KY_Bas);
        //private SqlServerHelper db_HW_Hecm = new SqlServerHelper(connStr_HW_Hecm);
        //private SqlServerHelper db_KY_Hecm = new SqlServerHelper(connStr_KY_Hecm);

        #endregion

        #region CRUD书写相应sql,操作数据库

        public DataTable GetList()
        {
            string sql = "select ID,Pwd,Name from tb_user";
            var dt = db_HW_AI.Query(sql);
            return dt;
        }

        public void Insert(string Pwd, string Name)
        {
            string sql = "";//$"insert into tb_user(Pwd,Name) values({Pwd},{Name}) ";
            db_HW_AI.InsertOrDeleteOrUpdate(sql);
        }

        public void Update(int ID, string Pwd, string Name)
        {
            string sql = "";//$"update tb_user set Pwd = '{Pwd}',Name = '{Name})' ";
            db_HW_AI.InsertOrDeleteOrUpdate(sql);
        }
        public void Delete(int ID)
        {
            string sql = "";//$"delete from tb_user where ID = '{ID}' ";
            db_HW_AI.InsertOrDeleteOrUpdate(sql);
        }
        #endregion
    }
}
