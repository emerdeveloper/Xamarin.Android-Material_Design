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
using Android.Support.V7.Widget;
using MaterialDesignBasic.Models;

namespace MaterialDesignBasic.ViewHolder
{
    class ActivityViewHolder : RecyclerView.ViewHolder
    {
        private TextView activityDescription;
        private TextView activityMusic;
        private ActivityItem activiItem;

        public ActivityViewHolder(View itemView) : base(itemView)
        {
            activityDescription = itemView.FindViewById<TextView>(Resource.Id.activityDescription);
            activityMusic = itemView.FindViewById<TextView>(Resource.Id.activityMisc);
        }

        public void SetActivityItem(ActivityItem activityItem)
        {
            this.activiItem = activityItem;
            activityDescription.Text = this.activiItem.EventDescription;
            activityMusic.Text = $"{this.activiItem.PersonName} - {this.activiItem.Date.ToShortDateString()}  {this.activiItem.ActivityLength} minutes";
        }
    }
}