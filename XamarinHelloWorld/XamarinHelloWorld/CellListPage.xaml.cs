using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinHelloWorld.Models;

namespace XamarinHelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CellListPage : ContentPage
    {
        public CellListPage()
        {
            InitializeComponent();

            listView.ItemsSource = new List<Contact>
            {
                    new Contact { Name = "Gary", ImageUrl = "https://picsum.photos/id/237/200", Status = "YOLO"},
                    new Contact { Name = "Kendal", ImageUrl = "https://picsum.photos/236/200", Status = "Hello World!"},
                    new Contact { Name = "Ricca", ImageUrl = "https://picsum.photos/235/200", Status = "Meow World!"}
            };
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected", contact.Name, "OK");
        }
    }
}