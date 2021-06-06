//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmSigOperandExpr : ITextExpr<AsmSigOperandExpr>
    {
        readonly TextBlock Data;

        [MethodImpl(Inline)]
        public AsmSigOperandExpr(string src)
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
        public bool Equals(AsmSigOperandExpr src)
            => Data.Equals(src.Data);

        public override bool Equals(object src)
            => src is AsmSigOperandExpr x && Equals(x);

        [MethodImpl(Inline)]
        public static implicit operator AsmSigOperandExpr(string src)
            => new AsmSigOperandExpr(src);

        public static AsmSigOperandExpr Empty
            => new AsmSigOperandExpr(EmptyString);
    }
}