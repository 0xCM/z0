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
    public struct AsmApiStatement : IRecord<AsmApiStatement>, IComparable<AsmApiStatement>
    {
        public const string TableId = "asm.statements";

        public const byte FieldCount = 8;

        public Address16 BlockOffset;

        public AsmStatementExpr Expression;

		public AsmSigExpr Sig;

        public AsmOpCodeExpr OpCode;

        public AsmHexCode Encoded;

        public MemoryAddress BaseAddress;

        public MemoryAddress IP;

        public OpUri OpUri;

        [MethodImpl(Inline)]
        public int CompareTo(AsmApiStatement src)
            => IP.CompareTo(src.IP);

        public AsmThumbprintExpr Thumbprint()
            => AsmThumbprints.expression(Sig, OpCode, Encoded);

        public AsmStatementSummary Summary()
            => asm.summary(BaseAddress, BlockOffset, Expression, Thumbprint());
    }
}