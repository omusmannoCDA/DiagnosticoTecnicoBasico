using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.ResponseAPI
{
    public class Client
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public int addressId { get; set; }
        public string telephone { get; set; }
        public string mail { get; set; }
        public List<Address> addresses { get; set; }
    }
}
