﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.BasicOperationReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/PL.Entities")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MeasureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.Dictionary<WebApi.BasicOperationReference.Shop, WebApi.BasicOperationReference.ContainedIn> ShopsField;
        
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
        public System.Guid Id {
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
        public string Measure {
            get {
                return this.MeasureField;
            }
            set {
                if ((object.ReferenceEquals(this.MeasureField, value) != true)) {
                    this.MeasureField = value;
                    this.RaisePropertyChanged("Measure");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.Dictionary<WebApi.BasicOperationReference.Shop, WebApi.BasicOperationReference.ContainedIn> Shops {
            get {
                return this.ShopsField;
            }
            set {
                if ((object.ReferenceEquals(this.ShopsField, value) != true)) {
                    this.ShopsField = value;
                    this.RaisePropertyChanged("Shops");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Shop", Namespace="http://schemas.datacontract.org/2004/07/PL.Entities")]
    [System.SerializableAttribute()]
    public partial class Shop : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApi.BasicOperationReference.City CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LatitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LongitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StreetField;
        
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
        public WebApi.BasicOperationReference.City City {
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
        public System.Guid Id {
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
        public string Latitude {
            get {
                return this.LatitudeField;
            }
            set {
                if ((object.ReferenceEquals(this.LatitudeField, value) != true)) {
                    this.LatitudeField = value;
                    this.RaisePropertyChanged("Latitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Longitude {
            get {
                return this.LongitudeField;
            }
            set {
                if ((object.ReferenceEquals(this.LongitudeField, value) != true)) {
                    this.LongitudeField = value;
                    this.RaisePropertyChanged("Longitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Number {
            get {
                return this.NumberField;
            }
            set {
                if ((object.ReferenceEquals(this.NumberField, value) != true)) {
                    this.NumberField = value;
                    this.RaisePropertyChanged("Number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Street {
            get {
                return this.StreetField;
            }
            set {
                if ((object.ReferenceEquals(this.StreetField, value) != true)) {
                    this.StreetField = value;
                    this.RaisePropertyChanged("Street");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ContainedIn", Namespace="http://schemas.datacontract.org/2004/07/PL.Entities")]
    [System.SerializableAttribute()]
    public partial class ContainedIn : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal AmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
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
        public decimal Amount {
            get {
                return this.AmountField;
            }
            set {
                if ((this.AmountField.Equals(value) != true)) {
                    this.AmountField = value;
                    this.RaisePropertyChanged("Amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="City", Namespace="http://schemas.datacontract.org/2004/07/PL.Entities")]
    [System.SerializableAttribute()]
    public partial class City : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WebApi.BasicOperationReference.Shop[] ShopsField;
        
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
        public System.Guid Id {
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public WebApi.BasicOperationReference.Shop[] Shops {
            get {
                return this.ShopsField;
            }
            set {
                if ((object.ReferenceEquals(this.ShopsField, value) != true)) {
                    this.ShopsField = value;
                    this.RaisePropertyChanged("Shops");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BasicOperationReference.IBasicOperationService")]
    public interface IBasicOperationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicOperationService/GetNearest", ReplyAction="http://tempuri.org/IBasicOperationService/GetNearestResponse")]
        WebApi.BasicOperationReference.Product GetNearest(string name, double longitude, double latitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicOperationService/GetNearest", ReplyAction="http://tempuri.org/IBasicOperationService/GetNearestResponse")]
        System.Threading.Tasks.Task<WebApi.BasicOperationReference.Product> GetNearestAsync(string name, double longitude, double latitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicOperationService/GetCheapestInCity", ReplyAction="http://tempuri.org/IBasicOperationService/GetCheapestInCityResponse")]
        WebApi.BasicOperationReference.Product GetCheapestInCity(string productName, string cityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicOperationService/GetCheapestInCity", ReplyAction="http://tempuri.org/IBasicOperationService/GetCheapestInCityResponse")]
        System.Threading.Tasks.Task<WebApi.BasicOperationReference.Product> GetCheapestInCityAsync(string productName, string cityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicOperationService/GetManyCheapestInCity", ReplyAction="http://tempuri.org/IBasicOperationService/GetManyCheapestInCityResponse")]
        System.Collections.Generic.Dictionary<WebApi.BasicOperationReference.Shop, decimal> GetManyCheapestInCity(string[] products, string cityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicOperationService/GetManyCheapestInCity", ReplyAction="http://tempuri.org/IBasicOperationService/GetManyCheapestInCityResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<WebApi.BasicOperationReference.Shop, decimal>> GetManyCheapestInCityAsync(string[] products, string cityName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicOperationService/GetManyNearest", ReplyAction="http://tempuri.org/IBasicOperationService/GetManyNearestResponse")]
        System.Collections.Generic.Dictionary<WebApi.BasicOperationReference.Shop, decimal> GetManyNearest(string[] products, double lat, double lon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicOperationService/GetManyNearest", ReplyAction="http://tempuri.org/IBasicOperationService/GetManyNearestResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<WebApi.BasicOperationReference.Shop, decimal>> GetManyNearestAsync(string[] products, double lat, double lon);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicOperationService/SearchForKeyword", ReplyAction="http://tempuri.org/IBasicOperationService/SearchForKeywordResponse")]
        string[] SearchForKeyword(string keyword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBasicOperationService/SearchForKeyword", ReplyAction="http://tempuri.org/IBasicOperationService/SearchForKeywordResponse")]
        System.Threading.Tasks.Task<string[]> SearchForKeywordAsync(string keyword);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBasicOperationServiceChannel : WebApi.BasicOperationReference.IBasicOperationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BasicOperationServiceClient : System.ServiceModel.ClientBase<WebApi.BasicOperationReference.IBasicOperationService>, WebApi.BasicOperationReference.IBasicOperationService {
        
        public BasicOperationServiceClient() {
        }
        
        public BasicOperationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BasicOperationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BasicOperationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BasicOperationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WebApi.BasicOperationReference.Product GetNearest(string name, double longitude, double latitude) {
            return base.Channel.GetNearest(name, longitude, latitude);
        }
        
        public System.Threading.Tasks.Task<WebApi.BasicOperationReference.Product> GetNearestAsync(string name, double longitude, double latitude) {
            return base.Channel.GetNearestAsync(name, longitude, latitude);
        }
        
        public WebApi.BasicOperationReference.Product GetCheapestInCity(string productName, string cityName) {
            return base.Channel.GetCheapestInCity(productName, cityName);
        }
        
        public System.Threading.Tasks.Task<WebApi.BasicOperationReference.Product> GetCheapestInCityAsync(string productName, string cityName) {
            return base.Channel.GetCheapestInCityAsync(productName, cityName);
        }
        
        public System.Collections.Generic.Dictionary<WebApi.BasicOperationReference.Shop, decimal> GetManyCheapestInCity(string[] products, string cityName) {
            return base.Channel.GetManyCheapestInCity(products, cityName);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<WebApi.BasicOperationReference.Shop, decimal>> GetManyCheapestInCityAsync(string[] products, string cityName) {
            return base.Channel.GetManyCheapestInCityAsync(products, cityName);
        }
        
        public System.Collections.Generic.Dictionary<WebApi.BasicOperationReference.Shop, decimal> GetManyNearest(string[] products, double lat, double lon) {
            return base.Channel.GetManyNearest(products, lat, lon);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<WebApi.BasicOperationReference.Shop, decimal>> GetManyNearestAsync(string[] products, double lat, double lon) {
            return base.Channel.GetManyNearestAsync(products, lat, lon);
        }
        
        public string[] SearchForKeyword(string keyword) {
            return base.Channel.SearchForKeyword(keyword);
        }
        
        public System.Threading.Tasks.Task<string[]> SearchForKeywordAsync(string keyword) {
            return base.Channel.SearchForKeywordAsync(keyword);
        }
    }
}
