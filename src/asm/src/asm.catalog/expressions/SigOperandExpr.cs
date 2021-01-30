//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents an operand in the context of a <see cref='AsmSigExpr'/>
    /// </summary>
    public readonly struct SigOperandExpr : ITextExpr<SigOperandExpr>
    {
        public readonly asci16 Content {get;}

        [MethodImpl(Inline)]
        public SigOperandExpr(string src)
            => Content = src;

        [MethodImpl(Inline)]
        public SigOperandExpr(in asci16 src)
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
        public bool Equals(SigOperandExpr src)
            => src.Content.Equals(Content);

        public override bool Equals(object src)
            => src is SigOperandExpr x && Equals(x);

        public override int GetHashCode()
            => Content.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator SigOperandExpr(string src)
            => new SigOperandExpr(src);

        [MethodImpl(Inline)]
        public static implicit operator SigOperandExpr(asci16 src)
            => new SigOperandExpr(src);

        public static SigOperandExpr Empty
            => new SigOperandExpr(EmptyString);
    }
}