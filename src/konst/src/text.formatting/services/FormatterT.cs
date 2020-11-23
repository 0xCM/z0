//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Formatter<T> : ITextFormatter<T>
    {
        readonly FormatFunctions.Format<T> Fx;

        [MethodImpl(Inline)]
        public Formatter(FormatFunctions.Format<T> render)
            => Fx = render;

        [MethodImpl(Inline)]
        public string Format(T src)
            => Fx(src);
    }
}