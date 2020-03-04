//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static Root;

    readonly struct AsmExtractControl : IAsmExtractControl
    {                    
        public IAsmContext Context {get;}
        
        readonly AsmCaptureEventObserver Observer;

        [MethodImpl(Inline)]
        public static IAsmExtractControl Create(IAsmContext context, AsmCaptureEventObserver observer)
            => new AsmExtractControl(context,observer);
                    
        [MethodImpl(Inline)]
        AsmExtractControl(IAsmContext context, AsmCaptureEventObserver observer)
        {
            this.Context = context;
            this.Observer = observer;
        }

        [MethodImpl(Inline)]
        public AsmOpExtract Extract(in AsmCaptureExchange exchange, in OpIdentity id, in DynamicDelegate src)
            => Context.OpExtractor().Extract(exchange, id, src);

        [MethodImpl(Inline)]
        public AsmOpExtract Extract(in AsmCaptureExchange exchange, in OpIdentity id, Delegate src)
            => Context.OpExtractor().Extract(exchange, id,src);

        [MethodImpl(Inline)]
        public AsmOpExtract Extract(in AsmCaptureExchange exchange, in OpIdentity id, MethodInfo src)
            => Context.OpExtractor().Extract(exchange, id, src);                                    

        [MethodImpl(Inline)]
        public Option<CapturedData> Extract(in AsmCaptureExchange exchange, in OpIdentity id, Span<byte> src)
            => Context.OpExtractor().Extract(exchange, id, src);

        [MethodImpl(Inline)]
        public AsmOpExtract Extract(in AsmCaptureExchange exchange, MethodInfo src, params Type[] args)
            => Context.OpExtractor().Extract(exchange, src, args);

        [MethodImpl(Inline)]
        void IAsmCaptureJunction.OnCaptureStep(in AsmCaptureExchange exchange, in AsmCaptureState state)
            => Observer(AsmCaptureEvent.Define(state, exchange.StateBuffer));

        [MethodImpl(Inline)]
        void IAsmCaptureJunction.OnCaptureComplete(in AsmCaptureExchange exchange, in AsmCaptureState state, in AsmOpExtract captured)
            => Observer(AsmCaptureEvent.Define(state, exchange.StateBuffer, captured));

    }
}