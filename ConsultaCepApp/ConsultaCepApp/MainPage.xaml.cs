using ConsultaCepApp.Service;
using ConsultaCepApp.Service.Model;
using ConsultaCepApp.Utils.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

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

            if (CEPValidator.Validate(cep)) {
                try {
                    Endereco end = ViaCepService.SearchEndereco(cep);
                    if(end != null) {
                        Result.Text = end.Print();
                    } else {
                        DisplayAlert("Falha",
                        "Endereço não encontrado!",
                        "OK");
                    }
                } catch (Exception ex) {
                    System.Console.WriteLine("MainTela: "+ex.Message);
                    DisplayAlert("Serviço indisponível",
                        "O serviço parece estar com um mal funcionamento.\nTente novamente mais tarde",
                        "OK");
                }
            } else {
                DisplayAlert("Falha na consulta!", "CEP inválido! O CEP é composto por 8 números.", "OK");
            }
            
        }

    }
}
