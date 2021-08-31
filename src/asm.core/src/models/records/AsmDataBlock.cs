//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1, Size=(int)SZ), Blittable(SZ)]
    public struct AsmDataBlock
    {
        public const uint SZ =
            2*PrimalSizes.U32 +
            2*MemoryAddress.SZ +
            Address16.StorageSize +
            ByteBlock64.Size +
            ByteBlock16.Size +
            ByteBlock64.Size +
            ByteBlock32.Size +
            2*ByteBlock128.Size;

        public uint GlobalIndex;

        public uint BlockIndex;

        public MemoryAddress BlockAddress;

        public MemoryAddress IP;

        public Address16 BlockOffset;

        public ByteBlock64 Expression;

        public ByteBlock16 Encoded;

		public ByteBlock64 Sig;

        public ByteBlock32 OpCode;

        public ByteBlock128 Bitstring;

        public ByteBlock128 OpUri;
    }
}