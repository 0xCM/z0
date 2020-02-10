//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;        

    using static zfunc;

    public static class CaptureServices
    {
        public const int DefaultBufferLen = 1024*8;
        
        public static ICaptureOps Operations
        {
            [MethodImpl(Inline)]
            get => default(CaptureOps);
        }

        [MethodImpl(Inline)]
        public static ICaptureControl Control()
            => CaptureControl.Create();

        [MethodImpl(Inline)]
        public static ICaptureControl Control(ICaptureEventSink events)
            => CaptureControl.Create(events);

        [MethodImpl(Inline)]
        public static CaptureExchange Exchange(ICaptureControl control, Span<byte> target, Span<byte> state)
            => CaptureExchange.Define(control, target, state);

        [MethodImpl(Inline)]
        public static CaptureExchange Exchange(ICaptureControl control)
            => CaptureExchange.Define(control, new byte[CaptureServices.DefaultBufferLen], new byte[CaptureServices.DefaultBufferLen]);

        [MethodImpl(Inline)]
        public static CaptureExchange Exchange()
            => CaptureExchange.Define(Control(),new byte[CaptureServices.DefaultBufferLen], new byte[CaptureServices.DefaultBufferLen]);

        [MethodImpl(Inline)]
        public static ICaptureEventSink OnReceipt(OnCaptureReceipt observer)
            => CaptureReceiptSink.Create(observer);

        [MethodImpl(Inline)]
        public static ICaptureTokenSink EmissionSink(Action<CaptureTokenGroup> receiver)
            => CaptureTokenSink.Create(receiver);
    }
}