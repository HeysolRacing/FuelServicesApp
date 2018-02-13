﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CommonRequest", Namespace="http://schemas.datacontract.org/2004/07/Element.FuelServices.Shared.Dto")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.LatLongRequest))]
    public partial class CommonRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.EnumProduct> SortedByField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SupplierIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserTicketField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.EnumProduct> SortedBy {
            get {
                return this.SortedByField;
            }
            set {
                if ((this.SortedByField.Equals(value) != true)) {
                    this.SortedByField = value;
                    this.RaisePropertyChanged("SortedBy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SupplierId {
            get {
                return this.SupplierIdField;
            }
            set {
                if ((this.SupplierIdField.Equals(value) != true)) {
                    this.SupplierIdField = value;
                    this.RaisePropertyChanged("SupplierId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserTicket {
            get {
                return this.UserTicketField;
            }
            set {
                if ((object.ReferenceEquals(this.UserTicketField, value) != true)) {
                    this.UserTicketField = value;
                    this.RaisePropertyChanged("UserTicket");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LatLongRequest", Namespace="http://schemas.datacontract.org/2004/07/Element.FuelServices.Shared.Dto")]
    [System.SerializableAttribute()]
    public partial class LatLongRequest : Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.CommonRequest {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal DistanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FuelTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal LattitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal LongitudeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Distance {
            get {
                return this.DistanceField;
            }
            set {
                if ((this.DistanceField.Equals(value) != true)) {
                    this.DistanceField = value;
                    this.RaisePropertyChanged("Distance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FuelType {
            get {
                return this.FuelTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.FuelTypeField, value) != true)) {
                    this.FuelTypeField = value;
                    this.RaisePropertyChanged("FuelType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Lattitude {
            get {
                return this.LattitudeField;
            }
            set {
                if ((this.LattitudeField.Equals(value) != true)) {
                    this.LattitudeField = value;
                    this.RaisePropertyChanged("Lattitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Longitude {
            get {
                return this.LongitudeField;
            }
            set {
                if ((this.LongitudeField.Equals(value) != true)) {
                    this.LongitudeField = value;
                    this.RaisePropertyChanged("Longitude");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EnumProduct", Namespace="http://schemas.datacontract.org/2004/07/Element.FuelServices.Shared.Enum")]
    public enum EnumProduct : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotSpecified = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Diesel = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Magna = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Premium = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Response", Namespace="http://schemas.datacontract.org/2004/07/Element.FuelServices.Shared.Dto")]
    [System.SerializableAttribute()]
    public partial class Response : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsSuccessField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.FuelStationDetail> ListResultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberItemsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.StatusResponse StatusResponseField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsSuccess {
            get {
                return this.IsSuccessField;
            }
            set {
                if ((this.IsSuccessField.Equals(value) != true)) {
                    this.IsSuccessField = value;
                    this.RaisePropertyChanged("IsSuccess");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.FuelStationDetail> ListResult {
            get {
                return this.ListResultField;
            }
            set {
                if ((object.ReferenceEquals(this.ListResultField, value) != true)) {
                    this.ListResultField = value;
                    this.RaisePropertyChanged("ListResult");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumberItems {
            get {
                return this.NumberItemsField;
            }
            set {
                if ((this.NumberItemsField.Equals(value) != true)) {
                    this.NumberItemsField = value;
                    this.RaisePropertyChanged("NumberItems");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.StatusResponse StatusResponse {
            get {
                return this.StatusResponseField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusResponseField, value) != true)) {
                    this.StatusResponseField = value;
                    this.RaisePropertyChanged("StatusResponse");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StatusResponse", Namespace="http://schemas.datacontract.org/2004/07/Element.FuelServices.Shared.Dto")]
    [System.SerializableAttribute()]
    public partial class StatusResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TimestampField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Timestamp {
            get {
                return this.TimestampField;
            }
            set {
                if ((object.ReferenceEquals(this.TimestampField, value) != true)) {
                    this.TimestampField = value;
                    this.RaisePropertyChanged("Timestamp");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FuelStationDetail", Namespace="http://schemas.datacontract.org/2004/07/Element.FuelServices.Shared.Entities.Oper" +
        "ation")]
    [System.SerializableAttribute()]
    public partial class FuelStationDetail : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Address1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DieselDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DieselIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal DieselPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double DistanceToStationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal LatitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal LongitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime PremiumDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PremiumIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PremiumPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long StationIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StationNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SupplierIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime UnleadedDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UnleadedIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal UnleadedPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZipField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address1 {
            get {
                return this.Address1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Address1Field, value) != true)) {
                    this.Address1Field = value;
                    this.RaisePropertyChanged("Address1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BrandName {
            get {
                return this.BrandNameField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandNameField, value) != true)) {
                    this.BrandNameField = value;
                    this.RaisePropertyChanged("BrandName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DieselDate {
            get {
                return this.DieselDateField;
            }
            set {
                if ((this.DieselDateField.Equals(value) != true)) {
                    this.DieselDateField = value;
                    this.RaisePropertyChanged("DieselDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DieselId {
            get {
                return this.DieselIdField;
            }
            set {
                if ((this.DieselIdField.Equals(value) != true)) {
                    this.DieselIdField = value;
                    this.RaisePropertyChanged("DieselId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal DieselPrice {
            get {
                return this.DieselPriceField;
            }
            set {
                if ((this.DieselPriceField.Equals(value) != true)) {
                    this.DieselPriceField = value;
                    this.RaisePropertyChanged("DieselPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double DistanceToStation {
            get {
                return this.DistanceToStationField;
            }
            set {
                if ((this.DistanceToStationField.Equals(value) != true)) {
                    this.DistanceToStationField = value;
                    this.RaisePropertyChanged("DistanceToStation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Latitude {
            get {
                return this.LatitudeField;
            }
            set {
                if ((this.LatitudeField.Equals(value) != true)) {
                    this.LatitudeField = value;
                    this.RaisePropertyChanged("Latitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Longitude {
            get {
                return this.LongitudeField;
            }
            set {
                if ((this.LongitudeField.Equals(value) != true)) {
                    this.LongitudeField = value;
                    this.RaisePropertyChanged("Longitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime PremiumDate {
            get {
                return this.PremiumDateField;
            }
            set {
                if ((this.PremiumDateField.Equals(value) != true)) {
                    this.PremiumDateField = value;
                    this.RaisePropertyChanged("PremiumDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PremiumId {
            get {
                return this.PremiumIdField;
            }
            set {
                if ((this.PremiumIdField.Equals(value) != true)) {
                    this.PremiumIdField = value;
                    this.RaisePropertyChanged("PremiumId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal PremiumPrice {
            get {
                return this.PremiumPriceField;
            }
            set {
                if ((this.PremiumPriceField.Equals(value) != true)) {
                    this.PremiumPriceField = value;
                    this.RaisePropertyChanged("PremiumPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long StationId {
            get {
                return this.StationIdField;
            }
            set {
                if ((this.StationIdField.Equals(value) != true)) {
                    this.StationIdField = value;
                    this.RaisePropertyChanged("StationId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StationName {
            get {
                return this.StationNameField;
            }
            set {
                if ((object.ReferenceEquals(this.StationNameField, value) != true)) {
                    this.StationNameField = value;
                    this.RaisePropertyChanged("StationName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SupplierId {
            get {
                return this.SupplierIdField;
            }
            set {
                if ((this.SupplierIdField.Equals(value) != true)) {
                    this.SupplierIdField = value;
                    this.RaisePropertyChanged("SupplierId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime UnleadedDate {
            get {
                return this.UnleadedDateField;
            }
            set {
                if ((this.UnleadedDateField.Equals(value) != true)) {
                    this.UnleadedDateField = value;
                    this.RaisePropertyChanged("UnleadedDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UnleadedId {
            get {
                return this.UnleadedIdField;
            }
            set {
                if ((this.UnleadedIdField.Equals(value) != true)) {
                    this.UnleadedIdField = value;
                    this.RaisePropertyChanged("UnleadedId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal UnleadedPrice {
            get {
                return this.UnleadedPriceField;
            }
            set {
                if ((this.UnleadedPriceField.Equals(value) != true)) {
                    this.UnleadedPriceField = value;
                    this.RaisePropertyChanged("UnleadedPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Zip {
            get {
                return this.ZipField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipField, value) != true)) {
                    this.ZipField = value;
                    this.RaisePropertyChanged("Zip");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LattitudeLongitudeReference.ILattitudeLongitude")]
    public interface ILattitudeLongitude {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILattitudeLongitude/Get", ReplyAction="http://tempuri.org/ILattitudeLongitude/GetResponse")]
        Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.Response Get(Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.LatLongRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILattitudeLongitude/Get", ReplyAction="http://tempuri.org/ILattitudeLongitude/GetResponse")]
        System.Threading.Tasks.Task<Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.Response> GetAsync(Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.LatLongRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILattitudeLongitudeChannel : Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.ILattitudeLongitude, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LattitudeLongitudeClient : System.ServiceModel.ClientBase<Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.ILattitudeLongitude>, Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.ILattitudeLongitude {
        
        public LattitudeLongitudeClient() {
        }
        
        public LattitudeLongitudeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LattitudeLongitudeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LattitudeLongitudeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LattitudeLongitudeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.Response Get(Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.LatLongRequest request) {
            return base.Channel.Get(request);
        }
        
        public System.Threading.Tasks.Task<Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.Response> GetAsync(Element.FuelServices.FuelServicesSite.LattitudeLongitudeReference.LatLongRequest request) {
            return base.Channel.GetAsync(request);
        }
    }
}
