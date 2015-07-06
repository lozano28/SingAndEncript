using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.Net.Security;


namespace Service
{
    
    [ServiceContract(Namespace = "http://test.com/play",ProtectionLevel=ProtectionLevel.EncryptAndSign)]
    interface ISer
    {
        [OperationContract]
        getTimeResponse GetTime(GetTimeRequest IncomingMessage );

        [OperationContract]
        string DoSomething(string wow);
    }


    [MessageContract(IsWrapped=true)]
    public class GetTimeRequest
    {
        [MessageBodyMember]
        public string FirstName;

        [MessageBodyMember]
        public string LastName;

    }


    [MessageContract]
    public class getTimeResponse
    {
        [MessageBodyMember]
        public ReturnData getTimeResult;
    }


    [DataContract]
    public class ReturnData
    {
        [DataMember]
        public string Greeting;
    }

}
