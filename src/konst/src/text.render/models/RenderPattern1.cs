//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct RenderPattern<T> : IRenderPattern<RenderPattern<T>,T>
    {
        readonly RenderPattern Pattern;

        [MethodImpl(Inline)]
        public static implicit operator RenderPattern<T>(string src)
            => new RenderPattern<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator RenderPattern<T>(RenderPattern src)
            => new RenderPattern<T>(src);

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
        public string Apply(in T src)
            => text.format(PatternText, src);
    }
}