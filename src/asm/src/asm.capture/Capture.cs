//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Capture
    {
        public static ICaptureServices Services
            => default(CaptureServices);

        [MethodImpl(Inline)]
        public static CaptureExchange exchange(IAsmContext context)
            => new CaptureExchange(context.CaptureCore, new byte[context.DefaultBufferLength]);
    }
}