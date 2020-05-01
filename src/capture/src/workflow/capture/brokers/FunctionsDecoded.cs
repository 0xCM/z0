//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static CaptureWorkflowEvents;

    public interface IFunctionsDecodedBroker : IEventBroker
    {
        FunctionsDecoded FunctionsDecoded => FunctionsDecoded.Empty;
    }

    public interface IFunctionsDecodedClient<C> : IBrokerClient<C>
        where C : IFunctionsDecodedBroker
    {
        void OnEvent(FunctionsDecoded e) 
            => Sink.Deposit(e);
    }
}