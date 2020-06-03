using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.ResponseAPI
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string label { get; set; }
        public string type { get; set; }
        public string code { get; set; }
        public string codeStatus { get; set; }
        public string descriptionCode { get; set; }
        public List<Component> components { get; set; }
    }
}
