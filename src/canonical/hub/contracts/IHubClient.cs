//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public interface IHubClient : IDataEventSink
    {
        EventHub Hub {get;}

        // void IDataEventSink.Deposit(IDataEvent e) 
        //     => Sink.Deposit(e);
        
        void Connect();
    }
}