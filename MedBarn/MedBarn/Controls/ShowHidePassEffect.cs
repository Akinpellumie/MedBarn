using Xamarin.Forms;

namespace MedBarn.Controls
{
    public class ShowHidePassEffect : RoutingEffect
    {
        public string Entry { get; set; }
        public ShowHidePassEffect() : base("Xamarin.ShowHidePassEffect") { }
    }
}