using MedBarn.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MedBarn.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}