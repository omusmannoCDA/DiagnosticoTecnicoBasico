using DiagnostivoTecnicoBasico.Model.InformacionComercial;
using DiagnostivoTecnicoBasico.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS_DiagnosticoTecnicoBasico.Domain.Business
{
    public class ICLogic
    {
        public static RequestDTB BuildDTBRequest(ICResponse model, string idUnico, string idCliente, string idDomicilio)
        {
            try
            {
                List<ICProductDetail> icProductDetailList = model.subscriptions.subscription[0].products.product;
                List<RelatedProductTestReq> relatedProductTestReqList = new List<RelatedProductTestReq>();
                DateTime hHoraActual = DateTime.Now;
                string fecha = hHoraActual.ToString("yyyy-MM-dd") + hHoraActual.ToString("THH:mm:ssK");

                foreach (ICProductDetail icProductDetail in icProductDetailList)
                {
                    if (icProductDetail.addressId.ToString() == idDomicilio && icProductDetail.productType != "FLOW APP")
                    {
                        List<ICComponentDetail> icComponentDetails = icProductDetail.components.component;
                        List<RealizingResourceTestReq> realizingResourceTestReqList = new List<RealizingResourceTestReq>();
                        string servicio = icProductDetail.productType;

                        foreach (ICComponentDetail icComponentDetail in icComponentDetails)
                        {
                            if (icComponentDetail.componentType == "Equipo")
                            {
                                string nroLinea = "";
                                if (servicio == "TELEFONÍA")
                                    nroLinea = icComponentDetail.serviceNumber;

                                List<CharacteristicReq> characteristicReqList = new List<CharacteristicReq>()
                            {
                               new CharacteristicReq(){ name = "Serial", value = icComponentDetail.serviceNumber },
                               new CharacteristicReq(){ name = "NroLinea", value = nroLinea },
                               new CharacteristicReq(){ name = "TipoEquipo", value = icComponentDetail.classService },
                            };

                                RealizingResourceTestReq realizingResourceTest = new RealizingResourceTestReq()
                                {
                                    name = icComponentDetail.classService,
                                    characteristic = characteristicReqList
                                };

                                realizingResourceTestReqList.Add(realizingResourceTest);
                            }
                        }

                        ProductReq productReq = new ProductReq() { id = 1, name = "TELEFONÍA" };

                        RelatedProductTestReq relatedProductTestReq = new RelatedProductTestReq()
                        {
                            name = servicio,
                            product = productReq,
                            realizingResourceTest = realizingResourceTestReqList
                        };

                        relatedProductTestReqList.Add(relatedProductTestReq);
                    }
                }

                RequestDTB requestDTB = new RequestDTB()
                {
                    name = idUnico,
                    testSpecification = new TestSpecificationReq() { id = "1", name = "DTB", version = "V1" },
                    customer = new CustomerReq() { id = idCliente },
                    place = new PlaceReq() { id = idDomicilio },
                    mode = "ONDEMAND",
                    startDateTime = DateTime.Now.ToString("o"),
                    characteristic = new List<CharacteristicReq>() { new CharacteristicReq() { name = "username", value = "user" }, new CharacteristicReq() { name = "application", value = "app" } },
                    relatedProductTest = relatedProductTestReqList
                };

                return requestDTB;
            }
            catch (Exception e)
            {
                throw new Exception("Error 2");
            }
        }

        public static RequestDTB BuildDTBRequestMock(string model, string idUnico, string idCliente, string idDomicilio)
        {
            return new RequestDTB()
            {
                name = "2020050716102370722801",
                testSpecification = new TestSpecificationReq()
                {
                    id = "DTB",
                    name = "DIAGNOSTICO TECNICO BASICO",
                    version = "V1"
                },
                customer = new CustomerReq()
                {
                    id = "1789977"
                },
                place = new PlaceReq()
                {
                    id = "33228538"
                },
                startDateTime = "2020-05-07T16:13:25.9177456-03:00",
                characteristic = new List<CharacteristicReq>()
                {
                    new CharacteristicReq()
                    {
                        name = "username",
                        value = "user"
                    },
                    new CharacteristicReq()
                    {
                        name = "application",
                        value = "app"
                    }
                },
                relatedProductTest = new List<RelatedProductTestReq>()
                {
                    new RelatedProductTestReq()
                    {
                        name = "INTERNET CABLEMODEM",
                        product = new ProductReq()
                        {
                            id = 1,
                            name = "TELEFONÍA"
                        },
                        realizingResourceTest = new List<RealizingResourceTestReq>()
                        {
                            new RealizingResourceTestReq()
                            {
                                name = "eMTA ToIP",
                                characteristic = new List<CharacteristicReq>()
                                {
                                    new CharacteristicReq()
                                    {
                                        name = "Serial",
                                        value = "D8A756F10868"
                                    },
                                    new CharacteristicReq()
                                    {
                                        name = "NroLinea",
                                        value = ""
                                    },
                                    new CharacteristicReq()
                                    {
                                        name = "numeroAbonado",
                                        value = "3874968171"
                                    },
                                    new CharacteristicReq()
                                    {
                                        name = "TipoEquipo",
                                        value = "eMTA ToIP"
                                    }
                                }
                            }
                        }
                    },
                }
            };
        }
    }
}
