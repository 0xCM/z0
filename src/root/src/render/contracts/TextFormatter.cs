//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TextFormatter<T> : ITextFormatter<T>
    {
        readonly Func<T,string> Fx;

        [MethodImpl(Inline)]
        public TextFormatter(Func<T,string> fx)
            => Fx = fx;

        [MethodImpl(Inline)]
        public string Format(T src)
            => Fx(src);
    }
}