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
    public struct AsmIndex : IRecord<AsmIndex>, IComparable<AsmIndex>
    {
        public const string TableId = "asm.index";

        public const byte FieldCount = 11;

        public const ushort RowPad = 680;

        public uint Sequence;

        public Address32 GlobalOffset;

        public MemoryAddress BlockAddress;

        public MemoryAddress IP;

        public Address16 BlockOffset;

        public AsmExpr Statement;

        public AsmHexCode Encoded;

		public AsmSigExpr Sig;

        public AsmOpCodeExpr OpCode;

        public AsmBitstring Bitstring;

        public OpUri OpUri;

        [MethodImpl(Inline)]
        public int CompareTo(AsmIndex src)
            => IP.CompareTo(src.IP);

        public override int GetHashCode()
            => (int)Sequence;

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{12,16,16,16,16,42,32,42,32,128,80};
    }
}