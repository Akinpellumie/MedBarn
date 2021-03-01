using MedBarn.Controls;
using Xamarin.Forms;
using MedBarn.iOS.Controls;
using Xamarin.Forms.Platform.iOS;
using System.Runtime.Remoting.Contexts;

[assembly: ExportRenderer(typeof(CustomSearchBar), typeof(CustomSearchRenderer))]
namespace MedBarn.iOS.Controls
{
    public class CustomSearchRenderer : SearchBarRenderer
    {
        public CustomSearchRenderer(Context context)
        {
            AutoPackage = false;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.RemoveBackgroundLayer();
            }
        }
    }
}