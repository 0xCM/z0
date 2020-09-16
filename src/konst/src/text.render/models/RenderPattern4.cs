//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct RenderPattern<A0,A1,A2,A3>
    {
        readonly RenderPattern Pattern;

        [MethodImpl(Inline)]
        public static implicit operator RenderPattern<A0,A1,A2,A3>(string src)
            => new RenderPattern<A0,A1,A2,A3>(src);

        [MethodImpl(Inline)]
        public static implicit operator RenderPattern<A0,A1,A2,A3>(RenderPattern src)
            => new RenderPattern<A0,A1,A2,A3>(src);

        [MethodImpl(Inline)]
        public RenderPattern(string src)
            => Pattern = src;

        [MethodImpl(Inline)]
        public RenderPattern(RenderPattern src)
            => Pattern = src;

        public string PatternText
        {
            [MethodImpl(Inline)]
            get => Pattern.PatternText;
        }

        [MethodImpl(Inline)]
        public string Apply(in A0 a0, in A1 a1, in A2 a2, in A3 a3)
            => text.format(PatternText, a0, a1, a2, a3);
    }
}