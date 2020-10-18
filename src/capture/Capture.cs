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
        internal static IAsmCaptureFormatter formatter(in AsmFormatConfig config)
            => new AsmCaptureFormatter(config);

        [MethodImpl(Inline)]
        public static CaptureExchange exchange(IAsmContext context)
            => new CaptureExchange(context.CaptureCore, new byte[context.DefaultBufferLength]);
    }
}