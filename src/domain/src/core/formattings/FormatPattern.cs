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
    public readonly struct FormatPattern
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

        public override string ToString()
            => Content;

        [MethodImpl(Inline)]
        public static implicit operator FormatPattern(string src)
            => new FormatPattern(src);
    }
}