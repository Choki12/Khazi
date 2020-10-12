using Microsoft.Extensions.DependencyInjection;
using System;
using Shiny.Notifications;
using Shiny;
using Shiny.Locations;
using Shiny.Jobs;

namespace KhaziMobileApp
{

    public class MyStartup : Shiny.ShinyStartup
    {   
        public override void ConfigureServices(IServiceCollection services)
        {
            // register your shiny services here
            //services.UseNotifications(true); // set true
            //services.UseGeofencing<MyGeofenceDelegate>(new GeofenceRegion(
            //      "cntower",
            //     new Shiny.Locations.Position(43.6425662, -79.3892455),
            //    Shiny.Locations.Distance.FromMeters(200)
            //));
            //services.RegisterJob(new JobInfo {
            //    Shiny.Jobs.JobInfo.Identifier = nameof(NotificationJob),
            //    Shiny.Jobs.JobInfo.Type = typeof(NotificationJob),
            //   RequiredInternetAccess = Shiny.Jobs.InternetAccess.Any
            //       });
        
         }
    
    }
}
