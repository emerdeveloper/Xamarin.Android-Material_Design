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
using MaterialDesignBasic.Services;
using MaterialDesignBasic.Adapters;
using Android.Support.V7.App;
using Android.Support.Design.Widget;
using Android.Views.Animations;
using Android.Support.V7.Widget;

namespace MaterialDesignBasic.Activities
{
    [Activity(Label = "Material Design", MainLauncher = true, Theme = "@style/Theme.MyTheme")]
    public class MainActivity : AppCompatActivity
    {
        FloatingActionButton fab;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.main);

            fab = FindViewById<FloatingActionButton>(Resource.Id.fab_add);
            fab.Click += OnFabClick;
            fab.Visibility = ViewStates.Invisible;

            var activityList = FindViewById<RecyclerView>(Resource.Id.activityList);
            var activityService = new ActivityService();
            var activities = activityService.FetchActivityList();
            var layoutManager = new LinearLayoutManager(this);
            var adapter = new ActivityAdapter(activities);

            layoutManager.Orientation = LinearLayoutManager.Vertical;
            activityList.SetLayoutManager(layoutManager);
            activityList.SetAdapter(adapter);
        }

        private void OnFabClick(object sender, EventArgs e)
        {
            StartActivity(new Intent(this, typeof(AddActivity)));
        }

        private void AnimateShow(View view)
        {
            //create new ScaleAnimation, this allows us to do is basically 
            //have our View appear to grow onto the screen from a single point.
            var anim = new ScaleAnimation(0, 1, 0, 1, .5f, .5f);
            anim.FillBefore = true;
            anim.FillAfter = true;
            anim.FillEnabled = true;
            anim.Duration = 300;
            anim.StartOffset = 500;

            //This do that the Floating Action Button, as it grows,
            //Will grow slightly larger than its normal size, and 
            //then appear to snap (comprimir) back to its normal size.
            anim.Interpolator = new OvershootInterpolator();
            view.StartAnimation(anim);
        }

        protected override void OnResume()
        {
            base.OnResume();
            if (fab.Visibility == ViewStates.Invisible)
            {
                AnimateShow(fab);
            }
        }
    }
}