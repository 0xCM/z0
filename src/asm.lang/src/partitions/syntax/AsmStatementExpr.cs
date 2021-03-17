//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmStatementExpr : IEquatable<AsmStatementExpr>
    {
        public TextBlock Content {get;}

        [MethodImpl(Inline)]
        public AsmStatementExpr(TextBlock content)
            => Content = content;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();

        [MethodImpl(Inline)]
        public bool Equals(AsmStatementExpr src)
            => Content.Equals(src.Content);

        public override int GetHashCode()
            => Content.GetHashCode();

        public override bool Equals(object src)
            => src is AsmStatementExpr x && Equals(x);

        public int CompareTo(AsmStatementExpr src)
            => Content.CompareTo(src.Content);

        [MethodImpl(Inline)]
        public static implicit operator AsmStatementExpr(string src)
            => new AsmStatementExpr(src);

        public static AsmStatementExpr Empty
        {
            [MethodImpl(Inline)]
            get => new AsmStatementExpr(TextBlock.Empty);
        }
    }
}