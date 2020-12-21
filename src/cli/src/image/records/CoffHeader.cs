//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Images
{
    using System;
    using System.Runtime.InteropServices;

    /// <summary>
    /// At the beginning of an object file, or immediately after the signature of an image file,
    /// is a standard COFF file header in the following format. Note that the Windows loader limits
    /// the number of sections to 96.
    /// </summary>
    [Record, StructLayout(LayoutKind.Sequential)]
    public struct CoffHeader : IRecord<CoffHeader>
    {
        public MachineType Machine;

        public short NumberOfSections;

        public int TimeDateStamp;

        public int PointerToSymbolTable;

        public int NumberOfSymbols;

        public short SizeOfOptionalHeader;

        public Characteristics Characteristics;
    }
}