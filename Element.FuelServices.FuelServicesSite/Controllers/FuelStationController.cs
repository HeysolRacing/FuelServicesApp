using Element.FuelServices.Domain.Maintenance;
using Element.FuelServices.Shared.Common;
using Element.FuelServices.Shared.Dto;
using Element.FuelServices.Shared.Resources;
using Element.FuelServices.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Web.Http;

namespace Element.FuelServices.FuelServicesSite.Controllers
{
    public class FuelStationController : ApiController
    {
        public string GetCityStateSortedResults(int? supplierId, string userTicket, string city, string state, string product)
        {
            CityStateReference.Response response;

            if (string.IsNullOrEmpty(userTicket) && (!string.IsNullOrEmpty(city) || !string.IsNullOrEmpty(state)) || supplierId == null)
            {
                response = new CityStateReference.Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new CityStateReference.StatusResponse
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
                response = new CityStateReference.Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new CityStateReference.StatusResponse
                    {
                        Status = 401,
                        Message = Default.LblHttpStatusCode401,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };

                return Serialize(response);
            }

            var client = new CityStateReference.CityStateClient();

            response = client.Get(new CityStateReference.CityStateRequest
            {
                SupplierId = supplierId.Value,
                City = city,
                State = state,
                SortedBy = (CityStateReference.EnumProduct)SourceProduct(string.IsNullOrEmpty(product) ? string.Empty : product),
                UserTicket = userTicket
            });

            return Serialize(response);
        }

        public string GetStationListResults(int? supplierId, string userTicket, string idStation)
        {
            StationListReference.Response response;

            if (string.IsNullOrEmpty(userTicket) || string.IsNullOrEmpty(idStation) || supplierId == null)
            {
                response = new StationListReference.Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new StationListReference.StatusResponse
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
                response = new StationListReference.Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new StationListReference.StatusResponse
                    {
                        Status = 401,
                        Message = Default.LblHttpStatusCode401,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };

                return Serialize(response);
            }

            var client = new StationListReference.StationListClient();

            response = client.Get(new StationListReference.StationListRequest
            {
                SupplierId = supplierId.Value,
                StationList = idStation,
                UserTicket = userTicket
            });

            return Serialize(response);
        }

        public string GetStationListSortedResults(int? supplierId, string userTicket, string idStation, string product)
        {
            StationListReference.Response response;

            if (string.IsNullOrEmpty(userTicket) || string.IsNullOrEmpty(idStation) || supplierId == null)
            {
                response = new StationListReference.Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new StationListReference.StatusResponse
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
                response = new StationListReference.Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new StationListReference.StatusResponse
                    {
                        Status = 401,
                        Message = Default.LblHttpStatusCode401,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };

                return Serialize(response);
            }

            var client = new StationListReference.StationListClient();

            response = client.Get(new StationListReference.StationListRequest
            {
                SupplierId = supplierId.Value,
                StationList = idStation,
                SortedBy = (StationListReference.EnumProduct)SourceProduct(string.IsNullOrEmpty(product) ? string.Empty : product),
                UserTicket = userTicket
            });

            return Serialize(response);
        }

        public string GetZipCodeResults(int? supplierId, string userTicket, string zipCode)
        {
            ZipCodeReference.Response response;

            if (string.IsNullOrEmpty(userTicket) || string.IsNullOrEmpty(zipCode) || supplierId == null)
            {
                response = new ZipCodeReference.Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new ZipCodeReference.StatusResponse
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
                response = new ZipCodeReference.Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new ZipCodeReference.StatusResponse
                    {
                        Status = 401,
                        Message = Default.LblHttpStatusCode401,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };

                return Serialize(response);
            }

            var client = new ZipCodeReference.ZipCodeClient();

            response = client.Get(new ZipCodeReference.ZipCodeRequest
            {
                SupplierId = supplierId.Value,
                ZipCode = zipCode,
                UserTicket = userTicket
            });

            return Serialize(response);
        }

        public string GetZipCodeSortedResults(int? supplierId, string userTicket, string zipCode, string product)
        {
            ZipCodeReference.Response response;

            if (string.IsNullOrEmpty(userTicket) || string.IsNullOrEmpty(zipCode) || supplierId == null)
            {
                response = new ZipCodeReference.Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new ZipCodeReference.StatusResponse
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
                response = new ZipCodeReference.Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new ZipCodeReference.StatusResponse
                    {
                        Status = 401,
                        Message = Default.LblHttpStatusCode401,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };

                return Serialize(response);
            }

            var client = new ZipCodeReference.ZipCodeClient();

            response = client.Get(new ZipCodeReference.ZipCodeRequest
            {
                SupplierId = supplierId.Value,
                ZipCode = zipCode,
                UserTicket = userTicket,
                SortedBy = (ZipCodeReference.EnumProduct)SourceProduct(string.IsNullOrEmpty(product) ? string.Empty : product)
            });

            return Serialize(response);
        }

