//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CmdLinePart : ITextual
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public CmdLinePart(string content)
            => Content = content;

        public ReadOnlySpan<char> Chars
        {
            [MethodImpl(Inline)]
            get => memory.chars(Content);
        }

        public bool IsEmpty
        {
            get => text.empty(Content);
        }

        public bool IsNonEmpty
        {
            get => !text.empty(Content);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Content ?? EmptyString;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdLinePart(string src)
            => new CmdLinePart(src);

        [MethodImpl(Inline)]
        public static implicit operator string(CmdLinePart src)
            => src.Content;
    }
}