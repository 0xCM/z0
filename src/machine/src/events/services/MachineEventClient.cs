//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct MachineEventClient : IMachineEventClient
    {        
        [MethodImpl(Inline)]
        public MachineEventClient(IEventBroker broker, IAppMsgSink sink)
        {
            this.Broker = broker;
            this.Sink = sink;
        }
        
        public IEventBroker Broker {get;}

        public IAppMsgSink Sink {get;}        
    }
}