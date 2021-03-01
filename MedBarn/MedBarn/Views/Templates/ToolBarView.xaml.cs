using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MedBarn.Views.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToolBarView : ContentView
    {
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(
         nameof(Title),
         typeof(string),
         typeof(ToolBarView),
         string.Empty);
        
        public static readonly BindableProperty TitleColorProperty = BindableProperty.Create(
         nameof(TitleColor),
         typeof(Color),
         typeof(ToolBarView));
        public ToolBarView()
        {
            InitializeComponent();
        }

        void Back(System.Object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }
        public Color TitleColor
        {
            get => (Color)GetValue(TitleColorProperty);
            set => SetValue(TitleColorProperty, value);
        }


    }
}