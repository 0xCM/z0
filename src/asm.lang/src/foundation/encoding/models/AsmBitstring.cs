//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmBitstring : IEquatable<AsmBitstring>, IComparable<AsmBitstring>
    {
        public AsmStatementExpr Statement {get;}

		public AsmSigExpr Sig {get;}

        public AsmOpCodeExpr OpCode {get;}

        public AsmHexCode Encoded {get;}

        readonly MemoryAddress Bits;

        readonly string Formatted;

        readonly uint Length {get;}

        [MethodImpl(Inline)]
        public AsmBitstring(AsmStatementExpr statement, AsmSigExpr sig, AsmOpCodeExpr opcode, AsmHexCode hex, string bits)
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

        public int CompareTo(AsmBitstring src)
            => Statement.CompareTo(src.Statement);

        public override int GetHashCode()
            => (int)Bits.Hash;

        [MethodImpl(Inline)]

        public bool Equals(AsmBitstring src)
            => Bits.Equals(src.Bits);

        public override bool Equals(object src)
            => src is AsmBitstring b && Equals(b);
    }
}