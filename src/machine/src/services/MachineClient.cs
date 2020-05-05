//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct MachineClient : IMachineClient<IMachineBroker>
    {
        public IMachineBroker Broker {get;}

        public IAppMsgSink Sink {get;}

        [MethodImpl(Inline)]
        public static IMachineClient Create(IMachineBroker broker, IAppMsgSink sink, bool connect = true)
            => new MachineClient(broker, sink,connect);

        [MethodImpl(Inline)]
        public MachineClient(IMachineBroker broker, IAppMsgSink sink, bool connect)
        {
            Broker = broker;
            Sink = sink;
            if(connect)
                ((IMachineClient)this).Connect();
        }
    }    
}