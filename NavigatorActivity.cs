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

namespace TomAssociatesTraining
{
	[Activity (Label = "Tom Associates Training - Please choose a task")]			
	public class NavigatorActivity : ListActivity
	{
		string[] menuitems;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			menuitems = new string[] {
				"About Tom Associates >",
				"Our Training Calendar >",
				"Our Downloads Library >",
				"Our Blog >",
				"Our Training Facility >"
			};
			ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, menuitems);
		}
		protected override void OnListItemClick(ListView l, View v, int position, long id)
		{
			var t = menuitems[position];
			Android.Widget.Toast.MakeText(this, t, ToastLength.Short).Show();
			switch (position)
			{
			case 0:       
				var moveToAbout = new Intent (this, typeof(AboutActivity));
				moveToAbout.PutExtra ("goTo", "About");
				StartActivity (moveToAbout);
				break;
			case 1:
				var moveToCalendar = new Intent (this, typeof(CalendarActivity));
				moveToCalendar.PutExtra ("goTo", "Calendar");
				StartActivity (moveToCalendar);
				break;
			case 2:
				var moveToDownloads = new Intent (this, typeof(DownloadsActivity));
				moveToDownloads.PutExtra ("goTo", "Downloads");
				StartActivity (moveToDownloads);
				break;
			case 3:
				var moveToBlog = new Intent (this, typeof(BlogActivity));
				moveToBlog.PutExtra ("goTo", "Blog");
				StartActivity (moveToBlog);
				break;
			case 4:
				var moveToFacility = new Intent (this, typeof(FacilityActivity));
				moveToFacility.PutExtra ("goTo", "Facility");
				StartActivity (moveToFacility);
				break;
			default:
				break;
			}
		}
	}
}
