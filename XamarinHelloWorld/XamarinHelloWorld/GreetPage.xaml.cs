using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinHelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

            //non-generic overload
            //[Obsolete]
            //Device.OnPlatform(
            //    iOS: () =>
            //    {
            //        Padding = new Thickness(0, 20, 0, 0);
            //},
            //    Android: () => {
            //        Padding = new Thickness(10, 20, 0, 0);
            //},
            //    WinPhone: () => {
            //        Padding = new Thickness(30, 20, 0, 0);
            //});

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    this.Padding = new Thickness(0, 20, 0, 0);
                    break;
                case Device.Android:
                    this.Padding = new Thickness(10, 20, 0, 0);
                    break;
                case Device.UWP:
                    this.Padding = new Thickness(20, 20, 0, 0);
                    break;
                case Device.macOS:
                    this.Padding = new Thickness(30, 20, 0, 0);
                    break;
            }
        }
    }
}