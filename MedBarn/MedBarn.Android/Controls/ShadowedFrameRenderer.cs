using Android.Graphics;
using AndroidX.Core.View;
using MedBarn.Controls;
using MedBarn.Droid.Controls;
using Xamarin.Forms;
using FrameRenderer = Xamarin.Forms.Platform.Android.AppCompat.FrameRenderer;

[assembly: ExportRenderer(typeof(ShadowedFrame), typeof(ShadowedFrameRenderer))]

namespace MedBarn.Droid.Controls
{
    [System.Obsolete]
    public class ShadowedFrameRenderer : FrameRenderer
    {
        public override void Draw(Canvas canvas)
        {
            base.Draw(canvas);
            UpdateShadow();
        }

        private void UpdateShadow()
        {
            // we need to reset the StateListAnimator to override the setting of Elevation on touch down and release.
            Control.StateListAnimator = new Android.Animation.StateListAnimator();

            // set the elevation manually
            ViewCompat.SetElevation(this, 4.0f);
            ViewCompat.SetElevation(Control, 4.0f);
        }
    }
}