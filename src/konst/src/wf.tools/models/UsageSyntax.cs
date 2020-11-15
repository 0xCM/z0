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

    [DataType]
    public readonly struct UsageSyntax : ITextual, IContented<string>
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public UsageSyntax(string content)
        {
            Content = content;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator UsageSyntax(string src)
            => new UsageSyntax(src);
    }
}