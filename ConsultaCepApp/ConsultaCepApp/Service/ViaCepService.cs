using ConsultaCepApp.Service.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace ConsultaCepApp.Service {
    public class ViaCepService {

        private static string URL = "https://viacep.com.br/ws/{0}/json/";

        public static Endereco SearchEndereco(string cep) {
            string NewURL = string.Format(URL, cep);
            WebClient webClient = new WebClient();
            string Content = webClient.DownloadString(NewURL);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(Content);
            
            if (end.cep == null)
                return null;

            return end;
        }

    }
}
