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
        public AsmMnemonic Mnemonic {get;}

        public TextBlock Content {get;}

        public AsmSigExpr(AsmMnemonic mnemonic, TextBlock content)
        {
            Mnemonic = mnemonic;
            Content = content;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Content.Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Content.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Content.IsNonEmpty;
        }


        public override int GetHashCode()
            => Content.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(AsmSigExpr src)
            => Content.Equals(src.Content);

        public override bool Equals(object src)
            => src is AsmSigExpr x && Equals(x);

        public int CompareTo(AsmSigExpr src)
            => Content.CompareTo(src.Content);

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