//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct RenderPattern : ITextual
    {
        readonly StringRef PatternRef;

        [MethodImpl(Inline)]
        public static implicit operator RenderPattern(string src)
            => new RenderPattern(src);

        [MethodImpl(Inline)]
        public RenderPattern(string src)
            => PatternRef = src;

        public string PatternText
        {
            [MethodImpl(Inline)]
            get => PatternRef;
        }
        public string Format()
            => PatternText;
    }
}