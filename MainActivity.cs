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
	[Activity (Label = "Tom Associates Training - Welcome", MainLauncher = true)]
	public class MainActivity : Activity
	{
		//int count = 1;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Display a Welcome message
			TextView myTextView = FindViewById<TextView> (Resource.Id.main_txtWelcome);

			string welcomeText = "Hello." + Common.newLine + Common.newLine;
			welcomeText += "Thank you for downloading our app." + Common.newLine + Common.newLine;
			welcomeText += "With this app, you can:" + Common.newLine + Common.newLine;
			welcomeText += "\t1.\tDownload our Training Brochure;" + Common.newLine + Common.newLine;
//			welcomeText += "\t2.\tDownload our ('Knowledge in Motion') audio series;" + Common.newLine + Common.newLine;
			welcomeText += "\t2.\tDownload our audio series;" + Common.newLine + Common.newLine;
			welcomeText += "\t3.\tReceive alerts for our upcoming courses;" + Common.newLine + Common.newLine;
			welcomeText += "\t4.\tVisit our Training Blog; and" + Common.newLine + Common.newLine;
			welcomeText += "\t5.\tLocate our Training Facility." + Common.newLine + Common.newLine;
			myTextView.Text = welcomeText;

			// Move when the 'Continue' button is clicked
			Button button = FindViewById<Button> (Resource.Id.main_btnContinue);			
			button.Click += (sender, e) => {           
				var dataToTransfer = new Intent(this, typeof(NavigatorActivity));
				dataToTransfer.PutExtra("goNav", "Go to the Nav screen");
				StartActivity (dataToTransfer);
			};
		}
	}
}
