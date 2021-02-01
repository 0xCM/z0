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
        public TextBlock Content {get;}

        [MethodImpl(Inline)]
        public AsmSigExpr(string src)
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

        public TextBlock Text
        {
            [MethodImpl(Inline)]
            get => Content;
        }

        public string String
        {
            [MethodImpl(Inline)]
            get => Content.String;
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => Content.Hash;
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
        public static bool operator ==(AsmSigExpr a, AsmSigExpr b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsmSigExpr a, AsmSigExpr b)
            => !a.Equals(b);

        public static AsmSigExpr Empty
            => new AsmSigExpr(EmptyString);
    }
}