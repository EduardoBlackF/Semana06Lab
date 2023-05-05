using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana06
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<string> names = new List<string>();
            names.Add("Hugo");
            names.Add("Eduardo");
            names.Add("Black");
            names.Add("Ferruzo");

            lvNames.ItemsSource = names;

        }
    }
}
