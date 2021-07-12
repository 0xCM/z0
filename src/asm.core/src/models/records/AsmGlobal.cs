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
    public struct AsmGlobal : IRecord<AsmGlobal>, IComparable<AsmGlobal>
    {
        public const string TableId = "asm.global";

        public const byte FieldCount = 11;

        public const ushort RowPad = 680;

        /// <summary>
        /// A 0-based monotonic value that serves as a surrogate key
        /// </summary>
        public uint Sequence;

        /// <summary>
        /// A 0-based 32-bit offset
        /// </summary>
        public Address32 GlobalOffset;

        /// <summary>
        /// The IP block address
        /// </summary>
        public MemoryAddress BlockAddress;

        /// <summary>
        /// The IP address
        /// </summary>
        public MemoryAddress IP;

        /// <summary>
        /// The block-relative IP offset
        /// </summary>
        public Address16 BlockOffset;

        public AsmExpr Statement;

        public AsmHexCode Encoded;

		public AsmSigExpr Sig;

        public AsmOpCodeExpr OpCode;

        public AsmBitstring Bitstring;

        public OpUri OpUri;

        [MethodImpl(Inline)]
        public int CompareTo(AsmGlobal src)
            => IP.CompareTo(src.IP);

        public override int GetHashCode()
            => (int)Sequence;

        [MethodImpl(Inline)]
        public AsmGlobalRef GetRef()
        {
            var dst = new AsmGlobalRef();
            dst.Sequence = Sequence;
            dst.GlobalOffset = GlobalOffset;
            dst.BlockAddress = BlockAddress;
            dst.IP = IP;
            dst.BlockOffset = BlockOffset;
            return dst;
        }

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{12,16,16,16,16,42,32,42,32,128,80};
    }
}