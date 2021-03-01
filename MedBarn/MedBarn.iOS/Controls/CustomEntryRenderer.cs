using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using MedBarn;
using MedBarn.iOS;
using MedBarn.Controls;
using System.ComponentModel;
using MedBarn.iOS.Controls;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace MedBarn.iOS.Controls
{
    public class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Control.Layer.BorderWidth = 0;
            Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}