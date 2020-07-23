using ConsultaCepApp.Service;
using ConsultaCepApp.Service.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ConsultaCepApp {
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            SearchButton.Clicked += buscarCEP;
        }

        private void buscarCEP(object sender, EventArgs args) {
            string cep = CEP.Text.Trim();
            Endereco end = ViaCepService.SearchEndereco(cep);
            Result.Text = end.Print();
        }

    }
}
