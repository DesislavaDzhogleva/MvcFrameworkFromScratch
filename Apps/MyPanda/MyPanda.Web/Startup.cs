﻿using MyPanda.Data;
using SIS.MvcFramework;
using SIS.MvcFramework.DependencyContainer;
using SIS.MvcFramework.Routing;
using System.Collections.Generic;
using System.Text;

namespace MyPanda.Web
{
    public class Startup : IMvcApplication
    {
        public void Configure(IServerRoutingTable serverRoutingTable)
        {
            //Once on start
            using (var db = new MyPandaDbContext())
            {
                db.Database.EnsureCreated();
            }
        }

        public void ConfigureServices(IServiceProvider serviceProvider)
        {
        }
    }
}