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

        readonly ICaptureEventSink StateSink;


        public static ICaptureControl Create(ICaptureEventSink sink)
            => new CaptureControl(sink);
                    
        public static ICaptureControl Create(ICaptureEventSink events, ICaptureEventSink state)
            => new CaptureControl(events,state);

        public static ICaptureControl Create()
            => new CaptureControl(CaptureEventSink.Empty);


        CaptureControl(ICaptureEventSink events, ICaptureEventSink state)
        {
            this.EventSink = events;
            this.StateSink = state;
        }


        CaptureControl(ICaptureEventSink events)
        {
            this.EventSink = events;
            this.StateSink = CaptureStateSink.Create(EventSink);
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
            EventSink.Accept(data);
            StateSink.Accept(data);
        }

        [MethodImpl(Inline)]
        void ForwardCompletion(in CaptureEventData data)
        {
            EventSink.Complete(data);
            //StateSink.Complete(data);
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
            readonly Option<ICaptureEventSink> Relay;

            public static ICaptureEventSink Empty = default(CaptureEventSink);
            
            CaptureEventSink(ICaptureEventSink relay)
                => this.Relay = relay != null ? some(relay) : none<ICaptureEventSink>();

            [MethodImpl(Inline)]
            public void Accept(in CaptureEventData data) 
            {
                if(Relay.IsSome())
                    Relay.Value.Accept(data);
            }

            public void Complete(in CaptureEventData data) {}

            public static ICaptureEventSink WithRelay(ICaptureEventSink dst)
                => new CaptureEventSink(dst);
        }
    }
}