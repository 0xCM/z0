//-------------------------------------------------------------------------------------------
// OSS developed by Chris Moore and licensed via MIT: https://opensource.org/licenses/MIT
// This license grants rights to merge, copy, distribute, sell or otherwise do with it 
// as you like. But please, for the love of Zeus, don't clutter it with regions.
//-------------------------------------------------------------------------------------------
namespace Meta.Core.Messaging
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    using System.Collections.Concurrent;

    using static metacore;

    public abstract class MessageHub<M>  : IMessageHub<M>      
    {

        public abstract void RaiseEvent(M Message);

        public abstract CorrelationToken Connect();

        

    }

    public readonly struct ServiceHost
    {
        public ServiceHost(Type host, Uri uri)
        {


        }

        public void AddServiceEndpoint(Type channel, Binding binding, string exchange)
        {

        }

        public void Open()
        {
            
        }
    }

    public abstract class MessageHub<H, C, M> : MessageHub<M>
            where H : MessageHub<H, C, M>, IMessageHub<M>, new()
            where C : IMessageHub<M>

    {
        protected static ConcurrentDictionary<string, ServiceHost> Hosts { get; }
         = new ConcurrentDictionary<string, ServiceHost>();

        public static ServiceHost HostExchange(string ExchangeName)
                => Hosts.GetOrAdd(ExchangeName, name =>
                {
                    var host = new ServiceHost(typeof(H), new Uri("net.tcp://localhost"));
                    host.AddServiceEndpoint(typeof(C), new NetTcpBinding(), ExchangeName);
                    host.Open();
                    return host;
                });

    }


}