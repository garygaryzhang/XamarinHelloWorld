using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private ObservableCollection<Contact> _contacts;
        public CellListPage()
        {
            InitializeComponent();

            _contacts = new ObservableCollection<Contact>
            {
                new Contact { Name = "Gary", ImageUrl = "https://picsum.photos/id/237/200", Status = "YOLO"},
                new Contact { Name = "Kendal", ImageUrl = "https://picsum.photos/236/200", Status = "Hello World!"},
                new Contact { Name = "Ricca", ImageUrl = "https://picsum.photos/235/200", Status = "Meow World!"}
            };

            listView.ItemsSource = _contacts;
        }

        ObservableCollection<Contact> GetContacts()
        {
            return new ObservableCollection<Contact>
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

        void Delete_Clicked(Object sender, System.EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            _contacts.Remove(contact);
        }

        void Call_Clicked(Object sender, System.EventArgs e)
        {
            var MenuItem = sender as MenuItem;
            var contact = MenuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = GetContacts();

            listView.EndRefresh();
        }
    }
}