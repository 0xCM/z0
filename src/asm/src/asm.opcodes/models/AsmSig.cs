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
    public readonly struct AsmSig : ITextual
    {
        public readonly asci64 Value;

        [MethodImpl(Inline)]
        public AsmSig(string src)
            => Value = src;

        [MethodImpl(Inline)]
        public AsmSig(in asci64 src)
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

        // public AsmMnemonic Mnemonic
        // {
        //     get => asci.i
        // }

        public AsmSig Zero
            => Empty;

        [MethodImpl(Inline)]
        public bool Equals(AsmSig src)
             => src.Value.Equals(Value);

        public override bool Equals(object src)
            => src is AsmSig x && Equals(x);

        public override int GetHashCode()
            => Value.GetHashCode();

        [MethodImpl(Inline)]
        public string Format()
            => Value.Format();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator TextBlock(AsmSig src)
            => new TextBlock(src.Value.Format());

        [MethodImpl(Inline)]
        public static implicit operator AsmSig(string src)
            => new AsmSig(src);

        public static AsmSig Empty
            => new AsmSig(EmptyString);
    }
}