//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DebugClient.DatagramClient {
    
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="DebugClient.DatagramClient", ConfigurationName="IDatagramService")]
public interface IDatagramService {
    
    // CODEGEN: Generating message contract since the wrapper namespace (http://tempuri.org/) of message ProcessDatagram does not match the default value (DebugClient.DatagramClient)
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDatagramService/ProcessDatagram")]
    void ProcessDatagram(ProcessDatagram request);
    
    [System.ServiceModel.OperationContractAttribute(IsOneWay=true, AsyncPattern=true, Action="http://tempuri.org/IDatagramService/ProcessDatagram")]
    System.IAsyncResult BeginProcessDatagram(ProcessDatagram request, System.AsyncCallback callback, object asyncState);
    
    void EndProcessDatagram(System.IAsyncResult result);
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
[System.ServiceModel.MessageContractAttribute(WrapperName="ProcessDatagram", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
public partial class ProcessDatagram {
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
    public V37ZEN.Datagram.Datagram datagram;
    
    public ProcessDatagram() {
    }
    
    public ProcessDatagram(V37ZEN.Datagram.Datagram datagram) {
        this.datagram = datagram;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IDatagramServiceChannel : IDatagramService, System.ServiceModel.IClientChannel {
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class DatagramServiceClient : System.ServiceModel.ClientBase<IDatagramService>, IDatagramService {
    
    public DatagramServiceClient() {
    }
    
    public DatagramServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName) {
    }
    
    public DatagramServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress) {
    }
    
    public DatagramServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress) {
    }
    
    public DatagramServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress) {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    void IDatagramService.ProcessDatagram(ProcessDatagram request) {
        base.Channel.ProcessDatagram(request);
    }
    
    public void ProcessDatagram(V37ZEN.Datagram.Datagram datagram) {
        ProcessDatagram inValue = new ProcessDatagram();
        inValue.datagram = datagram;
        ((IDatagramService)(this)).ProcessDatagram(inValue);
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    System.IAsyncResult IDatagramService.BeginProcessDatagram(ProcessDatagram request, System.AsyncCallback callback, object asyncState) {
        return base.Channel.BeginProcessDatagram(request, callback, asyncState);
    }
    
    public System.IAsyncResult BeginProcessDatagram(V37ZEN.Datagram.Datagram datagram, System.AsyncCallback callback, object asyncState) {
        ProcessDatagram inValue = new ProcessDatagram();
        inValue.datagram = datagram;
        return ((IDatagramService)(this)).BeginProcessDatagram(inValue, callback, asyncState);
    }
    
    public void EndProcessDatagram(System.IAsyncResult result) {
        base.Channel.EndProcessDatagram(result);
    }
}
namespace V37ZEN.Datagram {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Datagram", Namespace="http://schemas.datacontract.org/2004/07/V37ZEN.Datagram")]
    public partial class Datagram : object, System.Runtime.Serialization.IExtensibleDataObject {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string MessageField;
        
        private string MetadataField;
        
        private System.DateTime TimestampField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                this.MessageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Metadata {
            get {
                return this.MetadataField;
            }
            set {
                this.MetadataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Timestamp {
            get {
                return this.TimestampField;
            }
            set {
                this.TimestampField = value;
            }
        }
    }
}
