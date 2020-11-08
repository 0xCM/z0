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
        readonly string Content;

        [MethodImpl(Inline)]
        public RenderPattern(string src)
            => Content = src;

        public string PatternText
        {
            [MethodImpl(Inline)]
            get => Content;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Content);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(Content);
        }

        public string Apply(params object[] args)
            => string.Format(Content, args);
        public string Format()
            => PatternText;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator RenderPattern(string src)
            => new RenderPattern(src);
    }
}