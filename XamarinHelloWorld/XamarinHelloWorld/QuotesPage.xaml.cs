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
    public partial class QuotesPage : ContentPage
    {
        int i = 0;
        List<string> quotes = new List<string> {("Life is like riding a bicyle. To keep your balance, you must keep moving."),
                                                ("You can't blame gravity for falling in love."),
                                                ("Look deep into nature, and then you will understand everything better.")};

        public QuotesPage()
        {
            InitializeComponent();
            i = 0;
            quote.Text = quotes[i];
            slider.Value = 25;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (i == 2)
            {
                i = 0;
            }
            else
            {
                i += 1;
            }
            quote.Text = quotes[i];
        }
    }
}