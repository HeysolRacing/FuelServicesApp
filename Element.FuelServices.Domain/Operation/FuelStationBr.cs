using Element.FuelServices.DataAccess.Repository.Maintenance;
using Element.FuelServices.DataAccess.Repository.Operation;
using Element.FuelServices.Shared.Common;
using Element.FuelServices.Shared.Dto;
using Element.FuelServices.Shared.Entities.Operation;
using Element.FuelServices.Shared.Resources;
using Element.FuelServices.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Element.FuelServices.Domain.Operation
{
    public class FuelStationBr
    {
        private readonly FuelStationRepository _repository;
        private readonly string _connectionName;
        private IList<FuelStation> _listResult;
        private Response _response;

        public FuelStationBr(string connectionName)
        {
            _connectionName = connectionName;
            _repository = new FuelStationRepository(_connectionName);
        }

        public Response GetAll()
        {
            try
            {
                _listResult = _repository.GetAll();

                _response = new Response
                {
                    IsSuccess = true,
                    //Obsolete = _listResult,
                    StatusResponse = new StatusResponse
                    {
                        Status = 200,
                        Message = Default.LblHttpStatusCode200
                    }
                };
            }
            catch (Exception exception)
            {
                var exceptionLog = new ExceptionLog
                {
                    ApplicationName = $"{ConfigurationManager.AppSettings["SolutionName"]} - {ConfigurationManager.AppSettings["UserFuelServices"]}",
                    Message = exception.Message
                };

                var exceptionRepository = new ExceptionLogRepository("MetadataConnection");
                var exceptionId = exceptionRepository.Add(exceptionLog);

                _response = new Response
                {
                    IsSuccess = false,
                    //Obsolete = null,
                    StatusResponse = new StatusResponse
                    {
                        Status = 500,
                        Message = Default.LblHttpStatusCode500
                    }
                };
            }

            return _response;
        }

        public Response GetCityState(CityStateRequest request)
        {
            try
            {
                _listResult = _repository.GetCityState(request);
                var numberItems = _listResult.Count;

                if (numberItems == 0)
                {
                    _response = new Response
                    {
                        IsSuccess = true,
                        NumberItems = numberItems,
                        //Obsolete = _listResult,
                        StatusResponse = new StatusResponse
                        {
                            Status = 404,
                            Message = Default.LblHttpStatusCode404,
                            Timestamp = DateTimeOperations.FormatTimeStamp()
                        }
                    };

                    return _response;
                }

                _response = new Response
                {
                    IsSuccess = true,
                    NumberItems = numberItems,
                    //Obsolete = request.SortedBy.HasValue ? Sorting.Sort(_listResult, request.SortedBy.Value) : _listResult,
                    StatusResponse = new StatusResponse
                    {
                        Status = 200,
                        Message = Default.LblHttpStatusCode200,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };
            }
            catch(Exception exception)
            {
                var exceptionLog = new ExceptionLog
                {
                    ApplicationName = $"{ConfigurationManager.AppSettings["SolutionName"]} - {ConfigurationManager.AppSettings["UserFuelServices"]}",
                    Message = exception.Message
                };

                var exceptionRepository = new ExceptionLogRepository("MetadataConnection");
                var exceptionId = exceptionRepository.Add(exceptionLog);

                _response = new Response
                {
                    IsSuccess = false,
                    //Obsolete = null,
                    StatusResponse = new StatusResponse
                    {
                        Status = 500,
                        Message = Default.LblHttpStatusCode500,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };
            }

            return _response;
        }

        public Response GetZipCode(ZipCodeRequest request)
        {
            try
            {
                _listResult =_repository.GetZipCode(request);
                var numberItems = _listResult.Count;

                if (numberItems == 0)
                {
                    _response = new Response
                    {
                        IsSuccess = true,
                        //Obsolete = _listResult,
                        NumberItems = numberItems,
                        StatusResponse = new StatusResponse
                        {
                            Status = 404,
                            Message = Default.LblHttpStatusCode404,
                            Timestamp = DateTimeOperations.FormatTimeStamp()
                        }
                    };

                    return _response;
                }

                _response = new Response
                {
                    IsSuccess = true,
                    NumberItems = numberItems,
                    //Obsolete = request.SortedBy.HasValue ? Sorting.Sort(_listResult, request.SortedBy.Value) : _listResult,
                    StatusResponse = new StatusResponse
                    {
                        Status = 200,
                        Message = Default.LblHttpStatusCode200,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };
            }
            catch (Exception exception)
            {
                var exceptionLog = new ExceptionLog
                {
                    ApplicationName = $"{ConfigurationManager.AppSettings["SolutionName"]} - {ConfigurationManager.AppSettings["UserFuelServices"]}",
                    Message = exception.Message
                };

                var exceptionRepository = new ExceptionLogRepository("MetadataConnection");
                var exceptionId = exceptionRepository.Add(exceptionLog);

                _response = new Response
                {
                    IsSuccess = false,
                    //Obsolete = null,
                    StatusResponse = new StatusResponse
                    {
                        Status = 500,
                        Message = Default.LblHttpStatusCode500,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };
            }

            return _response;
        }

        public Response GetStation(StationListRequest request)
        {
            try
            {
                _listResult = _repository.GetStation(request);
                var numberItems = _listResult.Count;

                if (numberItems == 0)
                {
                    _response = new Response
                    {
                        IsSuccess = true,
                        NumberItems = numberItems,
                        //Obsolete = _listResult,
                        StatusResponse = new StatusResponse
                        {
                            Status = 404,
                            Message = Default.LblHttpStatusCode404,
                            Timestamp = DateTimeOperations.FormatTimeStamp()
                        }
                    };

                    return _response;
                }

                _response = new Response
                {
                    IsSuccess = true,
                    NumberItems = numberItems,
                    //Obsolete = request.SortedBy.HasValue ? Sorting.Sort(_listResult, request.SortedBy.Value) : _listResult,
                    StatusResponse = new StatusResponse
                    {
                        Status = 200,
                        Message = Default.LblHttpStatusCode200
                    }
                };
            }
            catch (Exception exception)
            {
                var exceptionLog = new ExceptionLog
                {
                    ApplicationName = $"{ConfigurationManager.AppSettings["SolutionName"]} - {ConfigurationManager.AppSettings["UserFuelServices"]}",
                    Message = exception.Message
                };

                var exceptionRepository = new ExceptionLogRepository("MetadataConnection");
                var exceptionId = exceptionRepository.Add(exceptionLog);

                _response = new Response
                {
                    IsSuccess = false,
                    //Obsolete = null,
                    StatusResponse = new StatusResponse
                    {
                        Status = 500,
                        Message = Default.LblHttpStatusCode500,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };
            }

            return _response;
        }

        public Response GetLatLongSortedWithDistanceResults(LatLongRequest request)
        {
            try
            {
                var listResult = _repository.GetLatLongSortedWithDistanceResults(request);
                var numberItems = listResult.Count;

                if (numberItems == 0)
                {
                    _response = new Response
                    {
                        IsSuccess = true,
                        NumberItems = numberItems,
                        ListResult = listResult,
                        StatusResponse = new StatusResponse
                        {
                            Status = 404,
                            Message = Default.LblHttpStatusCode404,
                            Timestamp = DateTimeOperations.FormatTimeStamp()
                        }
                    };

                    return _response;
                }

                _response = new Response
                {
                    IsSuccess = true,
                    NumberItems = numberItems,
                    ListResult = listResult,
                    StatusResponse = new StatusResponse
                    {
                        Status = 200,
                        Message = Default.LblHttpStatusCode200
                    }
                };
            }
            catch (Exception exception)
            {
                var exceptionLog = new ExceptionLog
                {
                    ApplicationName = $"{ConfigurationManager.AppSettings["SolutionName"]} - {ConfigurationManager.AppSettings["UserFuelServices"]}",
                    Message = exception.Message
                };

                var exceptionRepository = new ExceptionLogRepository("MetadataConnection");
                var exceptionId = exceptionRepository.Add(exceptionLog);

                _response = new Response
                {
                    IsSuccess = false,
                    ListResult = null,
                    StatusResponse = new StatusResponse
                    {
                        Status = 500,
                        Message = Default.LblHttpStatusCode500,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };
            }

            return _response;
        }

        public Response Search(SimpleSearchRequest request)
        {
            try
            {
                _listResult = _repository.Search(request);
                var numberItems = _listResult.Count;

                if (numberItems == 0)
                {
                    _response = new Response
                    {
                        IsSuccess = true,
                        NumberItems = numberItems,
                        //Obsolete = _listResult,
                        StatusResponse = new StatusResponse
                        {
                            Status = 404,
                            Message = Default.LblHttpStatusCode404,
                            Timestamp = DateTimeOperations.FormatTimeStamp()
                        }
                    };

                    return _response;
                }

                _response = new Response
                {
                    IsSuccess = true,
                    NumberItems = numberItems,
                    //Obsolete = request.SortedBy.HasValue ? Sorting.Sort(_listResult, request.SortedBy.Value) : _listResult,
                    StatusResponse = new StatusResponse
                    {
                        Status = 200,
                        Message = Default.LblHttpStatusCode200
                    }
                };
            }
            catch (Exception exception)
            {
                var exceptionLog = new ExceptionLog
                {
                    ApplicationName = $"{ConfigurationManager.AppSettings["SolutionName"]} - {ConfigurationManager.AppSettings["UserFuelServices"]}",
                    Message = exception.Message
                };

                var exceptionRepository = new ExceptionLogRepository("MetadataConnection");
                var exceptionId = exceptionRepository.Add(exceptionLog);

                _response = new Response
                {
                    IsSuccess = false,
                    //Obsolete = null,
                    StatusResponse = new StatusResponse
                    {
                        Status = 500,
                        Message = Default.LblHttpStatusCode500,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };
            }

            return _response;
        }

        public Response Search(AdvancedSearchRequest request)
        {
            try
            {
                _listResult = _repository.Search(request);
                var numberItems = _listResult.Count;

                if (numberItems == 0)
                {
                    _response = new Response
                    {
                        IsSuccess = true,
                        NumberItems = numberItems,
                        //Obsolete = _listResult,
                        StatusResponse = new StatusResponse
                        {
                            Status = 404,
                            Message = Default.LblHttpStatusCode404,
                            Timestamp = DateTimeOperations.FormatTimeStamp()
                        }
                    };

                    return _response;
                }

                _response = new Response
                {
                    IsSuccess = true,
                    NumberItems = numberItems,
                    //Obsolete = request.SortedBy.HasValue ? Sorting.Sort(_listResult, request.SortedBy.Value) : _listResult,
                    StatusResponse = new StatusResponse
                    {
                        Status = 200,
                        Message = Default.LblHttpStatusCode200
                    }
                };
            }
            catch (Exception exception)
            {
                var exceptionLog = new ExceptionLog
                {
                    ApplicationName = $"{ConfigurationManager.AppSettings["SolutionName"]} - {ConfigurationManager.AppSettings["UserFuelServices"]}",
                    Message = exception.Message
                };

                var exceptionRepository = new ExceptionLogRepository("MetadataConnection");
                var exceptionId = exceptionRepository.Add(exceptionLog);

                _response = new Response
                {
                    IsSuccess = false,
                    //Obsolete = null,
                    StatusResponse = new StatusResponse
                    {
                        Status = 500,
                        Message = Default.LblHttpStatusCode500,
                        Timestamp = DateTimeOperations.FormatTimeStamp()
                    }
                };
            }

            return _response;
        }
    }
}