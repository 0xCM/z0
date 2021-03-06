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
    public struct AsmHostStatement : IRecord<AsmHostStatement>, IComparable<AsmHostStatement>
    {
        public const string TableId = "asm.statements";

        public const byte FieldCount = 9;

        public MemoryAddress BlockAddress;

        public MemoryAddress IP;

        public Address16 BlockOffset;

        public AsmExpr Expression;

        public AsmHexCode Encoded;

		public AsmSigExpr Sig;

        public AsmOpCodeExpr OpCode;

        public AsmBitstring Bitstring;

        public OpUri OpUri;

        public bool IsValid()
            => Expression.IsValid;

        [MethodImpl(Inline)]
        public int CompareTo(AsmHostStatement src)
            => IP.CompareTo(src.IP);

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{16,16,16,64,32,64,32,128,80};
    }
}