//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    readonly struct ExtractControl : IExtractControl
    {                    
        readonly IContext Context;

        readonly ICaptureService Service;
        
        readonly AsmCaptureEventObserver Observer;

        [MethodImpl(Inline)]
        public static IExtractControl New(IContext context, AsmCaptureEventObserver observer)
            => new ExtractControl(context,observer);
                    
        [MethodImpl(Inline)]
        ExtractControl(IContext context, AsmCaptureEventObserver observer)
        {
            this.Context = context;
            this.Observer = observer;
            this.Service = CaptureService.New(context);
        }

        [MethodImpl(Inline)]
        public Option<CapturedOp> Capture(in OpExtractExchange exchange, in OpIdentity id, in DynamicDelegate src)
            => Service.Capture(exchange, id, src);

        [MethodImpl(Inline)]
        public CapturedOp Capture(in OpExtractExchange exchange, in OpIdentity id, Delegate src)
            => Service.Capture(exchange, id,src);

        [MethodImpl(Inline)]
        public Option<CapturedOp> Capture(in OpExtractExchange exchange, in OpIdentity id, MethodInfo src)
            => Service.Capture(exchange, id, src);                                    

        [MethodImpl(Inline)]
        public Option<ParsedBuffer> ParseBuffer(in OpExtractExchange exchange, in OpIdentity id, Span<byte> src)
            => Service.ParseBuffer(exchange, id, src);

        [MethodImpl(Inline)]
        public Option<CapturedOp> Capture(in OpExtractExchange exchange, MethodInfo src, params Type[] args)
            => Service.Capture(exchange, src, args);

        [MethodImpl(Inline)]
        void IExtractJunction.OnCaptureStep(in OpExtractExchange exchange, in ExtractState state)
            => Observer(AsmCaptureEvent.Define(state, exchange.StateBuffer));

        [MethodImpl(Inline)]
        void IExtractJunction.OnCaptureComplete(in OpExtractExchange exchange, in ExtractState state, in CapturedOp captured)
            => Observer(AsmCaptureEvent.Define(state, exchange.StateBuffer, captured));

    }
}