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

    [Record(TableId)]
    public struct AsmStatementInfo : IRecord<AsmStatementInfo>, IComparable<AsmStatementInfo>
    {
        public const string TableId = "asm.statements";

        public uint Sequence;

        public MemoryAddress BlockAddress;

        public MemoryAddress IP;

        public Address32 GlobalOffset;

        public Address16 LocalOffset;

        public OpCode OpCode;

		public Signature Sig;

        public Statement Statement;

        public AsmHexCode Encoded;

        [MethodImpl(Inline)]
        public int CompareTo(AsmStatementInfo src)
            => IP.CompareTo(src.IP);
    }
}