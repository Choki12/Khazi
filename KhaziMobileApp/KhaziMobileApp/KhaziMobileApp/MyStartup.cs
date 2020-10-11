using Microsoft.Extensions.DependencyInjection;
using System;
using Shiny.Notifications;
using Shiny.Locations;

namespace KhaziMobileApp
{

    public class MyStartup : Shiny.ShinyStartup
    {   
        public override void ConfigureServices(IServiceCollection services)
        {
            // register your shiny services here
            services.UseNotifications(true); // set true
            services.UseGeofencing<MyGeofenceDelegate>(new GeofenceRegion(
                  "cntower",
                   new Position(43.6425662, -79.3892455),
                Distance.FromMeters(200)
               ));
        }
    
    }
}
