//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public class AsmEncodingInfo : IEquatable<AsmEncodingInfo>, IComparable<AsmEncodingInfo>
    {
        public AsmStatementExpr Statement {get;}

		public AsmSigExpr Sig {get;}

        public AsmOpCodeExpr OpCode {get;}

        public AsmHexCode Encoded {get;}

        readonly MemoryAddress Bits;

        readonly string Formatted;

        readonly uint Length;

        [MethodImpl(Inline)]
        public AsmEncodingInfo(AsmStatementExpr statement, AsmSigExpr sig, AsmOpCodeExpr opcode, AsmHexCode hex, string bits)
        {
            Statement = statement;
            Sig = sig;
            OpCode = opcode;
            Encoded = hex;
            Formatted = bits;
            Bits = memory.address(string.Intern(bits));
            Length = (uint)bits.Length;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Formatted;

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