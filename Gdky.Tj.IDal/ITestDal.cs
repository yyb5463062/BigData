using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gdky.Tj.IDal
{
    /// <summary>
    /// dal层接口
    /// </summary>
    public interface ITestDal
    {
        DataTable GetList();
        void Insert(string Pwd, string Name);
        void Update(int ID, string Pwd, string Name);
        void Delete(int ID);
    }
}
