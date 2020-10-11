using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Shiny;


namespace KhaziMobileApp
{

    public class MyStartup : Shiny.ShinyStartup
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            // register your shiny services here
            services.UseNotifications(); // set true
        }
    
    }
}
