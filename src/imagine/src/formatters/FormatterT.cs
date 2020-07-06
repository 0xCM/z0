//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Formatter<T> : IFormatter<T>
    {
        readonly FormatRender<T> Render;

        [MethodImpl(Inline)]
        public Formatter(FormatRender<T> render)
            => Render = render;

        [MethodImpl(Inline)]
        public string Format(T src)
            => Render(src);
    }
}