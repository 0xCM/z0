//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public class AsmEncodingInfo : IEquatable<AsmEncodingInfo>, IComparable<AsmEncodingInfo>
    {
        public AsmExpr Statement {get;}

		public AsmSigExpr Sig {get;}

        public AsmOpCodeExpr OpCode {get;}

        public AsmHexCode Encoded {get;}

        public AsmBitstring Bits {get;}

        [MethodImpl(Inline)]
        public AsmEncodingInfo(AsmExpr statement, AsmSigExpr sig, AsmOpCodeExpr opcode, AsmHexCode hex, AsmBitstring bits)
        {
            Statement = statement;
            Sig = sig;
            OpCode = opcode;
            Encoded = hex;
            Bits = bits;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Bits.Format();

        public int CompareTo(AsmEncodingInfo src)
            => Statement.CompareTo(src.Statement);

        public override int GetHashCode()
            => (int)Bits.Hash;

        [MethodImpl(Inline)]

        public bool Equals(AsmEncodingInfo src)
            => Bits.Equals(src.Bits);

        public override bool Equals(object src)
            => src is AsmEncodingInfo b && Equals(b);
    }
}