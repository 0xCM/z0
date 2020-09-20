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

    using static Part;

    partial struct ClrStorage
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct OptionalHeaderNTAdditionalFields
        {
            public ulong ImageBase;

            public int SectionAlignment;

            public uint FileAlignment;

            public ushort MajorOperatingSystemVersion;

            public ushort MinorOperatingSystemVersion;

            public ushort MajorImageVersion;

            public ushort MinorImageVersion;

            public ushort MajorSubsystemVersion;

            public ushort MinorSubsystemVersion;

            public uint Win32VersionValue;

            public int SizeOfImage;

            public int SizeOfHeaders;

            public uint CheckSum;

            public Subsystem Subsystem;

            public DllCharacteristics DllCharacteristics;

            public ulong SizeOfStackReserve;

            public ulong SizeOfStackCommit;

            public ulong SizeOfHeapReserve;

            public ulong SizeOfHeapCommit;

            public uint LoaderFlags;

            public int NumberOfRvaAndSizes;
        }

    }
}