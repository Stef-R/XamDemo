//using System;
//using System.Collections.Generic;
using System.Linq;
//using System.Text;

//using Android.App;

using Android.Content;
using Android.Telephony;

//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;

using Xamarin.Forms;
using Uri = Android.Net.Uri;

using TutorQuickXAML.Droid;

[assembly: Dependency(typeof(PhoneDialer))]
namespace TutorQuickXAML.Droid
{
    class PhoneDialer:IDialer
    {
        public bool Dial(string number)
        {
            var context = Forms.Context;
            if (context == null)
                return false;

            var intent = new Intent(Intent.ActionCall);
            intent.SetData(Uri.Parse("tel:" + number));

            if (IsIntentAvailable())
            {
                context.StartActivity(intent);
                return true;
            }

            return false;
        }
        public static bool IsIntentAvailable()
        {
            return false;
        }
    }
}