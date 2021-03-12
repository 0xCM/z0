//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Record(TableId)]
    public struct AsmStatementInfo : IRecord<AsmStatementInfo>, IComparable<AsmStatementInfo>
    {
        public const string TableId = "asm.statements";

        public const byte FieldCount = 9;

        public uint Sequence;

        public MemoryAddress BlockAddress;

        public MemoryAddress IP;

        public Address32 GlobalOffset;

        public Address16 LocalOffset;

        public AsmOpCodeExpr OpCode;

		public AsmSig Sig;

        public AsmStatementExpr Expression;

        public AsmHexCode Encoded;

        public AsmMnemonic Mnemonic
        {
            [MethodImpl(Inline)]
            get => Sig.Mnemonic;
        }

        [MethodImpl(Inline)]
        public int CompareTo(AsmStatementInfo src)
            => IP.CompareTo(src.IP);
    }
}