using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Description;
using System.ServiceModel.Security;
using System.ServiceModel.Security.Tokens;

namespace Service
{
    class Service
    {
        static void Main(string[] args)
        {

            Console.Title = "Service";
            ServiceHost sh = new ServiceHost(typeof(MyImpl));

            sh.Open();

            Console.WriteLine("Endpoint Listeners:");
            Console.WriteLine("----------------");
            foreach (ChannelDispatcher cd in sh.ChannelDispatchers)
            {
                foreach (EndpointDispatcher epd in cd.Endpoints)
                {
                    Console.WriteLine(epd.EndpointAddress.Uri.AbsoluteUri);
                    ConsoleColor origCol = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    ServiceEndpoint sep = sh.Description.Endpoints.Find(epd.EndpointAddress.Uri);
                    if (sep != null)
                    {
                        BindingElementCollection bec = sep.Binding.CreateBindingElements();
                        foreach (BindingElement be in bec)
                        {
                            Console.WriteLine("\t" + be.GetType().ToString());
                        }
                    }


                    Console.ForegroundColor = origCol;
                    Console.WriteLine();
                }

            }

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }


    }
    
    


    class MyImpl : ISer
    {

        #region ISer Members

        public getTimeResponse GetTime(GetTimeRequest IncomingMessage )
        {
            ServiceSecurityContext ssc = OperationContext.Current.ServiceSecurityContext;
            Console.WriteLine(ssc.PrimaryIdentity.Name + Environment.NewLine + ssc.PrimaryIdentity.AuthenticationType);
            getTimeResponse ret = new getTimeResponse();
            ret.getTimeResult = new ReturnData();
            ret.getTimeResult.Greeting = "hi";
            return ret;
        }


        public string DoSomething(string wow)
        {
            return wow;
        }

        #endregion
    }
}
