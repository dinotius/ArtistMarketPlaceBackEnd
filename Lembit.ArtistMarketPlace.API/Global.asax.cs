﻿using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.WebApi;
using Lembit.ArtistMarketPlace.IoC;

namespace Lembit.ArtistMarketPlace.API
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Dependency_Resolution.IoC.RegisterDependencies();
        }
    }
}