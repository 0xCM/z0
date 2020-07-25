//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct PeFile
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct IMAGE_FILE_HEADER
        {
            public ushort Machine;
            
            public ushort NumberOfSections;
            
            public int TimeDateStamp;
            
            public uint PointerToSymbolTable;
            
            public uint NumberOfSymbols;
            
            public ushort SizeOfOptionalHeader;
            
            public ushort Characteristics;
        }
    }
}