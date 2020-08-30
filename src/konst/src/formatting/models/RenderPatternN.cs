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
    /// Associates a natural number N with a string that ought to have N slots
    /// </summary>
    public readonly struct RenderPattern<N>
        where N : unmanaged, ITypeNat
    {
        public readonly string PatternText;

        [MethodImpl(Inline)]
        public static implicit operator RenderPattern<N>(string src)
            => new RenderPattern<N>(src);

        [MethodImpl(Inline)]
        public RenderPattern(string src)
        {
            PatternText = src;
        }
    }
}