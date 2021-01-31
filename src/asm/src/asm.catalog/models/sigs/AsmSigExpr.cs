//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /* Examples:
    ADD AL, imm8
    ADD AX, imm16
    ADD EAX, imm32
    ADD RAX, imm32
    ADD r/m8, imm8
    ADD r/m8, imm8
    ADD r/m16, imm16
    ADD r/m32, imm32
    ADD r/m64, imm32
    ADD r/m16, imm8
    ADD r/m32, imm8
    ADD r/m64, imm8
    ADD r/m8, r8
    ADD r/m8, r8
    ADD r/m16, r16
    ADD r/m32, r32
    ADD r/m64, r64
    ADD r8, r/m8
    ADD r8, r/m8
    ADD r16, r/m16
    ADD r32, r/m32
    ADD r64, r/m64
    */

    /// <summary>
    /// Represents an expression that identifies an instruction
    /// </summary>
    /// <remarks>
    /// Instruction signatures are of the form
    /// 0 operands: {Mnemonic}
    /// 1 operand: {Mnemonic}{ }{op1}
    /// 2 operands: {Mnemonic}{ }{op1}{,}{op2}
    /// 3 operands: {Mnemonic}{ }{op1}{,}{op2},{op3}
    /// Example: PCMPISTRI xmm1, xmm2/m128, imm8
    /// <remarks>
    public readonly struct AsmSigExpr : ITextExpr<AsmSigExpr>
    {
        public asci64 Content {get;}

        [MethodImpl(Inline)]
        public AsmSigExpr(string src)
            => Content = src;

        [MethodImpl(Inline)]
        public AsmSigExpr(in asci64 src)
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
        public bool Equals(AsmSigExpr src)
             => src.Content.Equals(Content);

        public override bool Equals(object src)
            => src is AsmSigExpr x && Equals(x);

        public override int GetHashCode()
            => Content.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Content.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator TextBlock(AsmSigExpr src)
            => new TextBlock(src.Content.Format());

        [MethodImpl(Inline)]
        public static implicit operator AsmSigExpr(string src)
            => new AsmSigExpr(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmSigExpr(asci64 src)
            => new AsmSigExpr(src);

        public static AsmSigExpr Empty
            => new AsmSigExpr(EmptyString);
    }
}