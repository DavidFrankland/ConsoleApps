﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServices.MarketPricesWebService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DPL", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class DPL : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string correlationIdFieldField;
        
        private System.DateTime messageDateTimeFieldField;
        
        private string messageIdFieldField;
        
        private WebServices.MarketPricesWebService.DPLMessagePayload messagePayloadFieldField;
        
        private string messageTypeFieldField;
        
        private string messageVersionFieldField;
        
        private string originatingApplicationFieldField;
        
        private string originatingOrgFieldField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string correlationIdField {
            get {
                return this.correlationIdFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.correlationIdFieldField, value) != true)) {
                    this.correlationIdFieldField = value;
                    this.RaisePropertyChanged("correlationIdField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.DateTime messageDateTimeField {
            get {
                return this.messageDateTimeFieldField;
            }
            set {
                if ((this.messageDateTimeFieldField.Equals(value) != true)) {
                    this.messageDateTimeFieldField = value;
                    this.RaisePropertyChanged("messageDateTimeField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string messageIdField {
            get {
                return this.messageIdFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.messageIdFieldField, value) != true)) {
                    this.messageIdFieldField = value;
                    this.RaisePropertyChanged("messageIdField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public WebServices.MarketPricesWebService.DPLMessagePayload messagePayloadField {
            get {
                return this.messagePayloadFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.messagePayloadFieldField, value) != true)) {
                    this.messagePayloadFieldField = value;
                    this.RaisePropertyChanged("messagePayloadField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string messageTypeField {
            get {
                return this.messageTypeFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.messageTypeFieldField, value) != true)) {
                    this.messageTypeFieldField = value;
                    this.RaisePropertyChanged("messageTypeField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string messageVersionField {
            get {
                return this.messageVersionFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.messageVersionFieldField, value) != true)) {
                    this.messageVersionFieldField = value;
                    this.RaisePropertyChanged("messageVersionField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string originatingApplicationField {
            get {
                return this.originatingApplicationFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.originatingApplicationFieldField, value) != true)) {
                    this.originatingApplicationFieldField = value;
                    this.RaisePropertyChanged("originatingApplicationField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string originatingOrgField {
            get {
                return this.originatingOrgFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.originatingOrgFieldField, value) != true)) {
                    this.originatingOrgFieldField = value;
                    this.RaisePropertyChanged("originatingOrgField");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DPLMessagePayload", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class DPLMessagePayload : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private WebServices.MarketPricesWebService.ArrayOfXmlElement anyFieldField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public WebServices.MarketPricesWebService.ArrayOfXmlElement anyField {
            get {
                return this.anyFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.anyFieldField, value) != true)) {
                    this.anyFieldField = value;
                    this.RaisePropertyChanged("anyField");
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
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfXmlElement", Namespace="http://schemas.datacontract.org/2004/07/System.Xml", ItemName="XmlElement")]
    [System.SerializableAttribute()]
    public class ArrayOfXmlElement : System.Collections.Generic.List<System.Xml.Linq.XElement> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MarketPricesWebService.IMarketPricesWebService")]
    public interface IMarketPricesWebService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketPricesWebService/AddBrokerOrder", ReplyAction="http://tempuri.org/IMarketPricesWebService/AddBrokerOrderResponse")]
        void AddBrokerOrder(WebServices.MarketPricesWebService.DPL message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketPricesWebService/AddBrokerOrder", ReplyAction="http://tempuri.org/IMarketPricesWebService/AddBrokerOrderResponse")]
        System.Threading.Tasks.Task AddBrokerOrderAsync(WebServices.MarketPricesWebService.DPL message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketPricesWebService/AddBrokerProductDetails", ReplyAction="http://tempuri.org/IMarketPricesWebService/AddBrokerProductDetailsResponse")]
        void AddBrokerProductDetails(WebServices.MarketPricesWebService.DPL message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketPricesWebService/AddBrokerProductDetails", ReplyAction="http://tempuri.org/IMarketPricesWebService/AddBrokerProductDetailsResponse")]
        System.Threading.Tasks.Task AddBrokerProductDetailsAsync(WebServices.MarketPricesWebService.DPL message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketPricesWebService/AddNordpoolPublicTrade", ReplyAction="http://tempuri.org/IMarketPricesWebService/AddNordpoolPublicTradeResponse")]
        void AddNordpoolPublicTrade(WebServices.MarketPricesWebService.DPL message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketPricesWebService/AddNordpoolPublicTrade", ReplyAction="http://tempuri.org/IMarketPricesWebService/AddNordpoolPublicTradeResponse")]
        System.Threading.Tasks.Task AddNordpoolPublicTradeAsync(WebServices.MarketPricesWebService.DPL message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketPricesWebService/AddNordpoolDayAheadTrade", ReplyAction="http://tempuri.org/IMarketPricesWebService/AddNordpoolDayAheadTradeResponse")]
        void AddNordpoolDayAheadTrade(WebServices.MarketPricesWebService.DPL message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketPricesWebService/AddNordpoolDayAheadTrade", ReplyAction="http://tempuri.org/IMarketPricesWebService/AddNordpoolDayAheadTradeResponse")]
        System.Threading.Tasks.Task AddNordpoolDayAheadTradeAsync(WebServices.MarketPricesWebService.DPL message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketPricesWebService/AddEtrmEtsPublicTrade", ReplyAction="http://tempuri.org/IMarketPricesWebService/AddEtrmEtsPublicTradeResponse")]
        void AddEtrmEtsPublicTrade(WebServices.MarketPricesWebService.DPL message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketPricesWebService/AddEtrmEtsPublicTrade", ReplyAction="http://tempuri.org/IMarketPricesWebService/AddEtrmEtsPublicTradeResponse")]
        System.Threading.Tasks.Task AddEtrmEtsPublicTradeAsync(WebServices.MarketPricesWebService.DPL message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketPricesWebService/AddEtrmM7PublicTrade", ReplyAction="http://tempuri.org/IMarketPricesWebService/AddEtrmM7PublicTradeResponse")]
        void AddEtrmM7PublicTrade(WebServices.MarketPricesWebService.DPL message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketPricesWebService/AddEtrmM7PublicTrade", ReplyAction="http://tempuri.org/IMarketPricesWebService/AddEtrmM7PublicTradeResponse")]
        System.Threading.Tasks.Task AddEtrmM7PublicTradeAsync(WebServices.MarketPricesWebService.DPL message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketPricesWebService/AddTrayportSequenceItems", ReplyAction="http://tempuri.org/IMarketPricesWebService/AddTrayportSequenceItemsResponse")]
        void AddTrayportSequenceItems(WebServices.MarketPricesWebService.DPL message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketPricesWebService/AddTrayportSequenceItems", ReplyAction="http://tempuri.org/IMarketPricesWebService/AddTrayportSequenceItemsResponse")]
        System.Threading.Tasks.Task AddTrayportSequenceItemsAsync(WebServices.MarketPricesWebService.DPL message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketPricesWebService/AddTrayportPublicTrade", ReplyAction="http://tempuri.org/IMarketPricesWebService/AddTrayportPublicTradeResponse")]
        void AddTrayportPublicTrade(WebServices.MarketPricesWebService.DPL message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketPricesWebService/AddTrayportPublicTrade", ReplyAction="http://tempuri.org/IMarketPricesWebService/AddTrayportPublicTradeResponse")]
        System.Threading.Tasks.Task AddTrayportPublicTradeAsync(WebServices.MarketPricesWebService.DPL message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketPricesWebService/AddTrayportPublicOrder", ReplyAction="http://tempuri.org/IMarketPricesWebService/AddTrayportPublicOrderResponse")]
        void AddTrayportPublicOrder(WebServices.MarketPricesWebService.DPL message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarketPricesWebService/AddTrayportPublicOrder", ReplyAction="http://tempuri.org/IMarketPricesWebService/AddTrayportPublicOrderResponse")]
        System.Threading.Tasks.Task AddTrayportPublicOrderAsync(WebServices.MarketPricesWebService.DPL message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMarketPricesWebServiceChannel : WebServices.MarketPricesWebService.IMarketPricesWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MarketPricesWebServiceClient : System.ServiceModel.ClientBase<WebServices.MarketPricesWebService.IMarketPricesWebService>, WebServices.MarketPricesWebService.IMarketPricesWebService {
        
        public MarketPricesWebServiceClient() {
        }
        
        public MarketPricesWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MarketPricesWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MarketPricesWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MarketPricesWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddBrokerOrder(WebServices.MarketPricesWebService.DPL message) {
            base.Channel.AddBrokerOrder(message);
        }
        
        public System.Threading.Tasks.Task AddBrokerOrderAsync(WebServices.MarketPricesWebService.DPL message) {
            return base.Channel.AddBrokerOrderAsync(message);
        }
        
        public void AddBrokerProductDetails(WebServices.MarketPricesWebService.DPL message) {
            base.Channel.AddBrokerProductDetails(message);
        }
        
        public System.Threading.Tasks.Task AddBrokerProductDetailsAsync(WebServices.MarketPricesWebService.DPL message) {
            return base.Channel.AddBrokerProductDetailsAsync(message);
        }
        
        public void AddNordpoolPublicTrade(WebServices.MarketPricesWebService.DPL message) {
            base.Channel.AddNordpoolPublicTrade(message);
        }
        
        public System.Threading.Tasks.Task AddNordpoolPublicTradeAsync(WebServices.MarketPricesWebService.DPL message) {
            return base.Channel.AddNordpoolPublicTradeAsync(message);
        }
        
        public void AddNordpoolDayAheadTrade(WebServices.MarketPricesWebService.DPL message) {
            base.Channel.AddNordpoolDayAheadTrade(message);
        }
        
        public System.Threading.Tasks.Task AddNordpoolDayAheadTradeAsync(WebServices.MarketPricesWebService.DPL message) {
            return base.Channel.AddNordpoolDayAheadTradeAsync(message);
        }
        
        public void AddEtrmEtsPublicTrade(WebServices.MarketPricesWebService.DPL message) {
            base.Channel.AddEtrmEtsPublicTrade(message);
        }
        
        public System.Threading.Tasks.Task AddEtrmEtsPublicTradeAsync(WebServices.MarketPricesWebService.DPL message) {
            return base.Channel.AddEtrmEtsPublicTradeAsync(message);
        }
        
        public void AddEtrmM7PublicTrade(WebServices.MarketPricesWebService.DPL message) {
            base.Channel.AddEtrmM7PublicTrade(message);
        }
        
        public System.Threading.Tasks.Task AddEtrmM7PublicTradeAsync(WebServices.MarketPricesWebService.DPL message) {
            return base.Channel.AddEtrmM7PublicTradeAsync(message);
        }
        
        public void AddTrayportSequenceItems(WebServices.MarketPricesWebService.DPL message) {
            base.Channel.AddTrayportSequenceItems(message);
        }
        
        public System.Threading.Tasks.Task AddTrayportSequenceItemsAsync(WebServices.MarketPricesWebService.DPL message) {
            return base.Channel.AddTrayportSequenceItemsAsync(message);
        }
        
        public void AddTrayportPublicTrade(WebServices.MarketPricesWebService.DPL message) {
            base.Channel.AddTrayportPublicTrade(message);
        }
        
        public System.Threading.Tasks.Task AddTrayportPublicTradeAsync(WebServices.MarketPricesWebService.DPL message) {
            return base.Channel.AddTrayportPublicTradeAsync(message);
        }
        
        public void AddTrayportPublicOrder(WebServices.MarketPricesWebService.DPL message) {
            base.Channel.AddTrayportPublicOrder(message);
        }
        
        public System.Threading.Tasks.Task AddTrayportPublicOrderAsync(WebServices.MarketPricesWebService.DPL message) {
            return base.Channel.AddTrayportPublicOrderAsync(message);
        }
    }
}
