using Gdky.Tj.IDal;
using Gdky.TJ.DataBaseHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gdky.TJ.Dal
{
    public class TestDal : ITestDal
    {
        private SqlServerHelper dbHelper = new SqlServerHelper();
        

        public DataTable GetList()
        {
            string sql = "select ID,Pwd,Name from tb_user";
            var dt = dbHelper.Query(sql);
            return dt;
        }

        public void Insert(string Pwd,string Name)
        {
            string sql = $"insert into tb_user(Pwd,Name) values({Pwd},{Name}) ";
            dbHelper.InsertOrDeleteOrUpdate(sql);
        }

        public void Update(int ID, string Pwd, string Name)
        {
            string sql = $"update tb_user set Pwd = '{Pwd}',Name = '{Name})' ";
            dbHelper.InsertOrDeleteOrUpdate(sql);
        }
        public void Delete(int ID)
        {
            string sql = $"delete from tb_user where ID = '{ID}' ";
            dbHelper.InsertOrDeleteOrUpdate(sql);
        }
    }
}
