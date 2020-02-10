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
    using static CaptureServices;

    readonly struct CaptureControl : ICaptureControl
    {                    
        readonly CaptureEventObserver Observer;

        public static ICaptureControl Create(CaptureEventObserver observer)
            => new CaptureControl(observer);
                    
        CaptureControl(CaptureEventObserver observer)
        {
            this.Observer = observer;
        }

        [MethodImpl(Inline)]
        public CapturedMember Capture(in CaptureExchange exchange, in OpIdentity id, in DynamicDelegate src)
            => Operations.Capture(exchange, id, src);

        [MethodImpl(Inline)]
        public CapturedMember Capture(in CaptureExchange exchange, in OpIdentity id, Delegate src)
            => Operations.Capture(exchange, id,src);

        [MethodImpl(Inline)]
        public CapturedMember Capture(in CaptureExchange exchange, in OpIdentity id, MethodInfo src)
            => Operations.Capture(exchange, id, src);                                    

        [MethodImpl(Inline)]
        public Option<CapturedData> Capture(in CaptureExchange exchange, in OpIdentity id, Span<byte> src)
            => Operations.Capture(exchange, id, src);

        [MethodImpl(Inline)]
        void ICaptureJunction.OnCaptureStep(in CaptureExchange exchange, in CaptureState state)
            => Observer(CaptureEventData.Define(state, exchange.StateBuffer));

        [MethodImpl(Inline)]
        void ICaptureJunction.OnCaptureComplete(in CaptureExchange exchange, in CaptureState state, in CapturedMember captured)
            => Observer(CaptureEventData.Define(state, exchange.StateBuffer, captured));
    }
}