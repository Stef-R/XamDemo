using System;
using System.Collections.Generic;
using System.Text;
using CustomRenderer;
using CustomRenderer.iOS;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer (typeof(MyEntry),typeof(MyEntryRenderer))]
namespace CustomRenderer.iOS
{
    class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever
                Control.BackgroundColor = UIKit.UIColor.FromRGB(204,153,255);
                Control.BorderStyle = UIKit.UITextBorderStyle.Line;
            }
        }
    }
}
