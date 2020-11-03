//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Captures an untyped format pattern
    /// </summary>
    public readonly struct FormatPattern<A0,A1,A2>
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public FormatPattern(string src)
            => Content = src;

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

        [MethodImpl(Inline)]
        public string Format(A0 a0, A1 a1, A2 a2)
            => string.Format(Content, a0, a1, a2);

        public override string ToString()
            => Content;

        [MethodImpl(Inline)]
        public static implicit operator FormatPattern<A0,A1,A2>(string src)
            => new FormatPattern<A0,A1,A2>(src);
    }
}