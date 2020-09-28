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
    public struct PeImageHeader
    {
        public IMAGE_FILE_MACHINE Machine;

        public ushort NumberOfSections;

        public uint TimeDateStamp;

        public uint PointerToSymbolTable;

        public uint NumberOfSymbols;

        public ushort SizeOfOptionalHeader;

        public IMAGE_FILE Characteristics;

        public PeImageHeader(IMAGE_FILE_HEADER src)
        {
            Machine = src.Machine;
            NumberOfSections = src.NumberOfSections;
            TimeDateStamp = src.TimeDateStamp;
            NumberOfSymbols = src.NumberOfSymbols;
            PointerToSymbolTable = src.PointerToSymbolTable;
            SizeOfOptionalHeader = src.SizeOfOptionalHeader;
            Characteristics = (IMAGE_FILE)src.Characteristics;
        }
    }
}