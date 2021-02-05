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

    [ApiDeep]
    public readonly partial struct Msg
    {
        public static RenderPattern<OpIdentity> IoError => "I/O error during emission of {0} immediate closures";

        public static RenderPattern<OpIdentity> CaptureFailed => "{0} capture failed";

        public static RenderPattern<OpIdentity> DynamicMethodFailure => "{0} dynamic method creation failure";
    }
}