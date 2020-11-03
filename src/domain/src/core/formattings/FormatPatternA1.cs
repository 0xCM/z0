//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Captures an untyped format pattern
    /// </summary>
    public readonly struct FormatPattern<A0,A1>
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
        public string Format(A0 a0, A1 a1)
            => string.Format(Content, a0, a1);

        public override string ToString()
            => Content;

        [MethodImpl(Inline)]
        public static implicit operator FormatPattern<A0,A1>(string src)
            => new FormatPattern<A0,A1>(src);
    }
}