//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TokenExpr
    {
        public uint Id {get;}

        public string Content {get;}

        [MethodImpl(Inline)]
        public TokenExpr(uint id, string content)
        {
            Id = id;
            Content = content;
        }

        public string Format()
            => Content;

        public override string ToString()
            => Format();

    }
}