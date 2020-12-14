//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CmdLinePart : ITextual
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public CmdLinePart(string content)
        {
            Content = content;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Content;

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