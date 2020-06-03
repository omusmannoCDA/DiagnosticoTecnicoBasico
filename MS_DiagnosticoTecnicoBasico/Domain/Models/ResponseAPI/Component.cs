using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.ResponseAPI
{
    public class Component
    {
        public string code { get; set; }
        public string codeStatus { get; set; }
        public string label { get; set; }
        public string name { get; set; }
        public List<Detail> details { get; set; }
        public List<WorkFlow> workFlows { get; set; }
    }
}
