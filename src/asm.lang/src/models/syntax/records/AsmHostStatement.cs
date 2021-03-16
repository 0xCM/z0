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
    public struct AsmHostStatement : IRecord<AsmHostStatement>, IComparable<AsmHostStatement>
    {
        public const string TableId = "asm.host-statements";

        public Address16 Offset;

        public AsmStatementExpr Expression;

		public AsmSigExpr Sig;

        public AsmOpCodeExpr OpCode;

        public AsmHexCode Encoded;

        public MemoryAddress BaseAddress;

        public MemoryAddress IP;

        public OpUri OpUri;

        [MethodImpl(Inline)]
        public int CompareTo(AsmHostStatement src)
            => IP.CompareTo(src.IP);

        public AsmThumbprint Thumbprint()
            => new AsmThumbprint(Expression, Sig, OpCode, Encoded);
    }
}