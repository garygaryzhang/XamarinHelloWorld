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
    public partial class StackExercisePage : ContentPage
    {
        public StackExercisePage()
        {
            InitializeComponent();
            //BackgroundColor = Color.FromHex("#127ac7");
            //login.BackgroundColor = Color.FromHex("#1dabf0");
            //register.BackgroundColor = Color.FromHex("#1dabf0");
        }
    }
}