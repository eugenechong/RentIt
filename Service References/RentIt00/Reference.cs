﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentIt.RentIt00 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Names", Namespace="http://schemas.datacontract.org/2004/07/RentItServices")]
    [System.SerializableAttribute()]
    public partial class Names : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RentIt.RentIt00.NameRecord[] NameListField;
        
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
        public RentIt.RentIt00.NameRecord[] NameList {
            get {
                return this.NameListField;
            }
            set {
                if ((object.ReferenceEquals(this.NameListField, value) != true)) {
                    this.NameListField = value;
                    this.RaisePropertyChanged("NameList");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="NameRecord", Namespace="http://schemas.datacontract.org/2004/07/RentItServices")]
    [System.SerializableAttribute()]
    public partial class NameRecord : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomExpMsg", Namespace="http://schemas.datacontract.org/2004/07/RentItServices")]
    [System.SerializableAttribute()]
    public partial class CustomExpMsg : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ErrorMsgField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ErrorNumberField;
        
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
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMsg {
            get {
                return this.ErrorMsgField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMsgField, value) != true)) {
                    this.ErrorMsgField = value;
                    this.RaisePropertyChanged("ErrorMsg");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ErrorNumber {
            get {
                return this.ErrorNumberField;
            }
            set {
                if ((this.ErrorNumberField.Equals(value) != true)) {
                    this.ErrorNumberField = value;
                    this.RaisePropertyChanged("ErrorNumber");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/RentItServices")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RentIt00.IRentIt")]
    public interface IRentIt {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentIt/Echo", ReplyAction="http://tempuri.org/IRentIt/EchoResponse")]
        string Echo(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentIt/HelloWorld", ReplyAction="http://tempuri.org/IRentIt/HelloWorldResponse")]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentIt/Add", ReplyAction="http://tempuri.org/IRentIt/AddResponse")]
        int Add(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentIt/ListNames", ReplyAction="http://tempuri.org/IRentIt/ListNamesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RentIt.RentIt00.CustomExpMsg), Action="http://tempuri.org/IRentIt/ListNamesCustomExpMsgFault", Name="CustomExpMsg", Namespace="http://schemas.datacontract.org/2004/07/RentItServices")]
        RentIt.RentIt00.Names ListNames();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentIt/ListNamesAsString", ReplyAction="http://tempuri.org/IRentIt/ListNamesAsStringResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RentIt.RentIt00.CustomExpMsg), Action="http://tempuri.org/IRentIt/ListNamesAsStringCustomExpMsgFault", Name="CustomExpMsg", Namespace="http://schemas.datacontract.org/2004/07/RentItServices")]
        string ListNamesAsString();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentIt/ListNamesLinq", ReplyAction="http://tempuri.org/IRentIt/ListNamesLinqResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RentIt.RentIt00.CustomExpMsg), Action="http://tempuri.org/IRentIt/ListNamesLinqCustomExpMsgFault", Name="CustomExpMsg", Namespace="http://schemas.datacontract.org/2004/07/RentItServices")]
        RentIt.RentIt00.Names ListNamesLinq();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentIt/ListNamesLinqEF", ReplyAction="http://tempuri.org/IRentIt/ListNamesLinqEFResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RentIt.RentIt00.CustomExpMsg), Action="http://tempuri.org/IRentIt/ListNamesLinqEFCustomExpMsgFault", Name="CustomExpMsg", Namespace="http://schemas.datacontract.org/2004/07/RentItServices")]
        RentIt.RentIt00.Names ListNamesLinqEF();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentIt/insertNameLinq", ReplyAction="http://tempuri.org/IRentIt/insertNameLinqResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RentIt.RentIt00.CustomExpMsg), Action="http://tempuri.org/IRentIt/insertNameLinqCustomExpMsgFault", Name="CustomExpMsg", Namespace="http://schemas.datacontract.org/2004/07/RentItServices")]
        string insertNameLinq(int id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentIt/insertNameLinqEF", ReplyAction="http://tempuri.org/IRentIt/insertNameLinqEFResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RentIt.RentIt00.CustomExpMsg), Action="http://tempuri.org/IRentIt/insertNameLinqEFCustomExpMsgFault", Name="CustomExpMsg", Namespace="http://schemas.datacontract.org/2004/07/RentItServices")]
        string insertNameLinqEF(int id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentIt/deleteNameLinq", ReplyAction="http://tempuri.org/IRentIt/deleteNameLinqResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RentIt.RentIt00.CustomExpMsg), Action="http://tempuri.org/IRentIt/deleteNameLinqCustomExpMsgFault", Name="CustomExpMsg", Namespace="http://schemas.datacontract.org/2004/07/RentItServices")]
        string deleteNameLinq(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentIt/deleteNameLinqEF", ReplyAction="http://tempuri.org/IRentIt/deleteNameLinqEFResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RentIt.RentIt00.CustomExpMsg), Action="http://tempuri.org/IRentIt/deleteNameLinqEFCustomExpMsgFault", Name="CustomExpMsg", Namespace="http://schemas.datacontract.org/2004/07/RentItServices")]
        string deleteNameLinqEF(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentIt/sendEmail", ReplyAction="http://tempuri.org/IRentIt/sendEmailResponse")]
        void sendEmail(string subject, string body);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentIt/GetStructuredData", ReplyAction="http://tempuri.org/IRentIt/GetStructuredDataResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RentIt.RentIt00.CustomExpMsg), Action="http://tempuri.org/IRentIt/GetStructuredDataCustomExpMsgFault", Name="CustomExpMsg", Namespace="http://schemas.datacontract.org/2004/07/RentItServices")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentNullException), Action="http://tempuri.org/IRentIt/GetStructuredDataArgumentNullExceptionFault", Name="ArgumentNullException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        RentIt.RentIt00.CompositeType GetStructuredData(RentIt.RentIt00.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentIt/GenFile", ReplyAction="http://tempuri.org/IRentIt/GenFileResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RentIt.RentIt00.CustomExpMsg), Action="http://tempuri.org/IRentIt/GenFileCustomExpMsgFault", Name="CustomExpMsg", Namespace="http://schemas.datacontract.org/2004/07/RentItServices")]
        string GenFile(int Size);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentIt/GetFile", ReplyAction="http://tempuri.org/IRentIt/GetFileResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RentIt.RentIt00.CustomExpMsg), Action="http://tempuri.org/IRentIt/GetFileCustomExpMsgFault", Name="CustomExpMsg", Namespace="http://schemas.datacontract.org/2004/07/RentItServices")]
        System.IO.Stream GetFile();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentIt/UploadFile", ReplyAction="http://tempuri.org/IRentIt/UploadFileResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RentIt.RentIt00.CustomExpMsg), Action="http://tempuri.org/IRentIt/UploadFileCustomExpMsgFault", Name="CustomExpMsg", Namespace="http://schemas.datacontract.org/2004/07/RentItServices")]
        void UploadFile(System.IO.Stream s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentIt/UploadVideo", ReplyAction="http://tempuri.org/IRentIt/UploadVideoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RentIt.RentIt00.CustomExpMsg), Action="http://tempuri.org/IRentIt/UploadVideoCustomExpMsgFault", Name="CustomExpMsg", Namespace="http://schemas.datacontract.org/2004/07/RentItServices")]
        void UploadVideo(System.IO.Stream s);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRentIt/GetVideo", ReplyAction="http://tempuri.org/IRentIt/GetVideoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(RentIt.RentIt00.CustomExpMsg), Action="http://tempuri.org/IRentIt/GetVideoCustomExpMsgFault", Name="CustomExpMsg", Namespace="http://schemas.datacontract.org/2004/07/RentItServices")]
        System.IO.Stream GetVideo();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRentItChannel : RentIt.RentIt00.IRentIt, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RentItClient : System.ServiceModel.ClientBase<RentIt.RentIt00.IRentIt>, RentIt.RentIt00.IRentIt {
        
        public RentItClient() {
        }
        
        public RentItClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RentItClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RentItClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RentItClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Echo(int value) {
            return base.Channel.Echo(value);
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public int Add(int x, int y) {
            return base.Channel.Add(x, y);
        }
        
        public RentIt.RentIt00.Names ListNames() {
            return base.Channel.ListNames();
        }
        
        public string ListNamesAsString() {
            return base.Channel.ListNamesAsString();
        }
        
        public RentIt.RentIt00.Names ListNamesLinq() {
            return base.Channel.ListNamesLinq();
        }
        
        public RentIt.RentIt00.Names ListNamesLinqEF() {
            return base.Channel.ListNamesLinqEF();
        }
        
        public string insertNameLinq(int id, string name) {
            return base.Channel.insertNameLinq(id, name);
        }
        
        public string insertNameLinqEF(int id, string name) {
            return base.Channel.insertNameLinqEF(id, name);
        }
        
        public string deleteNameLinq(int id) {
            return base.Channel.deleteNameLinq(id);
        }
        
        public string deleteNameLinqEF(int id) {
            return base.Channel.deleteNameLinqEF(id);
        }
        
        public void sendEmail(string subject, string body) {
            base.Channel.sendEmail(subject, body);
        }
        
        public RentIt.RentIt00.CompositeType GetStructuredData(RentIt.RentIt00.CompositeType composite) {
            return base.Channel.GetStructuredData(composite);
        }
        
        public string GenFile(int Size) {
            return base.Channel.GenFile(Size);
        }
        
        public System.IO.Stream GetFile() {
            return base.Channel.GetFile();
        }
        
        public void UploadFile(System.IO.Stream s) {
            base.Channel.UploadFile(s);
        }
        
        public void UploadVideo(System.IO.Stream s) {
            base.Channel.UploadVideo(s);
        }
        
        public System.IO.Stream GetVideo() {
            return base.Channel.GetVideo();
        }
    }
}
