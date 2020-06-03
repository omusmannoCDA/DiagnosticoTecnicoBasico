using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.ResponseAPI
{
    public class Response
    {
        public Client client { get; set; }
        public List<Product> products { get; set; }
    }
}
