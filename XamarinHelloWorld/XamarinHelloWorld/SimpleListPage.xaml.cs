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
    public partial class SimpleListPage : ContentPage
    {
        public SimpleListPage()
        {
            InitializeComponent();

            var fruits = new List<string>
            {
                "banana",
                "apple",
                "pear"
            };

            listView.ItemsSource = fruits;
        }
    }
}