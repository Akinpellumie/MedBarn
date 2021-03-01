using System;
using Android.Content;
using Android.Views;
using MedBarn.Controls;
using MedBarn.Droid.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;


[assembly: ExportRenderer(typeof(OTPCustomEntry), typeof(OTPCustomEntryRenderer))]
namespace MedBarn.Droid.Controls
{
    [Obsolete]
    public class OTPCustomEntryRenderer : EntryRenderer
    {
        public OTPCustomEntryRenderer(Context context) : base(context)
        {
        }

        public override bool DispatchKeyEvent(KeyEvent e)
        {
            if (e.Action == KeyEventActions.Down)
            {
                if (e.KeyCode == Keycode.Del)
                {
                    if (string.IsNullOrWhiteSpace(Control.Text))
                    {
                        var entry = (OTPCustomEntry)Element;
                        entry.OnBackspacePressed();
                    }
                }
            }
            return base.DispatchKeyEvent(e);
        }

        protected override void
        OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
        }

    }
}