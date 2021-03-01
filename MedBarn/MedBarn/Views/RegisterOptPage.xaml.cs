using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MedBarn.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterOptPage : ContentPage
    {
        public RegisterOptPage()
        {
            InitializeComponent();
        }

        public async void ContBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(page: new DonorRegPage());
        }
    }
}