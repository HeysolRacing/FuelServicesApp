﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Element.FuelServices.FuelServicesSite.FuelStationReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FuelStationReference.IFuelStation")]
    public interface IFuelStation {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFuelStation/GetAll", ReplyAction="http://tempuri.org/IFuelStation/GetAllResponse")]
        Element.FuelServices.Shared.Dto.Response GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFuelStation/GetAll", ReplyAction="http://tempuri.org/IFuelStation/GetAllResponse")]
        System.Threading.Tasks.Task<Element.FuelServices.Shared.Dto.Response> GetAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFuelStationChannel : Element.FuelServices.FuelServicesSite.FuelStationReference.IFuelStation, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FuelStationClient : System.ServiceModel.ClientBase<Element.FuelServices.FuelServicesSite.FuelStationReference.IFuelStation>, Element.FuelServices.FuelServicesSite.FuelStationReference.IFuelStation {
        
        public FuelStationClient() {
        }
        
        public FuelStationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FuelStationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FuelStationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FuelStationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Element.FuelServices.Shared.Dto.Response GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<Element.FuelServices.Shared.Dto.Response> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
    }
}
