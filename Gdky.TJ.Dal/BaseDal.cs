using Gdky.Tj.IDal;
using Gdky.TJ.DataBaseHelper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gdky.TJ.Dal
{
    /// <summary>
    /// dal层操作类
    /// </summary>
    public class BaseDal: IBaseDal
    {
        //从webconfig中读取连接数据库字符串;
        private static readonly string connStr_HW_AI = ConfigurationManager.ConnectionStrings["ConnStr_HW_AI"].ConnectionString;
        private static readonly string connStr_KY_AI = ConfigurationManager.ConnectionStrings["ConnStr_KY_AI"].ConnectionString;
        private static readonly string connStr_HW_Stattion = ConfigurationManager.ConnectionStrings["ConnStr_HW_Stattion"].ConnectionString;
        private static readonly string connStr_KY_Stattion = ConfigurationManager.ConnectionStrings["ConnStr_KY_Stattion"].ConnectionString;
        private static readonly string connStr_HW_Bas = ConfigurationManager.ConnectionStrings["ConnStr_HW_Bas"].ConnectionString;
        private static readonly string connStr_KY_Bas = ConfigurationManager.ConnectionStrings["ConnStr_KY_Bas"].ConnectionString;
        private static readonly string connStr_HW_Hecm = ConfigurationManager.ConnectionStrings["ConnStr_HW_Hecm"].ConnectionString;
        private static readonly string connStr_KY_Hecm = ConfigurationManager.ConnectionStrings["ConnStr_KY_Hecm"].ConnectionString;
        //实例化连接数据库对象;
        public static SqlServerHelper db_HW_AI = new SqlServerHelper(connStr_HW_AI);
        public static SqlServerHelper db_KY_AI = new SqlServerHelper(connStr_KY_AI);
        public static SqlServerHelper db_HW_Stattion = new SqlServerHelper(connStr_HW_Stattion);
        public static SqlServerHelper db_KY_Stattion = new SqlServerHelper(connStr_KY_Stattion);
        public static SqlServerHelper db_HW_Bas = new SqlServerHelper(connStr_HW_Bas);
        public static SqlServerHelper db_KY_Bas = new SqlServerHelper(connStr_KY_Bas);
        public static SqlServerHelper db_HW_Hecm = new SqlServerHelper(connStr_HW_Hecm);
        public static SqlServerHelper db_KY_Hecm = new SqlServerHelper(connStr_KY_Hecm);
    }
}
