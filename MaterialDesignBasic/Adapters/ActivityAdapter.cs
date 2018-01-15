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
using Android.Support.V7.Widget;

namespace MaterialDesignBasic.Adapters
{
    public class ActivityAdapter : RecyclerView.Adapter
    {
        private List<ActivityItem> activityList;
        Activity activity;

        public ActivityAdapter(List<ActivityItem> activityList)
        {
            this.activityList = activityList;
        }

        public override int ItemCount {
            get { return activityList.Count;  }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            throw new NotImplementedException();
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            throw new NotImplementedException();
        }
    }
}