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

    public static class CaptureExtensions
    {
        [MethodImpl(Inline)]
        public static CaptureExchange CreateExchange(this ICaptureControl control)
            => CaptureServices.Exchange(control);

        [MethodImpl(Inline)]
        public static CaptureExchange CreateExchange(this ICaptureControl control, Span<byte> target, Span<byte> state)
            => CaptureServices.Exchange(control, target, state);

    }

}