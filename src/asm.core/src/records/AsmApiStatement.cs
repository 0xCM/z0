//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using Z0.Asm;

    using static Root;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct AsmApiStatement : IRecord<AsmApiStatement>, IComparable<AsmApiStatement>
    {
        public const string TableId = "asm.statements";

        public const byte FieldCount = 8;

        public MemoryAddress BlockAddress;

        public MemoryAddress IP;

        public Address16 BlockOffset;

        public AsmStatementExpr Expression;

        public AsmHexCode Encoded;

		public AsmSigExpr Sig;

        public AsmOpCodeExpr OpCode;

        public OpUri OpUri;

        [MethodImpl(Inline)]
        public int CompareTo(AsmApiStatement src)
            => IP.CompareTo(src.IP);

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{16,16,16,40,32,32,32,80};
    }
}