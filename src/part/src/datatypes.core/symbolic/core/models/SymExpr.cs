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

        public override int GetHashCode()
            => Content.GetHashCode();

        public bool Equals(SymExpr src)
            => Content.Equals(src.Content);

        public override bool Equals(object src)
            => src is SymExpr e && Equals(e);

        public static implicit operator SymExpr(string src)
            => new SymExpr(src);

        public static bool operator ==(SymExpr a, SymExpr b)
            => a.Equals(b);

        public static bool operator !=(SymExpr a, SymExpr b)
            => !a.Equals(b);

        public static SymExpr Empty
        {
            [MethodImpl(Inline)]
            get => new SymExpr(EmptyString);
        }
    }
}