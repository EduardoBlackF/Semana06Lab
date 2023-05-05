using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            List<Person> people = new List<Person>();

            people.Add(new Person { Name = "Hugo", LastName = "Torrico", DNI = "73804157" });
            people.Add(new Person { Name = "Juan", LastName = "Torrico", DNI = "73804156" });
            people.Add(new Person { Name = "Janeth", LastName = "Marquez", DNI = "73804155" });
            people.Add(new Person { Name = "Yury", LastName = "Marquez", DNI = "73804154" });


            this.lvPeople.ItemsSource = people;
        }
    }
}