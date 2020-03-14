using Gdky.TJ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gdky.TJ.IBll
{
    public interface ITestBll
    {
        IList<TestModel> GetList();
        void Insert(string Pwd, string Name);
        void Update(int ID, string Pwd, string Name);
        void Delete(int ID);
    }
}
