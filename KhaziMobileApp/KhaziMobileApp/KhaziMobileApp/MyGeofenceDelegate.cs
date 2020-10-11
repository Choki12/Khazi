using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Shiny.Locations;
using Shiny.Notifications;

namespace KhaziMobileApp
{
    class MyGeofenceDelegate : IGeofenceDelegate
    {
        readonly INotificationManager notifications;
        public MyGeofenceDelegate(INotificationManager notifications)
        {
            this.notifications = notifications;
        }

        //we make this asynchronous to wait for notifications to come in 
        public async Task OnStatusChanged(GeofenceState newStatus, GeofenceRegion region) 
        {
            var msg = newStatus == GeofenceState.Entered ? "Welcome" : "Goodbye";
            await notifications.Send("Geofence", msg);
        }
    }
}
