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
using Android.Webkit;

namespace TomAssociatesTraining
{
	//	[Activity (Label = "Tom Associates Training - Locate our Facility", Theme="@android:style/Theme.NoTitleBar")]			
	[Activity (Label = "Tom Associates Training - Locate our Facility")]
	public class FacilityActivity : Activity
	{
		WebView _webview;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Set our view from the "Blog" layout resource
			SetContentView (Resource.Layout.FacilityLayout);
			_webview = FindViewById<WebView> (Resource.Id.fac_webView1);
			_webview.SetWebViewClient (new TomAssociatesWebViewClient());
			_webview.LoadUrl ("https://maps.google.com/maps?q=tom+associates+training+center+and+conference+hall+lagos+nigeria&hl=en&ll=6.560761,3.368855&spn=0.128073,0.209255&sll=6.563735,3.370775&sspn=0.008005,0.013078&hq=tom+associates+training+center+and+conference+hall&hnear=Lagos,+Nigeria&t=m&z=13");
		}
		public override bool OnKeyDown(Android.Views.Keycode keyCode, Android.Views.KeyEvent e)
		{
			if (keyCode == Keycode.Back && _webview.CanGoBack ()) {
				_webview.GoBack ();
				return true;
			}
			return base.OnKeyDown (keyCode, e);
		}
	}
}
