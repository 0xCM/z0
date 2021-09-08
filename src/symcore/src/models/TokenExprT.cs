//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TokenExpr<T>
        where T : unmanaged, ICharBlock<T>
    {
        [MethodImpl(Inline)]
        public TokenExpr(uint id, T src)
        {
            Content = src;
            Id = id;
        }

        public uint Id {get;}

        public T Content {get;}

        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        public static implicit operator TokenExpr(TokenExpr<T> src)
            => new TokenExpr(src.Id, src.Content.Format());
    }
}