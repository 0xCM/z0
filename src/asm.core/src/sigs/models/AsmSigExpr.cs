//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Represents an expression that identifies an instruction
    /// </summary>
    public readonly struct AsmSigExpr : ITextExpr<AsmSigExpr>, IComparable<AsmSigExpr>
    {
        readonly TextBlock Data;

        public AsmMnemonic Mnemonic {get;}

        public AsmSigExpr(AsmMnemonic mnemonic, TextBlock formatted)
        {
            Data = formatted;
            Mnemonic = mnemonic;
        }

        public AsmSigExpr(AsmMnemonic mnemonic)
        {
            Data = EmptyString;
            Mnemonic = mnemonic;
        }

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
            => Data;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(AsmSigExpr src)
            => Data.Equals(src.Data);

        public override bool Equals(object src)
            => src is AsmSigExpr x && Equals(x);

        public int CompareTo(AsmSigExpr src)
            => Data.CompareTo(src.Data);

        [MethodImpl(Inline)]
        public static implicit operator TextBlock(AsmSigExpr src)
            => new TextBlock(src.Content);

        [MethodImpl(Inline)]
        public static bool operator ==(AsmSigExpr a, AsmSigExpr b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsmSigExpr a, AsmSigExpr b)
            => !a.Equals(b);

        public static AsmSigExpr Empty
            => new AsmSigExpr(AsmMnemonic.Empty, TextBlock.Empty);
    }
}