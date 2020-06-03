using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.InformacionComercial
{
    public class ICProductDetail
    {
        public string productId { get; set; }
        public int productTypeId { get; set; }
        public string productType { get; set; }
        public int productStatusId { get; set; }
        public string productStatus { get; set; }
        public DateTime creationDate { get; set; }
        public int commercialPlanId { get; set; }
        public string commercialPlan { get; set; }
        public int companyId { get; set; }
        public string company { get; set; }
        public int addressId { get; set; }
        public ICComponent components { get; set; }
        public string promotions { get; set; }
    }
}
