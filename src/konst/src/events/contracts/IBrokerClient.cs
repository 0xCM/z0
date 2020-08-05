//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IBrokerClient<E>
    {
        IAppMsgSink Sink {get;}
 
        E Broker {get;}        
    }
}