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
    public partial class AirBnB : ContentPage
    {
        public AirBnB()
        {
            InitializeComponent();
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {

        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Delete_Clicked(object sender, EventArgs e)
        {

        }
    }
}