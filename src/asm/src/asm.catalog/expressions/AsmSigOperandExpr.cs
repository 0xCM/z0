//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmSigOperandExpr : ITextExpr<AsmSigOperandExpr>
    {
        public readonly asci16 Content {get;}

        [MethodImpl(Inline)]
        public AsmSigOperandExpr(string src)
            => Content = src;

        [MethodImpl(Inline)]
        public AsmSigOperandExpr(in asci16 src)
            => Content = src;

        /// <summary>
        /// The expression length
        /// </summary>
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

        public ReadOnlySpan<byte> Encoded
        {
            [MethodImpl(Inline)]
            get => Asci.bytes(Content);
        }

        public ReadOnlySpan<char> Decoded
        {
            [MethodImpl(Inline)]
            get => Asci.decode(Content);
        }

        public TextBlock Text
        {
            [MethodImpl(Inline)]
            get => Content.Text;
        }

        [MethodImpl(Inline)]
        public bool Equals(AsmSigOperandExpr src)
             => src.Content.Equals(Content);

        public override bool Equals(object src)
            => src is AsmSigOperandExpr x && Equals(x);

        public override int GetHashCode()
            => Content.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmSigOperandExpr(string src)
            => new AsmSigOperandExpr(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmSigOperandExpr(asci16 src)
            => new AsmSigOperandExpr(src);

        public static AsmSigOperandExpr Empty
            => new AsmSigOperandExpr(EmptyString);
    }
}