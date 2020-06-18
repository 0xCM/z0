//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static CaptureWorkflowEvents;

    public interface IHexSavedBroker : IEventBroker
    {
        HexSaved HexSaved => HexSaved.Empty;        
    }

    public interface IHexSavedClient<C> : IBrokerClient<C>
        where C : IHexSavedBroker
    {
        void OnEvent(HexSaved e) 
            => Sink.Deposit(e);
    }
}