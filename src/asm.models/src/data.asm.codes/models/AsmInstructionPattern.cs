//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Represents an expression that identifies an instruction
    /// </summary>
    /// <remarks>
    /// Instruction expressions are of the form
    /// 0 operands: {Mnemonic}
    /// 1 operand: {Mnemonic}{ }{op1}
    /// 2 operands: {Mnemonic}{ }{op1}{,}{op2}
    /// 3 operands: {Mnemonic}{ }{op1}{,}{op2},{op3}
    /// Example: PCMPISTRI xmm1, xmm2/m128, imm8
    /// <remarks>
    public readonly struct AsmInstructionPattern : ITextual
    {
        public readonly asci64 Value;

        [MethodImpl(Inline)]
        public static implicit operator TextExpression(AsmInstructionPattern src)
            => new TextExpression(src.Value.Format());

        [MethodImpl(Inline)]
        public static implicit operator AsmInstructionPattern(string src)
            => new AsmInstructionPattern(src);

        [MethodImpl(Inline)]
        public AsmInstructionPattern(string src)
            => Value = src;

        [MethodImpl(Inline)]
        public AsmInstructionPattern(in asci64 src)
            => Value = src;

        /// <summary>
        /// The expression length
        /// </summary>
        public int Length
        {
            [MethodImpl(Inline)]
            get => Value.Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Value.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Value.IsNonEmpty;
        }

        public ReadOnlySpan<byte> Encoded
        {
            [MethodImpl(Inline)]
            get => asci.bytes(Value);
        }

        public ReadOnlySpan<char> Decoded
        {
            [MethodImpl(Inline)]
            get => asci.decode(Value);
        }

        public AsmInstructionPattern Zero
            => Empty;

        [MethodImpl(Inline)]
        public bool Equals(AsmInstructionPattern src)
             => src.Value.Equals(Value);

        public override bool Equals(object src)
            => src is AsmInstructionPattern x && Equals(x);

        public override int GetHashCode()
            => Value.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Value.Format();

        public override string ToString()
            => Format();

        public static AsmInstructionPattern Empty
            => new AsmInstructionPattern(EmptyString);
    }
}