using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedBarn.Controls;
using MedBarn.Droid;
using MedBarn.Droid.Controls;
using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomSearchBar), typeof(CustomSearchRenderer))]
namespace MedBarn.Droid.Controls
{
    public class CustomSearchRenderer : SearchBarRenderer
    {
        public CustomSearchRenderer(Context context) : base(context)
        {
            AutoPackage = false;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
            }
        }
    }
}