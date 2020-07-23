using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultaCepApp.Service.Model {
    public class Endereco {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string unidade { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }

        public string Print() {
            return string.Format("{0}, {1} - {2}", logradouro, localidade, uf);
        }

    }
}
