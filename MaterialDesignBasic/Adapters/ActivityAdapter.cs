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
using MaterialDesignBasic.ViewHolder;

namespace MaterialDesignBasic.Adapters
{
        public class ActivityAdapter : RecyclerView.Adapter
        {
            private readonly List<ActivityItem> activityList;
            Activity activity;

            public ActivityAdapter(List<ActivityItem> activityList)
            {
                this.activityList = activityList;
            }

            public override int ItemCount {
                get { return activityList.Count;  }
            }

            //This method gets called every time a row is display
            //One of the parameters passed in is the viewHolder for the row 
            public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
            {
                var vh = (ActivityViewHolder)holder;
                vh.SetActivityItem(activityList[position]);//This item is going to come from our Activity List
            }

            //This method is called when we need to create view holder for a row, where none has been created before.
            //It's responsable for creating both the view and the view Holder
            public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
            {
                View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.activity_item, parent, false);
                return new ActivityViewHolder(itemView);
            }
        }
}