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
	//	[Activity (Label = "Tom Associates Training - Please read our Blog", Theme="@android:style/Theme.NoTitleBar")]			
	[Activity (Label = "Tom Associates Training - Please read our Blog")]			
	public class BlogActivity : Activity
	{
		WebView _webview;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Set our view from the "Blog" layout resource
			SetContentView (Resource.Layout.Blog);
			_webview = FindViewById<WebView> (Resource.Id.blog_webView1);
			_webview.SetWebViewClient (new TomAssociatesWebViewClient());
			_webview.LoadUrl ("http://www.tomassociatestrainingblog.info/");
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
	public class TomAssociatesWebViewClient : WebViewClient
	{
		public override bool ShouldOverrideUrlLoading (WebView view, string url)
		{
			view.LoadUrl (url);
			return true;
		}
	}
}
