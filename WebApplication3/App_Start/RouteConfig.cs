using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //此处制定地址的路由格式，此处制定的是：服务器：端口号/helloworld/{controller}/{action}/{id}，以上是路由格式，注意
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Movies", action = "Index", id = UrlParameter.Optional }
                //此处三个表示默认的启动位置是
            );
            
        }
    }
}
