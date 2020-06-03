using DiagnostivoTecnicoBasico.Model.ResponseAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MS_DiagnosticoTecnicoBasico.Domain.Constants
{
    public static class Constants
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
        public static Response MapResponseDataMock()
        {
            return new Response()
            {
                client = new Client()
                {
                    id = 125412,
                    name = "Jose",
                    lastName = "Argento",
                    addressId = 41213,
                    telephone = "1598765432",
                    mail = "jose_argento@gmail.com",
                    addresses = new List<Address>()
                    {
                    new Address()
                    {
                        address = "Viamonte 2273",
                        addressId = 1232,
                        city = "Monte Grande",
                        state = "Buenos Aires",
                        selected = true
                    },
                    new Address()
                    {
                        address = "Rodriguez Peña 223",
                        addressId = 1233,
                        city = "Villa Adelina",
                        state = "Buenos Aires",
                        selected = false
                    }
                    }
                },
                products = new List<DiagnostivoTecnicoBasico.Model.ResponseAPI.Product>()
                {
                    new DiagnostivoTecnicoBasico.Model.ResponseAPI.Product()
                    {
                        id = 154360760,
                        name = "toip_free_calls",
                        label = "Fija",
                        type = "telefoniaFija",
                        code = "0",
                        codeStatus = "OK",
                        descriptionCode = "Sin problemas",
                        components = new List<Component>()
                        {
                            new Component()
                            {
                                code = "0",
                                codeStatus = "OK",
                                name = "toip_huawei_h_D7583_v3",
                                label = "(011) 4968-7200",
                                details = new List<Detail>()
                                {
                                    new Detail(){ label = "Línea", value = "11 4968-7200" },
                                    new Detail(){ label = "IMSI", value = "552152729" },
                                    new Detail(){ label = "Roaming", value = "No" }
                                },
                                workFlows = new List<WorkFlow>()
                                {
                                    new WorkFlow() {
                                        label = "Diagnóstico de Telefonía",
                                        name = "nombre_smp_1",
                                        link = "https://webgestionmoviltesting/Consultas_Modem_HDM.aspx?signed=true&legajo=wdi585714"
                                    },
                                }
                            }
                        }
                    },
                    new DiagnostivoTecnicoBasico.Model.ResponseAPI.Product()
                    {
                        id = 14213171,
                        name = "TV POR CABLE",
                        label = "TV POR CABLE",
                        type = "video",
                        code = "0",
                        codeStatus = "OK",
                        descriptionCode = "Sin problemas",
                        components = new List<Component>()
                        {
                            new Component()
                            {
                                code = "0",
                                codeStatus = "OK",
                                name = "tv_flow_hd_pack_plus",
                                label = "Flow",
                                details = new List<Detail>()
                                {
                                    new Detail(){ label = "MAC", value = "00:1d:e5:55:1e:0a" },
                                    new Detail(){ label = "Serial", value = "552152729" },
                                    new Detail(){ label = "Port", value = "u2/w2" },
                                    new Detail(){ label = "US", value = ""}
                                },
                                workFlows = new List<WorkFlow>()
                                {
                                    new WorkFlow() {
                                        label = "Administracion de Flow",
                                        name = "nombre_smp_1",
                                        link = "https://webgestionmoviltesting/Consultas_Modem_HDM.aspx?signed=true&legajo=wdi585714"
                                    },
                                }
                            },
                            new Component()
                            {
                                code = "0",
                                codeStatus = "OK",
                                name = "app_flow_hd_pack_plus",
                                label = "Flow App",
                                details = new List<Detail>()
                                {
                                    new Detail(){ label = "MAC", value = "00:1d:e5:55:1e:0a" },
                                    new Detail(){ label = "Serial", value = "552152729" },
                                    new Detail(){ label = "Port", value = "u2/w2" },
                                    new Detail(){ label = "US", value = ""}
                                },
                                workFlows = new List<WorkFlow>()
                                {
                                    new WorkFlow() {
                                        label = "Administracion de Flow App",
                                        name = "nombre_smp_1",
                                        link = "https://webgestionmoviltesting/Consultas_Modem_HDM.aspx?signed=true&legajo=wdi585714"
                                    },
                                }
                            }
                        }
                    },
                    new DiagnostivoTecnicoBasico.Model.ResponseAPI.Product()
                    {
                        id = 229106272,
                        name = "internet_adsl_10mbps",
                        label = "INTERNET",
                        type = "internet",
                        code = "0",
                        codeStatus = "OK",
                        descriptionCode = "Sin problemas",
                        components = new List<Component>()
                        {
                            new Component()
                            {
                                code = "0",
                                codeStatus = "OK",
                                label = "Sagem G372547",
                                name = "sagem_g_372547_v45",
                                details = new List<Detail>()
                                {
                                    new Detail(){ label = "MAC", value = "??:??:??:??:??" },
                                    new Detail(){ label = "Serial", value = "M61410IA2425" },
                                    new Detail(){ label = "Config", value = "config_xxxxxxx.cm" },
                                    new Detail(){ label = "Ver HW", value = "2"},
                                    new Detail(){ label = "CM Status", value = "Registered" },
                                    new Detail(){ label = "Port US", value = "3/3" },
                                },
                                workFlows = new List<WorkFlow>()
                                {
                                    new WorkFlow()
                                    {
                                        label = "Administración de Firmware",
                                        name = "nombre_smp_1",
                                        link = "https://webgestionmoviltesting/consulta_WF.aspx?signed=true&legajo=wdi585714&wf=HC-CPEWifiOptimize"
                                    },
                                    new WorkFlow()
                                    {
                                        label = "Flujo de Resolución de Problemas STBIP (automático)",
                                        name = "nombre_smp_2",
                                        link = "https://webgestionmoviltesting/consulta_WF.aspx?signed=true&legajo=wdi585714&wf=HC-CPEWifiOptimize"
                                    },
                                    new WorkFlow()
                                    {
                                        label = "Reinicio",
                                        name = "nombre_smp_3",
                                        link = "https://webgestionmoviltesting/consulta_WF.aspx?signed=true&legajo=wdi585714&wf=HC-CPEWifiOptimize"
                                    },
                                    new WorkFlow()
                                    {
                                        label = "Reinicio a valores de fábrica",
                                        name = "nombre_smp_4",
                                        link = "https://webgestionmoviltesting/consulta_WF.aspx?signed=true&legajo=wdi585714&wf=HC-CPEWifiOptimize"
                                    },
                                    new WorkFlow()
                                    {
                                        label = "Información General",
                                        name = "nombre_smp_5",
                                        link = "https://webgestionmoviltesting/consulta_WF.aspx?signed=true&legajo=wdi585714&wf=HC-CPEWifiOptimize"
                                    },
                                    new WorkFlow()
                                    {
                                        label = "STBIP_troubleshoooting",
                                        name = "nombre_smp_6",
                                        link = "https://webgestionmoviltesting/consulta_WF.aspx?signed=true&legajo=wdi585714&wf=STBIP_troubleshooting"
                                    },
                                    new WorkFlow()
                                    {
                                        label = "Test de Velocidad",
                                        name = "nombre_smp_7",
                                        link = "https://portaldiagnosticouat.telecom.com.ar/SpeedTest.html"
                                    }
                                }
                            },
                            new Component()
                            {
                                code = "0",
                                codeStatus = "OK",
                                label = "Huawei HG8245U",
                                name = "huawei_HG8245U",
                                details = new List<Detail>()
                                {
                                    new Detail(){ label = "MAC", value = "00:1d:d5:69:1e:08" },
                                    new Detail(){ label = "Serial", value = "434234434" },
                                    new Detail(){ label = "Config", value = "d11_2g3848v2.cm" },
                                    new Detail(){ label = "Ver HW", value = "2" },
                                    new Detail(){ label = "Estado CM", value = "Registrado" },
                                    new Detail(){ label = "Port US", value = "3/3" },
                                },
                                workFlows = new List<WorkFlow>()
                                {
                                    new WorkFlow()
                                    {
                                        label = "Administración de Huawei",
                                        name = "nombre_smp_1",
                                        link = "https://webgestionmoviltesting/consulta_WF.aspx?signed=true&legajo=wdi585714&wf=HC-CPEWifiOptimize"
                                    }
                                }
                            },
                            new Component()
                            {
                                code = "0",
                                codeStatus = "OK",
                                label = "WIFI",
                                name = "wifi",
                                workFlows = new List<WorkFlow>()
                                {
                                    new WorkFlow()
                                    {
                                        label = "Administración de WIFI",
                                        name = "nombre_smp_1",
                                        link = "https://webgestionmoviltesting/Consultas_Modem_HDM.aspx?signed=true&legajo=wdi585714"
                                    }
                                }
                            }
                        }
                    },
                    new DiagnostivoTecnicoBasico.Model.ResponseAPI.Product()
                    {
                        id = 154360760,
                        name = "movil_3g",
                        label = "Móvil",
                        type = "telefoniaMovil",
                        code = "0",
                        codeStatus = "OK",
                        descriptionCode = "Sin problemas",
                        components = new List<Component>()
                        {
                            new Component()
                            {
                                code = "0",
                                codeStatus = "OK",
                                name = "motorola_one_3857",
                                label = "(15) 6859-1445",
                                details = new List<Detail>()
                                {
                                    new Detail(){ label = "Línea", value = "011 5555-7200" },
                                    new Detail(){ label = "IMSI", value = "775664388859" },
                                },
                                workFlows = new List<WorkFlow>()
                                {
                                    new WorkFlow() {
                                        label = "Inconvenientes servicio de Datos",
                                        name = "nombre_smp_1",
                                        link = "https://webgestionmoviltesting/Signed_Request.aspx?signed_request=tGkQ3mrOvtEYhTFx26ylS0INCWQDgXw4qsTmo/5GmeM=.eyJucm9DYXNvU1QiOiIxMTY4NSIsIm51bWVyb0xpbmVhIjoiMTE2ODU5MTQ0NSIsImxlZ2FqbyI6IndkaTUwMDAwMCIsImNvZFNlcnZpY2lvIjoiZGF0b3MiLCJtb3Rpdm9Db250YWN0byI6IkluY29udmVuaWVudGVzIHNlcnZpY2lvIGRlIGRhdG9zIiwibHN0U1ZBIjpudWxsfQ=="
                                    },
                                    new WorkFlow() {
                                        label = "Inconvenientes servicio de Voz",
                                        name = "nombre_smp_2",
                                        link = "https://webgestionmoviltesting/Signed_Request.aspx?signed_request=eKJKSG6HFx4Hyzuu7kGC1QRp3bjvoZTy0I0frDpC0BM=.eyJucm9DYXNvU1QiOiIxMTY4NSIsIm51bWVyb0xpbmVhIjoiMTE2ODU5MTQ0NSIsImxlZ2FqbyI6IndkaTUwMDAwMCIsImNvZFNlcnZpY2lvIjoicm9hbWluZyIsIm1vdGl2b0NvbnRhY3RvIjoiSW5jb252ZW5pZW50ZXMgc2VydmljaW8gZGUgdm96IiwibHN0U1ZBIjpudWxsfQ=="
                                    },
                                    new WorkFlow() {
                                        label = "Inconvenientes servicio de Roaming",
                                        name = "nombre_smp_3",
                                        link = "https://webgestionmoviltesting/Signed_Request.aspx?signed_request=6bIN9ZjGMt3jMgIba2f5SkWlEccdArb/PGmK3zopGAk=.eyJucm9DYXNvU1QiOiIxMTY4NSIsIm51bWVyb0xpbmVhIjoiMTE2ODU5MTQ0NSIsImxlZ2FqbyI6IndkaTUwMDAwMCIsImNvZFNlcnZpY2lvIjoicm9hbWluZyIsIm1vdGl2b0NvbnRhY3RvIjoiSW5jb252ZW5pZW50ZXMgc2VydmljaW8gZGUgUm9hbWluZyIsImxzdFNWQSI6bnVsbH0="
                                    },
                                    new WorkFlow() {
                                        label = "Inconvenientes con SVA",
                                        name = "nombre_smp_4",
                                        link = "https://webgestionmoviltesting/Signed_Request.aspx?signed_request=ynlOyHDuLUxHNJI3lScM/ABOJ/pry8ZW51nNBh/vkhI=.eyJucm9DYXNvU1QiOiIxMTY4NSIsIm51bWVyb0xpbmVhIjoiMTE2ODU5MTQ0NSIsImxlZ2FqbyI6IndkaTUwMDAwMCIsImNvZFNlcnZpY2lvIjoic3ZhIiwibW90aXZvQ29udGFjdG8iOiJJbmNvbnZlbmllbnRlcyBjb24gU1ZBIiwibHN0U1ZBIjpudWxsfQ=="
                                    },
                                }
                            }
                        }
                    },
                }
            };
        }

        public static string urlConsulta = "http://apicore31-pdd-portaldiagnostico-dev.apps-rp.cloudteco.com.ar/swagger";
        public static string urlOpen = "http://esbp.corp.cablevision.com.ar:8000/customerManagement/";

        public static string urlInfomracionComercial = "https://localhost:44312/api/client/";


    }
}
