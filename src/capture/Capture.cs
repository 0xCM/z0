//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Capture
    {
        public static ICaptureServices Services
            => default(CaptureServices);

        [MethodImpl(Inline)]
        internal static IAsmCaptureFormatter formatter(in AsmFormatSpec config)
            => new AsmCaptureFormatter(config);

        [MethodImpl(Inline)]
        public static CaptureExchange exchange(IAsmContext context)
            => new CaptureExchange(context.CaptureCore, new byte[context.DefaultBufferLength]);

        [MethodImpl(Inline)]
        public static CaptureExchange exchange(IAsmContext context, Span<byte> buffer)
            => new CaptureExchange(context.CaptureCore, buffer);

        public static AsmDecoderProxy DefaultDecoder
        {
             [MethodImpl(Inline)]
             get => AsmDecoderProxy.Service;
        }
    }
}