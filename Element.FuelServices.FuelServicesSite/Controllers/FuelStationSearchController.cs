using Element.FuelServices.Shared.Resources;
using Element.FuelServices.Utilities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Http;

namespace Element.FuelServices.FuelServicesSite.Controllers
{
    public class FuelStationSearchController : ApiController
    {
        public string GetSearchCityStateSimple(int? supplierId, string userTicket, string city, string state, string product)
        {
            SimpleSearchReference.Response response;

            if (string.IsNullOrEmpty(userTicket) && (!string.IsNullOrEmpty(city) || !string.IsNullOrEmpty(state)) || supplierId == null)
            {
                response = new SimpleSearchReference.Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new SimpleSearchReference.StatusResponse
                    {
                        Status = 400,
                        Message = Default.LblHttpStatusCode400,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };

                return Serialize(response);
            }

            if (userTicket.Trim().ToLower() != ConfigurationManager.AppSettings["Token"].Trim().ToLower())
            {
                response = new SimpleSearchReference.Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new SimpleSearchReference.StatusResponse
                    {
                        Status = 401,
                        Message = Default.LblHttpStatusCode401,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };

                return Serialize(response);
            }

            var client = new SimpleSearchReference.SimpleSearchClient();

            response = client.Get(new SimpleSearchReference.SimpleSearchRequest
            {
                SupplierId = supplierId.Value,
                City = city,
                State = state,
                SortedBy = (SimpleSearchReference.EnumProduct)SourceProduct(string.IsNullOrEmpty(product) ? string.Empty : product),
                UserTicket = userTicket
            });

            return Serialize(response);
        }

        public string GetSearchZipCodeSimple(int? supplierId, string userTicket, string zipCode, string productName, string sortedBy)
        {
            SimpleSearchReference.Response response;

            if (string.IsNullOrEmpty(userTicket) || string.IsNullOrEmpty(zipCode) || supplierId == null)
            {
                response = new SimpleSearchReference.Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new SimpleSearchReference.StatusResponse
                    {
                        Status = 400,
                        Message = Default.LblHttpStatusCode400,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };

                return Serialize(response);
            }

            if (userTicket.Trim().ToLower() != ConfigurationManager.AppSettings["Token"].Trim().ToLower())
            {
                response = new SimpleSearchReference.Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new SimpleSearchReference.StatusResponse
                    {
                        Status = 401,
                        Message = Default.LblHttpStatusCode401,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };

                return Serialize(response);
            }

            var client = new SimpleSearchReference.SimpleSearchClient();

            response = client.Get(new SimpleSearchReference.SimpleSearchRequest
            {
                SupplierId = supplierId.Value,
                ZipCode = zipCode,
                UserTicket = userTicket,
                ProductName = productName,
                SortedBy = (SimpleSearchReference.EnumProduct)SourceProduct(string.IsNullOrEmpty(sortedBy) ? string.Empty : sortedBy),
            });

            return Serialize(response);
        }

        private string Serialize(object response)
        {
            return JsonConvert.SerializeObject(response);
        }

        private int SourceProduct(string productName)
        {
            var sourceProduct = new Dictionary<string, int>
            {
                { "notspecified", 0 },
                { "diesel", 1 },
                { "magna", 2 },
                { "premium", 3 }
            };

            var id = 0;

            return sourceProduct.TryGetValue(productName.ToString().Trim().ToLower(), out id) ? id : 0;
        }
    }
}