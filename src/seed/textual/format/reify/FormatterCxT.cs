//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.CompilerServices;

    using static Konst;

    readonly struct Formatter<C,T> : IFormatter<C,T>
        where C : struct
    {
        readonly FormatRender<C,T> Render;

        [MethodImpl(Inline)]
        public Formatter(FormatRender<C,T> render)
            => Render = render;

        [MethodImpl(Inline)]
        public string Format(T src, in C config)
            => Render(src,config);        
    }
}