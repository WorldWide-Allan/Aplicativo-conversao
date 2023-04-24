using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Convertendo
{
    public partial class MainPage : ContentPage
    {
        Double metro, quilometros, jardas, poleg;

        private void btt_calcular_Clicked(object sender, EventArgs e)
        {
            metro = Convert.ToDouble(ent_metro.Text);
            quilometros = metro / 1000;
            lbl_km.Text = "Quilomêtros: " + quilometros;
            jardas = metro * 1.094;
            lbl_jardas.Text = "Jardas: " + jardas;
            poleg = metro * 39.37;
            lbl_poleg.Text = "Polegadas: " + poleg;
        }

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void btt_limpar_Clicked(object sender, EventArgs e)
        {
            ent_metro.Text = "";
            lbl_km.Text = "Quilomêtros: ";
            lbl_jardas.Text = "Jardas: ";
            lbl_poleg.Text = "Polegadas: ";
        }
    }
}
