//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SymExpr : ITextual
    {
        readonly string Content;

        [MethodImpl(Inline)]
        public SymExpr(string content)
            => Content = content ?? EmptyString;

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        [MethodImpl(Inline)]
        public override string ToString()
            => Format();

        public static implicit operator SymExpr(string src)
            => new SymExpr(src);
    }
}