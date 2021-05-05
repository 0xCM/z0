//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    using Z0.Asm;

    partial struct AsmRecords
    {

    }

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct AsmApiStatement : IRecord<AsmApiStatement>, IComparable<AsmApiStatement>
    {
        public const string TableId = "asm.statements";

        public const byte FieldCount = 8;

        public MemoryAddress BaseAddress;

        public MemoryAddress IP;

        public Address16 BlockOffset;

        public AsmStatementExpr Expression;

		public AsmSigExpr Sig;

        public AsmOpCodeExpr OpCode;

        public AsmHexCode Encoded;

        public OpUri OpUri;

        [MethodImpl(Inline)]
        public int CompareTo(AsmApiStatement src)
            => IP.CompareTo(src.IP);
    }
}