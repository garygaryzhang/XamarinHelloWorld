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
    public partial class ImageSlideShowPage : ContentPage
    {
        int i = 0;
        public ImageSlideShowPage()
        {
            InitializeComponent();

            image.Source = ImageSource.FromResource($"XamarinHelloWorld.Images.cityview{i}.jpg");
        }

        private void btnleft_Clicked(object sender, EventArgs e)
        {
            if (i == 0)
            {
                i = 4;
            }
            else
            {
                i--;
            }
            image.Source = ImageSource.FromResource($"XamarinHelloWorld.Images.cityview{i}.jpg");
        }

        private void btnright_Clicked(object sender, EventArgs e)
        {
            if (i == 4)
            {
                i = 0;
            }
            else
            {
                i++;
            }
            image.Source = ImageSource.FromResource($"XamarinHelloWorld.Images.cityview{i}.jpg");
        }
    }
}