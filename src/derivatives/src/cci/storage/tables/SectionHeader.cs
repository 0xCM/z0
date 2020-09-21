//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct SectionHeader
    {
        public string Name;

        public uint VirtualSize;

        public uint VirtualAddress;

        public uint SizeOfRawData;

        public uint OffsetToRawData;

        public uint RVAToRelocations;

        public uint PointerToLineNumbers;

        public ushort NumberOfRelocations;

        public ushort NumberOfLineNumbers;

        public SectionCharacteristics SectionCharacteristics;
    }
}