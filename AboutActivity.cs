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
	[Activity (Label = "Tom Associates Training - About Us")]			
	public class AboutActivity : Activity
	{
		//int count = 1;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "About" layout resource
			SetContentView (Resource.Layout.AboutLayout);

			// Display a Welcome message
			TextView myTextView = FindViewById<TextView> (Resource.Id.about_txtWelcome);

			string aboutText = "Tom Associates is a limited liability company incorporated in Nigeria. We commenced business in 1992." + Common.newLine + Common.newLine;
			aboutText += "Our Management Development Centre is built on a well-appointed location at Anthony Village on the mainland of Lagos, Nigeria. It is a purpose-developed perfect venue for seminars, meetings, training sessions and retreats. The centre provides a most convenient meeting point when it is important to avoid the intractable Lagos traffic. It is also most accessible from both the local and international airports. There are six conference/meeting rooms which feature the latest in comfort and state-of-the-art equipment. The reference library is well-stocked." + Common.newLine + Common.newLine;
			aboutText += "Our core business is about:" + Common.newLine + Common.newLine;
			aboutText += "\t1.\tFacilitation of Management Retreats." + Common.newLine + Common.newLine;
			aboutText += "\t2.\tWorkshops and seminars in the following:" + Common.newLine + Common.newLine;
			aboutText += "\t\ta.\tBusiness Strategy & Management" + Common.newLine + Common.newLine;
			aboutText += "\t\tb.\tCustomer Service" + Common.newLine + Common.newLine;
			aboutText += "\t\tc.\tFinancial Management" + Common.newLine + Common.newLine;
			aboutText += "\t\td.\tHuman Capital Management" + Common.newLine + Common.newLine;
			aboutText += "\t\te.\tLeadership Development" + Common.newLine + Common.newLine;
			aboutText += "\t\tf.\tMarketing Management" + Common.newLine + Common.newLine;
			aboutText += "\t\tg.\tPersonal Skills Development" + Common.newLine + Common.newLine;
			aboutText += "\t\th.\tProduction & Quality Management" + Common.newLine + Common.newLine;
			aboutText += "\t\ti.\tSelling Skills & Sales Management" + Common.newLine + Common.newLine;
			aboutText += "\t\tj.\tAdministrative Management Skills" + Common.newLine + Common.newLine;
			aboutText += "Our Philosophy".ToUpper() + Common.newLine + Common.newLine;
			aboutText += "\tOur logo reflects our philosophy, which is to: "+ Common.newLine + Common.newLine;
			aboutText += "\t\t1.\tBrighten up the knowledge, creativity and skills of young managers." + Common.newLine + Common.newLine;
			aboutText += "\t\t2.\tContinuously stimulate the minds of managers who participate in the courses as only stimulated minds sustain their capacity for productive output." + Common.newLine + Common.newLine;
			aboutText += "Gains to Organizations".ToUpper() + Common.newLine + Common.newLine;
			aboutText += "\tOur courses help organizations to: "+ Common.newLine + Common.newLine;
			aboutText += "\t\t1.\tDiscover successful ways to improve business performance" +Common.newLine + Common.newLine;
			aboutText += "\t\t2.\tGain sustainable competitive edge by developing skills, creativity and commitment of employees" +Common.newLine + Common.newLine;
			aboutText += "\t\t3.\tKnow how to put best practices into action" +Common.newLine + Common.newLine;
			aboutText += "\t\t4.\tProfit from the changing business environment" + Common.newLine + Common.newLine;
			aboutText += "Gains to Employees".ToUpper() + Common.newLine + Common.newLine;
			aboutText += "\tEmployees who go through our courses do gain: "+ Common.newLine + Common.newLine;
			aboutText += "\t\t1.\tBenefits from the practical experience of the professionals who lead our courses" +Common.newLine + Common.newLine;
			aboutText += "\t\t2.\tEnhanced personal skills" +Common.newLine + Common.newLine;
			aboutText += "\t\t3.\tA sense of achievement" +Common.newLine + Common.newLine;
			aboutText += "\t\t4.\tRenewed professional ambition" + Common.newLine + Common.newLine;
			aboutText += "\t\t5.\tIncreased job satisfaction" + Common.newLine + Common.newLine;
			aboutText += "Accreditations".ToUpper() + Common.newLine + Common.newLine;
			aboutText += "\tTom Associates is accredited by: "+ Common.newLine + Common.newLine;
			aboutText += "\t\t1.\tCentre for Management Development (CMD)" +Common.newLine + Common.newLine;
			aboutText += "\t\t2.\tIndustrial Training Fund (ITF)" +Common.newLine + Common.newLine;
			aboutText += "\t\t3.\tNigerian Institute of Training and Development" +Common.newLine + Common.newLine;
			aboutText += "\t\t4.\tDirectorate for Petroleum Resources" + Common.newLine + Common.newLine + Common.newLine;
			aboutText += "For more information, please visit: www.tomassociatesng.com" + Common.newLine + Common.newLine;
			myTextView.Text = aboutText;
		}
	}
}
