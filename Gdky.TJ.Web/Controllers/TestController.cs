using Gdky.TJ.Common;
using Gdky.TJ.IBll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gdky.TJ.Web.Controllers
{
    /// <summary>
    /// 测试控制器
    /// </summary>
    public class TestController : Controller
    {
        private ITestBll _bll;
         
        public TestController(ITestBll bll)
        {
            LogHelper.Info("日志记录开始");
            _bll = bll;//构造注入实例化bll层操作类对象
        }
        // GET: Test
        public ViewResult Index()
        {
            var list = _bll.GetList();
            return View(list);
        }
    }
}