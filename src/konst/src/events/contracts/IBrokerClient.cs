//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IBrokerClient
    {
        IAppMsgSink Sink {get;}
    }

    public interface IBrokerClient<E> : IBrokerClient
    {
        E Broker {get;}        
    }
}