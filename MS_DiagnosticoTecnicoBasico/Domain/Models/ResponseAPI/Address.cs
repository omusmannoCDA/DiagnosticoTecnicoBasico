using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.ResponseAPI
{
    public class Address
    {
        public string address { get; set; }
        public int addressId { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public bool selected { get; set; }
    }
}
