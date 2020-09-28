//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct COFFFileHeader
    {
        public MachineId Machine;

        public short NumberOfSections;

        public int TimeDateStamp;

        public int PointerToSymbolTable;

        public int NumberOfSymbols;

        public short SizeOfOptionalHeader;

        public CharacteristicKind Characteristics;
    }
}