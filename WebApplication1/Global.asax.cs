using DevExpress.Entity.Model;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.MiddleTier;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
using System.Linq;
using System.ServiceModel.PeerResolvers;
using System.Web;
using System.Web.Caching;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication1
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            XafTypesInfo.Instance.RegisterEntity(typeof(Solution3.Module.Solution3Module));

        }

        //protected void Session_Start(object sender, EventArgs e)
        //{
        //   WebApplication.SetInstance(Session, new Solution3.Module.Solution3Module());
        //    //...
        //    WebApplication.Instance.Setup("MySolution", WebApplication.Instance.ConnectionString,
        //       System.Configuration.ConfigurationManager.AppSettings["Modules"].Split(';'));
        //    WebApplication.Instance.Start();
        //}
    }
}
