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
        readonly ICaptureEventSink Observer;

        public static ICaptureControl Create()
            => new CaptureControl(CaptureEventSink.Empty);

        public static ICaptureControl Create(ICaptureEventSink observer)
            => new CaptureControl(observer);
                    
        CaptureControl(ICaptureEventSink observer)
        {
            this.Observer = observer;
        }

        [MethodImpl(Inline)]
        public CapturedMember Capture(in CaptureExchange exchange, in OpIdentity id, in DynamicDelegate src)
            => CaptureServices.Operations.Capture(exchange,id, src);

        [MethodImpl(Inline)]
        public CapturedMember Capture(in CaptureExchange exchange, in OpIdentity id, Delegate src)
            => CaptureServices.Operations.Capture(exchange, id,src);

        [MethodImpl(Inline)]
        public CapturedMember Capture(in CaptureExchange exchange, in OpIdentity id, MethodInfo src)
            => CaptureServices.Operations.Capture(exchange, id, src);                                    

        [MethodImpl(Inline)]
        public Option<CapturedData> Capture(in CaptureExchange exchange, in OpIdentity id, Span<byte> src)
            => CaptureServices.Operations.Capture(exchange, id, src);

        [MethodImpl(Inline)]
        void ForwardEvent(in CaptureEventData data)
        {
            Observer.Accept(data);
        }

        [MethodImpl(Inline)]
        void ForwardCompletion(in CaptureEventData data)
        {
            Observer.Complete(data);
        }

        /// <summary>
        /// Relays the completion event to the sink specified upon creation
        /// </summary>
        /// <param name="data">The event data</param>
        [MethodImpl(Inline)]
        void ICaptureEventSink.Complete(in CaptureEventData data)
            => ForwardCompletion(data);

        /// <summary>
        /// Relays the event to the sink specified upon creation
        /// </summary>
        /// <param name="data">The event data</param>
        [MethodImpl(Inline)]
        void ICaptureEventSink.Accept(in CaptureEventData data)
            => ForwardEvent(data);

        [MethodImpl(Inline)]
        void ICaptureJunction.Accept(in CaptureExchange exchange, in CaptureState state)
            => ForwardEvent(CaptureEventData.Define(state, exchange.StateBuffer));

        [MethodImpl(Inline)]
        void ICaptureJunction.Complete(in CaptureExchange exchange, in CaptureState state, in CapturedMember captured)
            => ForwardCompletion(CaptureEventData.Define(state, exchange.StateBuffer, captured));

        readonly struct CaptureEventSink : ICaptureEventSink
        {        
            public static ICaptureEventSink Empty = default(CaptureEventSink);
            
            public void Accept(in CaptureEventData data) {}

            public void Complete(in CaptureEventData data) {}

        }
    }
}