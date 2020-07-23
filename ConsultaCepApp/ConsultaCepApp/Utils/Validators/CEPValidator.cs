using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsultaCepApp.Utils.Validators {
    class CEPValidator {
        public static bool Validate(string cep) {
            bool lengthTest = cep.Length == 8;
            bool numberOnlyTest = int.TryParse(cep, out int n); // out - usado para passar a variavel como referencia
            return lengthTest && numberOnlyTest;
        }
    }
}
