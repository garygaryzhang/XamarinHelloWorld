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
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            //var imageSource = new UriImageSource { Uri = new Uri("https://www.1800flowers.com/blog/wp-content/uploads/2017/07/cactus-succulent-dish-garden.jpg") };
            //imageSource.CachingEnabled = false;
            //image.Source = imageSource;

            image.Source = ImageSource.FromResource("XamarinHelloWorld.Images.succulent2.jpg");
        }
    }
}