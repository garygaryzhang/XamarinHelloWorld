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

            listView.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup("G","G") {
                    new Contact { Name = "Gary", ImageUrl = "https://picsum.photos/id/237/200", Status = "YOLO"}
                },
                new ContactGroup("K","K") {
                    new Contact { Name = "Kendal", ImageUrl = "https://picsum.photos/236/200", Status = "Hello World!"}
                },
                new ContactGroup("R","R") {
                    new Contact { Name = "Ricca", ImageUrl = "https://picsum.photos/235/200", Status = "Meow World!"}
                }
            };

        }
    }
}