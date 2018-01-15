using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MaterialDesignBasic.Models;
using System.Globalization;

namespace MaterialDesignBasic.Services
{
    public class ActivityService
    {
        private static List<ActivityItem> Activities = null;

        private List<ActivityItem> GetActivities()
        {
            if (Activities == null)
            {
                Activities = new List<ActivityItem>();

                Activities.Add(new ActivityItem
                {
                    ActivityId = 1,
                    EventDescription = "Attend TLT Meeting",
                    PersonName = "Scott Diehl",
                    ActivityLength = 60,
                    ImageName = "ScottDiehl",
                    Date = DateTime.ParseExact("20171221", "yyyyMMdd", CultureInfo.InvariantCulture)
            });
                Activities.Add(new ActivityItem
                {
                    ActivityId = 2,
                    EventDescription = "Attend TLT Meeting",
                    PersonName = "AllenConway",
                    ActivityLength = 60,
                    ImageName = "AllenConway",
                    Date = DateTime.ParseExact("20171221", "yyyyMMdd", CultureInfo.InvariantCulture)
            });
                Activities.Add(new ActivityItem
                {
                    ActivityId = 3,
                    EventDescription = "Cargill Sales Call",
                    PersonName = "Kevin Ford",
                    ActivityLength = 45,
                    ImageName = "KevinFord",
                    Date = DateTime.ParseExact("20171221", "yyyyMMdd", CultureInfo.InvariantCulture)
        });
                Activities.Add(new ActivityItem
                {
                    ActivityId = 4,
                    EventDescription = "ATI Sales Call",
                    PersonName = "Meghan Lien",
                    ActivityLength = 60,
                    ImageName = "MeghanLien",
                    Date = DateTime.ParseExact("20171221", "yyyyMMdd", CultureInfo.InvariantCulture)
            });
                Activities.Add(new ActivityItem
                {
                    ActivityId = 5,
                    EventDescription = "Show Prep",
                    PersonName = "Troy Walsh",
                    ActivityLength = 60,
                    ImageName = "TroyWalsh",
                    Date = DateTime.ParseExact("20171221", "yyyyMMdd", CultureInfo.InvariantCulture)
            });
            }
            return Activities;
        }

        public List<ActivityItem> FetchActivityList()
        {
            return GetActivities();
        }
    }
}