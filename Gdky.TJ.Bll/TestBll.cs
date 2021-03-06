﻿using Gdky.Tj.IDal;
using Gdky.TJ.Common;
using Gdky.TJ.IBll;
using Gdky.TJ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gdky.TJ.Bll
{
    /// <summary>
    /// bll层操作类
    /// </summary>
    public class TestBll : ITestBll
    {
        private ITestDal _dal;
        public TestBll(ITestDal dal)
        {
            _dal = dal;//构造注入方式实例化dal层对象
        }
        public IList<TestModel> GetList()
        {
            var dt = _dal.GetList();
            var list = ReflectorHelper.DataTableToList<TestModel>(dt);//反射将datatable转换为list实体集合
            return list;
        }

        public void Insert(string Pwd, string Name)
        {
            _dal.Insert(Pwd,Name);
        }

        public void Update(int ID, string Pwd, string Name)
        {
            _dal.Update(ID,Pwd,Name);
        }
        public void Delete(int ID)
        {
            _dal.Delete(ID);
        }
    }
}
