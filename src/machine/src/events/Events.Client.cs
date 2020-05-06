//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static MachineEvents;

    public interface IMachineClient<C> : IMachineEvents, IBrokerClient<C>
        where C : IEventBroker
    {
        void IMachineEvents.Connect()
        {
            Error.Subscribe(Broker,OnEvent);            
            LoadedReport.Subscribe(Broker,OnEvent);
            LoadedParseReport.Subscribe(Broker,OnEvent);
            IndexedCode.Subscribe(Broker,OnEvent);
            DecodedHost.Subscribe(Broker,OnEvent);
            DecodedIndex.Subscribe(Broker,OnEvent);
        }        
    }
}