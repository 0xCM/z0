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
        /// <summary>
        /// The encoded statement
        /// </summary>
        public AsmExpr Statement {get;}

        /// <summary>
        /// The signature to which the statement conforms
        /// </summary>
		public AsmSigExpr Sig {get;}

        /// <summary>
        /// The op code that deterimines the encoding
        /// </summary>
        public AsmOpCodeExpr OpCode {get;}

        /// <summary>
        /// The encoded bytes
        /// </summary>
        public AsmHexCode Encoded {get;}

        /// <summary>
        /// The encoded data represented as a bitstring
        /// </summary>
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