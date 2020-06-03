using System;
using System.IO;
using System.Net;
using System.Net.Http;

namespace MS_DiagnosticoTecnicoBasico.Domain.Common
{
    public class Utilities
    {
        private static int seed = Environment.TickCount;
        private static Random r = new Random(seed);

        public static string GenerarIdUnicoDiagnostico()
        {
            string idUnico = DateTime.Now.Year.ToString() +
                             DateTime.Now.Month.ToString().PadLeft(2, '0') +
                             DateTime.Now.Day.ToString().PadLeft(2, '0') +
                             DateTime.Now.Hour.ToString().PadLeft(2, '0') +
                             DateTime.Now.Minute.ToString().PadLeft(2, '0') +
                             DateTime.Now.Second.ToString().PadLeft(2, '0') +
                             r.Next(0001, 9999).ToString().PadLeft(4, '0') +
                             r.Next(0001, 9999).ToString().PadLeft(4, '0');

            return idUnico;
        }

        public static string GetResponse(string url)
        {
            try
            {
                HttpClient client = new HttpClient();

                ServicePointManager.ServerCertificateValidationCallback += (se, cert, chain, sslerror) =>
                {
                    return true;
                };

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.Timeout = 60000;

                string result = "";

                using (WebResponse svcResponse = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(svcResponse.GetResponseStream()))
                    {
                        result = sr.ReadToEnd();
                    }
                }
                return result;
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    string errorJson = new System.IO.StreamReader(e.Response.GetResponseStream()).ReadToEnd();

                    return errorJson;
                }
                else
                {
                    throw e;
                }
            }
        }
    }
}
