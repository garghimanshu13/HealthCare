﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthCare.Web.Startup))]
namespace HealthCare.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
