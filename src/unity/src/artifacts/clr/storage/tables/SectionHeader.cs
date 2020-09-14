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
        public struct SectionHeader
        {
            public string Name;

            public ByteSize VirtualSize;

            public Address32 VirtualAddress;

            public ByteSize SizeOfRawData;

            public Address32 OffsetToRawData;

            public Address32 RVAToRelocations;

            public Address32 PointerToLineNumbers;

            public ushort NumberOfRelocations;

            public ushort NumberOfLineNumbers;

            public SectionCharacteristics SectionCharacteristics;
        }

    }
}