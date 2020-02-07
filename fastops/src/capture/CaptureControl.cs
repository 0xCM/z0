//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    readonly struct CaptureControl : ICaptureControl
    {
        readonly ICaptureService Service;
                    
        readonly ICaptureEventSink EventSink;

        public static CaptureControl Create(ICaptureEventSink sink)
            => new CaptureControl(sink);

        public static CaptureControl Create()
            => new CaptureControl(null);

        public CapturedMember Capture(OpIdentity id, DynamicDelegate src, in CaptureExchange exchange)
            => Service.Capture(id,src,exchange);

        public CapturedMember Capture(OpIdentity id, Delegate src, in CaptureExchange exchange)
            => Service.Capture(id,src,exchange);

        public CapturedMember Capture(OpIdentity id, MethodInfo method, in CaptureExchange exchange)
            => Service.Capture(id, method, exchange);                                    

        CaptureControl(ICaptureEventSink sink)
        {
            this.EventSink = sink ?? CaptureEventSink.Empty;
            this.Service = CaptureServices.Capture();
        }

        ICaptureEventSink ControlSink
        {
            [MethodImpl(Inline)]
            get => this;
        }

        [MethodImpl(Inline)]
        void ICaptureJunction.Accept(in CaptureState src, in CaptureExchange exchange)
            => ControlSink.Accept(CaptureEventInfo.Define(src, exchange.StateBuffer));

        [MethodImpl(Inline)]
        void ICaptureEventSink.Accept(in CaptureEventInfo info)
            => EventSink.Accept(info);

        [MethodImpl(Inline)]
        public void Complete(in CapturedMember captured, in CaptureExchange exchange)
            => EventSink.Complete(captured);

        readonly struct CaptureEventSink : ICaptureEventSink
        {
            public static ICaptureEventSink Empty = default(CaptureEventSink);
            
            public void Accept(in CaptureEventInfo info) {}
        }
    }
}