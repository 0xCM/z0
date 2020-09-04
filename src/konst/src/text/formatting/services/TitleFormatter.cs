//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Provies a parametric title reification predicated on a render function
    /// </summary>
    public readonly struct TitleFormatter<T> : ITitleFormatter<T>
    {
        readonly FormatFunctions.FormatTitle<T> Fx;

        [MethodImpl(Inline)]
        public TitleFormatter(FormatFunctions.FormatTitle<T> render)
            => Fx = render;

        [MethodImpl(Inline)]
        public string FormatTitle(T src)
            => Fx(src);
    }
}