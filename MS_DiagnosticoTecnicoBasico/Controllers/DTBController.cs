using System;
using System.Net;
using DiagnostivoTecnicoBasico.Model.ResponseAPI;
using Microsoft.AspNetCore.Mvc;
using MS_DiagnosticoTecnicoBasico.Domain.Common;
using MS_DiagnosticoTecnicoBasico.Services;

namespace MS_DiagnosticoTecnicoBasico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DTBController : ControllerBase
    {
        [HttpGet]
        public ActionResult<GenericResponse<Response>> GetDTBCompleto(string idSubscriber, string idDomicilio)
        {
            GenericResponse<Response> genericResponse = new GenericResponse<Response>();
            try
            {
                Response responseApiList = DTB_Services.GetCustometSiteProductTest(idSubscriber, idDomicilio);
                genericResponse.StatusCode = (int)HttpStatusCode.OK;
                genericResponse.ResponseData = responseApiList;
                genericResponse.CustomMessage = "Proceso finalizado correctamente.";
            }
            catch (Exception e)
            {
                genericResponse.StatusCode = (int)HttpStatusCode.InternalServerError;
                genericResponse.CustomMessage = CustomMessage.InternalServerError;
                genericResponse.ExceptionMessage = e.Message;

                Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }

            return genericResponse;
        }

        [HttpGet("/status")]
        public ActionResult GetStatus()
        {
            return Ok("OK");
        }
    }
}