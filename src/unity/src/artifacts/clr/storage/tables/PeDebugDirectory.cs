//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Konst;

    partial struct ClrStorage
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct PeDebugDirectory
        {
            public uint Characteristics;

            public uint TimeDateStamp;

            public ushort MajorVersion;

            public ushort MinorVersion;

            public uint Type;

            public uint SizeOfData;

            public uint AddressOfRawData;

            public uint PointerToRawData;
        }
    }
}