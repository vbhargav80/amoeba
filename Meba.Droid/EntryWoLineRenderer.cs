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
using Meba;
using Meba.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(EntryWoLineRenderer))]

namespace Meba.Droid
{
    public class EntryWoLineRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null) return;

            if (e.NewElement.BackgroundColor == Color.Transparent)
            {
                Control?.SetPadding(0, 0, 0, 0);
                Control?.SetBackgroundColor(Android.Graphics.Color.Transparent);
            }
        }
    }
}