        public string GetLatLongSortedWithDistanceResults(decimal? lattitude, decimal? longitude, string fuelType, decimal? distance)
        {
            LattitudeLongitudeReference.Response response;

            decimal lattitudeValue = 0;
            decimal longitudeValue = 0;
            decimal distanceValue = 0;

            if (!lattitude.HasValue || 
                !longitude.HasValue || 
                string.IsNullOrEmpty(fuelType) || 
                !distance.HasValue || 
                !decimal.TryParse(lattitude.Value.ToString(), out lattitudeValue) ||
                !decimal.TryParse(longitude.Value.ToString(), out longitudeValue) ||
                !decimal.TryParse(distance.Value.ToString(), out distanceValue))
            {
                response = new LattitudeLongitudeReference.Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new LattitudeLongitudeReference.StatusResponse
                    {
                        Status = 400,
                        Message = Default.LblHttpStatusCode400,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };

                return Serialize(response);
            }

            var userName = string.Empty;
            if (!Validate())
            {
                response = new LattitudeLongitudeReference.Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new LattitudeLongitudeReference.StatusResponse
                    {
                        Status = 401,
                        Message = Default.LblHttpStatusCode401,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };

                return Serialize(response);
            }

            var client = new LattitudeLongitudeReference.LattitudeLongitudeClient();

            response = client.Get(new LattitudeLongitudeReference.LatLongRequest
            {
                Lattitude = lattitudeValue,
                Longitude = longitudeValue,
                FuelType = fuelType,
                Distance = distanceValue
            });

            return Serialize(response);
        }

        private bool Validate()
        {
            try
            {
                var body = "grant_type=password";
                var requestBody = Encoding.UTF8.GetBytes(body);
                var url = ConfigurationManager.AppSettings["UrlApiServiceToken"];
                var request = (HttpWebRequest)WebRequest.Create(url);

                request.Method = "POST";
                request.ContentLength = requestBody.Length;
                request.ContentType = "application/x-www-form-urlencoded";

                using (var requestStream = request.GetRequestStream())
                {
                    requestStream.Write(requestBody, 0, requestBody.Length);
                }

                request.Timeout = 15000;
                request.CachePolicy = new RequestCachePolicy(RequestCacheLevel.BypassCache);

                string output = string.Empty;
                using (var response = request.GetResponse())
                {
                    using (var stream = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(1252)))
                    {
                        output = stream.ReadToEnd();
                    }
                }

                var token = JsonConvert.DeserializeObject<TokenEntity>(output);

                return token.access_token.Trim().Length > 0;
            }
            catch(Exception exception)
            {
                var innerException = exception.InnerException == null ? string.Empty : exception.InnerException.Message;
                var exceptionLog = new ExceptionLog
                {
                    ApplicationName = $"{ConfigurationManager.AppSettings["SolutionName"]} - {ConfigurationManager.AppSettings["UserFuelServices"]}",
                    Message = $"{exception.Message} {innerException}"
                };

                var exceptionRepository = new ExceptionLogBr("MetadataConnection");
                var exceptionId = exceptionRepository.Add(exceptionLog);

                return false;
            }
        }

        public string GetLatLongResults(string userTicket, decimal? lattitude, decimal? longitude)
        {
            ZipCodeReference.Response response;

            if (string.IsNullOrEmpty(userTicket) || !lattitude.HasValue || !longitude.HasValue)
            {
                response = new ZipCodeReference.Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new ZipCodeReference.StatusResponse
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
                response = new ZipCodeReference.Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new ZipCodeReference.StatusResponse
                    {
                        Status = 401,
                        Message = Default.LblHttpStatusCode401,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };

                return Serialize(response);
            }

            var zipCode = string.Empty;

            var client = new ZipCodeReference.ZipCodeClient();

            response = client.Get(new ZipCodeReference.ZipCodeRequest
            {
                ZipCode = zipCode,
                UserTicket = userTicket
            });

            return Serialize(response);
        }

        public string SearchStationList(string idStation)
        {
            return string.Empty;
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