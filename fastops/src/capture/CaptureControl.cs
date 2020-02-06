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

        ICaptureEventSink ControlSink
        {
            [MethodImpl(Inline)]
            get => this;
        }

        public static CaptureControl Create(ICaptureEventSink sink)
            => new CaptureControl(sink);

        public static CaptureControl Create()
            => new CaptureControl(null);

        CaptureControl(ICaptureEventSink sink)
        {
            this.EventSink = sink ?? CaptureEventSink.Empty;
            this.Service = CaptureServices.Capture();
        }

        [MethodImpl(Inline)]
        public void Accept(in CaptureState src, in CaptureExchange exchange)
        {
            ControlSink.Accept(CaptureEventInfo.Define(src, exchange.StateBuffer));
        }

        public CapturedMember RunCapture(MethodInfo method, in CaptureExchange exchange)
        {            
            return Service.Capture(method.Identify(), method, exchange);                                    
        }

        [MethodImpl(Inline)]
        public void Accept(in CaptureEventInfo info)
        {

            EventSink.Accept(info);
        }


        readonly struct CaptureEventSink : ICaptureEventSink
        {
            public static ICaptureEventSink Empty = default(CaptureEventSink);
            
            public void Accept(in CaptureEventInfo info) {}
        }

    }
}