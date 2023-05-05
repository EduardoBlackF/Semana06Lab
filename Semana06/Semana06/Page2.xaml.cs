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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            List<Estudiante> estudiante = new List<Estudiante>();

            estudiante.Add(new Estudiante { Name = "Hugo", Nota = 12 });
            estudiante.Add(new Estudiante { Name = "Black", Nota = 18 });
            estudiante.Add(new Estudiante { Name = "Eduardo", Nota = 20 });

            foreach (var item  in estudiante)
            {
                item.Color= Color.Red;
                if (item.Nota > 14)
                    item.Color= Color.Blue;
            }

            lvEstudiantes.ItemsSource = estudiante;
        }
    }
}

