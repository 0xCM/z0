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
    public readonly struct AsmSigExpr : ITextExpr<AsmSigExpr>, IComparable<AsmSigExpr>
    {
        readonly TextBlock Data;

        public AsmMnemonic Mnemonic {get;}

        public Index<AsmSigOperandExpr> Operands {get;}

        [MethodImpl(Inline)]
        public AsmSigExpr(AsmMnemonic monic, AsmSigOperandExpr[] operands, TextBlock formatted)
            : this()
        {
            Mnemonic = monic;
            Operands = operands;
            Data = formatted;
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
            => new AsmSigExpr(AsmMnemonic.Empty, sys.empty<AsmSigOperandExpr>(), TextBlock.Empty);
    }
}