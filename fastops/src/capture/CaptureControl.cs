//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    readonly struct CaptureControl : ICaptureControl
    {                    
        readonly ICaptureEventSink EventSink;

        public static CaptureControl Create(ICaptureEventSink sink)
            => new CaptureControl(sink);

        public static CaptureControl Create()
            => new CaptureControl(null);

        CaptureControl(ICaptureEventSink sink)
        {
            this.EventSink = sink ?? CaptureEventSink.Empty;
        }

        ICaptureOps Operations
            => CaptureServices.Operations;

        [MethodImpl(Inline)]
        public CapturedMember Capture(in CaptureExchange exchange, in OpIdentity id, in DynamicDelegate src)
            => Operations.Capture(exchange,id, src);

        [MethodImpl(Inline)]
        public CapturedMember Capture(in CaptureExchange exchange, in OpIdentity id, Delegate src)
            => Operations.Capture(exchange, id,src);

        [MethodImpl(Inline)]
        public CapturedMember Capture(in CaptureExchange exchange, in OpIdentity id, MethodInfo src)
            => Operations.Capture(exchange, id, src);                                    

        [MethodImpl(Inline)]
        public Option<CapturedOpData> Capture(in CaptureExchange exchange, in OpIdentity id, Span<byte> src)
            => Operations.Capture(exchange, id, src);

        ICaptureEventSink ControlSink
        {
            [MethodImpl(Inline)]
            get => this;
        }

        [MethodImpl(Inline)]
        void ICaptureJunction.Accept(in CaptureExchange exchange, in CaptureState src)
            => ControlSink.Accept(CaptureEventInfo.Define(src, exchange.StateBuffer));

        [MethodImpl(Inline)]
        void ICaptureEventSink.Accept(in CaptureEventInfo info)
            => EventSink.Accept(info);

        [MethodImpl(Inline)]
        public void Complete(in CaptureExchange exchange, in CapturedMember captured)
            => EventSink.Complete(captured);

        readonly struct CaptureEventSink : ICaptureEventSink
        {
            public static ICaptureEventSink Empty = default(CaptureEventSink);
            
            public void Accept(in CaptureEventInfo info) {}
        }
    }
}