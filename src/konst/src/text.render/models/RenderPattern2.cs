//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct RenderPattern<A0,A1> : IRenderPattern<RenderPattern<A0,A1>,A0,A1>
    {
        readonly RenderPattern Pattern;

        [MethodImpl(Inline)]
        public static implicit operator RenderPattern<A0,A1>(string src)
            => new RenderPattern<A0,A1>(src);

        [MethodImpl(Inline)]
        public static implicit operator RenderPattern<A0,A1>(RenderPattern src)
            => new RenderPattern<A0,A1>(src);

        [MethodImpl(Inline)]
        public RenderPattern(string src)
            => Pattern= src;

        [MethodImpl(Inline)]
        public RenderPattern(RenderPattern src)
            => Pattern= src;

        public string PatternText
        {
            [MethodImpl(Inline)]
            get => Pattern.PatternText;
        }

        [MethodImpl(Inline)]
        public string Apply(in A0 s0, in A1 s1)
            => text.format(PatternText, s0, s1);
    }
}