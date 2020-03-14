using Gdky.TJ.IBll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gdky.TJ.Web.Controllers
{
    public class TestController : Controller
    {
        private ITestBll _bll;
        public TestController(ITestBll bll)
        {
            _bll = bll;
        }
        // GET: Test
        public ViewResult Index()
        {
            var list = _bll.GetList();
            return View(list);
        }
    }
}