//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    partial struct AsmExpr
    {
        public sealed class SignatureLookup : Dictionary<string,Signature>
        {
            public static SignatureLookup create()
                => new SignatureLookup();

            [MethodImpl(Inline)]
            public void AddIfMissing(Signature src)
                => TryAdd(src.Format(), src);
        }

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
        public readonly struct Signature : ITextExpr<Signature>, IComparable<Signature>
        {
            readonly TextBlock Data;

            public AsmMnemonic Mnemonic {get;}

            public Index<SigOperand> Operands {get;}

            [MethodImpl(Inline)]
            public Signature(AsmMnemonic monic, params SigOperand[] operands)
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
            public bool Equals(Signature src)
                => Data.Equals(src.Data);

            public override bool Equals(object src)
                => src is Signature x && Equals(x);

            public int CompareTo(Signature src)
                => Data.CompareTo(src.Data);

            [MethodImpl(Inline)]
            public static implicit operator TextBlock(Signature src)
                => new TextBlock(src.Content);

            [MethodImpl(Inline)]
            public static bool operator ==(Signature a, Signature b)
                => a.Equals(b);

            [MethodImpl(Inline)]
            public static bool operator !=(Signature a, Signature b)
                => !a.Equals(b);

            public static Signature Empty
                => new Signature(AsmMnemonic.Empty);
        }
    }
}