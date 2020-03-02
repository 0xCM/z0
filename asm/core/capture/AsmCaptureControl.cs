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

    readonly struct AsmCaptureControl : IAsmCaptureControl
    {                    
        public IAsmContext Context {get;}
        
        readonly AsmCaptureEventObserver Observer;

        [MethodImpl(Inline)]
        public static IAsmCaptureControl Create(IAsmContext context, AsmCaptureEventObserver observer)
            => new AsmCaptureControl(context,observer);
                    
        [MethodImpl(Inline)]
        AsmCaptureControl(IAsmContext context, AsmCaptureEventObserver observer)
        {
            this.Context = context;
            this.Observer = observer;
        }

        [MethodImpl(Inline)]
        public AsmMemberCapture Capture(in AsmCaptureExchange exchange, in OpIdentity id, in DynamicDelegate src)
            => Context.CaptureOps().Capture(exchange, id, src);

        [MethodImpl(Inline)]
        public AsmMemberCapture Capture(in AsmCaptureExchange exchange, in OpIdentity id, Delegate src)
            => Context.CaptureOps().Capture(exchange, id,src);

        [MethodImpl(Inline)]
        public AsmMemberCapture Capture(in AsmCaptureExchange exchange, in OpIdentity id, MethodInfo src)
            => Context.CaptureOps().Capture(exchange, id, src);                                    

        [MethodImpl(Inline)]
        public Option<CapturedData> Capture(in AsmCaptureExchange exchange, in OpIdentity id, Span<byte> src)
            => Context.CaptureOps().Capture(exchange, id, src);

        [MethodImpl(Inline)]
        void IAsmCaptureJunction.OnCaptureStep(in AsmCaptureExchange exchange, in CaptureState state)
            => Observer(AsmCaptureEvent.Define(state, exchange.StateBuffer));

        [MethodImpl(Inline)]
        void IAsmCaptureJunction.OnCaptureComplete(in AsmCaptureExchange exchange, in CaptureState state, in AsmMemberCapture captured)
            => Observer(AsmCaptureEvent.Define(state, exchange.StateBuffer, captured));
    }
}