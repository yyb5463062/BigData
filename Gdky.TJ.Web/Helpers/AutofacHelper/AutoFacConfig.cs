using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Gdky.TJ.Web.Helpers.AutofacHelper
{
    public class AutoFacConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetCallingAssembly());//注册mvc的Controller

            
            //注入BLL，UI中使用
            builder.RegisterAssemblyTypes(Assembly.Load("Gdky.TJ.Bll"))
                .AsImplementedInterfaces()  //是以接口方式进行注入
                .InstancePerRequest();       //每次http请求

            //注入DAL，BLL层中使用
            builder.RegisterAssemblyTypes(Assembly.Load("Gdky.TJ.Dal")).AsImplementedInterfaces()
                .InstancePerRequest(); 

            //Cache的注入，使用单例模式
            //builder.RegisterType<RedisCacheManager>()
            //    .As<ICacheManager>()
            //    .SingleInstance()
            //    .PropertiesAutowired();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}