﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.5485
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Service
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReturnData", Namespace="http://schemas.datacontract.org/2004/07/Service")]
    public partial class ReturnData : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string GreetingField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Greeting
        {
            get
            {
                return this.GreetingField;
            }
            set
            {
                this.GreetingField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://test.com/play", ConfigurationName="ISer")]
public interface ISer
{
    
    // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de encapsulador (GetTimeRequest) del mensaje GetTimeRequest no coincide con el valor predeterminado (GetTime).
    [System.ServiceModel.OperationContractAttribute(Action="http://test.com/play/ISer/GetTime", ReplyAction="http://test.com/play/ISer/GetTimeResponse")]
    getTimeResponse GetTime(GetTimeRequest request);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://test.com/play/ISer/DoSomething", ReplyAction="http://test.com/play/ISer/DoSomethingResponse")]
    string DoSomething(string wow);
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetTimeRequest", WrapperNamespace="http://test.com/play", IsWrapped=true)]
public partial class GetTimeRequest
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://test.com/play", Order=0)]
    public string FirstName;
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://test.com/play", Order=1)]
    public string LastName;
    
    public GetTimeRequest()
    {
    }
    
    public GetTimeRequest(string FirstName, string LastName)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="getTimeResponse", WrapperNamespace="http://test.com/play", IsWrapped=true)]
public partial class getTimeResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://test.com/play", Order=0)]
    public Service.ReturnData getTimeResult;
    
    public getTimeResponse()
    {
    }
    
    public getTimeResponse(Service.ReturnData getTimeResult)
    {
        this.getTimeResult = getTimeResult;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface ISerChannel : ISer, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class SerClient : System.ServiceModel.ClientBase<ISer>, ISer
{
    
    public SerClient()
    {
    }
    
    public SerClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public SerClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public SerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public SerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    getTimeResponse ISer.GetTime(GetTimeRequest request)
    {
        return base.Channel.GetTime(request);
    }
    
    public Service.ReturnData GetTime(string FirstName, string LastName)
    {
        GetTimeRequest inValue = new GetTimeRequest();
        inValue.FirstName = FirstName;
        inValue.LastName = LastName;
        getTimeResponse retVal = ((ISer)(this)).GetTime(inValue);
        return retVal.getTimeResult;
    }
    
    public string DoSomething(string wow)
    {
        return base.Channel.DoSomething(wow);
    }
}
