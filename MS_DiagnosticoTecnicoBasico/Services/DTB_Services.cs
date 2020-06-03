using DiagnostivoTecnicoBasico.Model.InformacionComercial;
using DiagnostivoTecnicoBasico.Model.Request;
using DiagnostivoTecnicoBasico.Model.Response;
using DiagnostivoTecnicoBasico.Model.ResponseAPI;
using MS_DiagnosticoTecnicoBasico.Domain.Business;
using MS_DiagnosticoTecnicoBasico.Domain.Common;
using MS_DiagnosticoTecnicoBasico.Domain.Constants;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;

namespace MS_DiagnosticoTecnicoBasico.Services
{
    public class DTB_Services
    {
        public static Response GetCustometSiteProductTest(string idSubscriber, string idDomicilio)
        {
            Response response = new Response();
            string idUnico = Utilities.GenerarIdUnicoDiagnostico();
            try
            {
                ICResponse consultaComercial = GetConsultaComercial(idSubscriber);

                RequestDTB requestDTB = ICLogic.BuildDTBRequest(consultaComercial, idUnico, idSubscriber, idDomicilio);

                ResponseDTB responseDtb = GetCustomerSiteProductTest(requestDTB, idUnico);

                if (responseDtb != null)
                    response = Constants.MapResponseDataMock();

            }
            catch (Exception e)
            {
                throw e;
            }

            return response;
        }

        public static ResponseDTB GetCustomerSiteProductTest(RequestDTB requestDTB, string idUnico)
        {
            IRestResponse<ResponseDTB> response = null;
            string body = JsonConvert.SerializeObject(requestDTB);
            try
            {
                RestClient client = new RestClient("https://6a57b8dc-fa5f-4581-9591-971cb6c6985b.mock.pstmn.io/tmf-api/customerSiteProductsTestManagement/v1/customerSiteProductsTest?");
                client.Authenticator = new HttpBasicAuthenticator("user", "user");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("X-Requesting-Username", "user");
                request.AddHeader("X-Requesting-Application", "app");
                request.AddHeader("X-Requesting-ProcessId", idUnico);
                request.AddHeader("X-Requesting-Async", "false");
                request.AddHeader("Content-Type", "application/json;charset=utf-8");
                request.AddHeader("Authorization", "Basic YWRtaW46YWRtaW4=");
                request.AddParameter("application/json;charset=utf-8", body, ParameterType.RequestBody);
                request.RequestFormat = DataFormat.Json;
                response = client.Execute<ResponseDTB>(request);
            }
            catch (Exception e)
            {
                throw new Exception("Error 3");
            }

            return response.Data;
        }

        public static ICResponse GetConsultaComercial(string idSubscriber)
        {
            try
            {
                string url = Constants.urlInfomracionComercial + idSubscriber;
                var jsonResponse = Utilities.GetResponse(url);
                ICResponse dTBRequestEntity = JsonConvert.DeserializeObject<ICResponse>(jsonResponse);

                if (dTBRequestEntity.subscriptions == null)
                    throw new Exception(CustomMessage.OpenError);

                return dTBRequestEntity;
            }
            catch (Exception ex)
            {
                throw new Exception("Error 1");
            }
        }
    }
}
