//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmExpr;

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
    public readonly struct AsmSig : ITextExpr<AsmSig>, IComparable<AsmSig>
    {
        readonly TextBlock Data;

        public AsmMnemonic Mnemonic {get;}

        public Index<AsmSigOperand> Operands {get;}

        [MethodImpl(Inline)]
        public AsmSig(AsmMnemonic monic, params AsmSigOperand[] operands)
            : this()
        {
            Mnemonic = monic;
            Operands = operands;
            Data = AsmSigs.format(this);
        }

        public string Content
        {
            [MethodImpl(Inline)]
            get => Data.Text;
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
        public bool Equals(AsmSig src)
            => Data.Equals(src.Data);

        public override bool Equals(object src)
            => src is AsmSig x && Equals(x);

        public int CompareTo(AsmSig src)
            => Data.CompareTo(src.Data);

        [MethodImpl(Inline)]
        public static implicit operator TextBlock(AsmSig src)
            => new TextBlock(src.Content);

        [MethodImpl(Inline)]
        public static bool operator ==(AsmSig a, AsmSig b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(AsmSig a, AsmSig b)
            => !a.Equals(b);

        public static AsmSig Empty
            => new AsmSig(AsmMnemonic.Empty);
    }
}