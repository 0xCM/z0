//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmSigOpExpr : ITextExpr<AsmSigOpExpr>
    {
        readonly TextBlock Data;

        [MethodImpl(Inline)]
        public AsmSigOpExpr(string src)
            => Data = src;

        public TextBlock Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsNonEmpty;
        }

        public override int GetHashCode()
            => Data.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Data.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(AsmSigOpExpr src)
            => Data.Equals(src.Data);

        public override bool Equals(object src)
            => src is AsmSigOpExpr x && Equals(x);

        [MethodImpl(Inline)]
        public static implicit operator AsmSigOpExpr(string src)
            => new AsmSigOpExpr(src);

        public static AsmSigOpExpr Empty
            => new AsmSigOpExpr(EmptyString);
    }
}