//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static Root;

    readonly struct ExtractControl : IExtractControl
    {                    
        public IAsmContext Context {get;}
        
        readonly AsmCaptureEventObserver Observer;

        [MethodImpl(Inline)]
        public static IExtractControl New(IAsmContext context, AsmCaptureEventObserver observer)
            => new ExtractControl(context,observer);
                    
        [MethodImpl(Inline)]
        ExtractControl(IAsmContext context, AsmCaptureEventObserver observer)
        {
            this.Context = context;
            this.Observer = observer;
        }

        [MethodImpl(Inline)]
        public CapturedOp Capture(in OpExtractExchange exchange, in OpIdentity id, in DynamicDelegate src)
            => Context.Capture().Capture(exchange, id, src);

        [MethodImpl(Inline)]
        public CapturedOp Capture(in OpExtractExchange exchange, in OpIdentity id, Delegate src)
            => Context.Capture().Capture(exchange, id,src);

        [MethodImpl(Inline)]
        public CapturedOp Capture(in OpExtractExchange exchange, in OpIdentity id, MethodInfo src)
            => Context.Capture().Capture(exchange, id, src);                                    

        [MethodImpl(Inline)]
        public Option<ParsedBuffer> ParseBuffer(in OpExtractExchange exchange, in OpIdentity id, Span<byte> src)
            => Context.Capture().ParseBuffer(exchange, id, src);

        [MethodImpl(Inline)]
        public CapturedOp Capture(in OpExtractExchange exchange, MethodInfo src, params Type[] args)
            => Context.Capture().Capture(exchange, src, args);

        [MethodImpl(Inline)]
        void IExtractJunction.OnCaptureStep(in OpExtractExchange exchange, in ExtractionState state)
            => Observer(AsmCaptureEvent.Define(state, exchange.StateBuffer));

        [MethodImpl(Inline)]
        void IExtractJunction.OnCaptureComplete(in OpExtractExchange exchange, in ExtractionState state, in CapturedOp captured)
            => Observer(AsmCaptureEvent.Define(state, exchange.StateBuffer, captured));

    }
}