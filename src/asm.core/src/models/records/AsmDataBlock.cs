//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct AsmDataBlock
    {
        public const byte FieldCount = 10;

        public uint Key;

        public MemoryAddress BlockAddress;

        public MemoryAddress IP;

        public Address16 BlockOffset;

        public CharBlock64 Expression;

        public ByteBlock16 Encoded;

		public CharBlock64 Sig;

        public CharBlock32 OpCode;

        public CharBlock128 Bitstring;

        public CharBlock128 OpUri;
    }
}