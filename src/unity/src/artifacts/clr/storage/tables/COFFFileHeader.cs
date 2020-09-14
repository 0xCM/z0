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
        public struct COFFFileHeader
        {
            public Machine Machine;

            public short NumberOfSections;

            public int TimeDateStamp;

            public int PointerToSymbolTable;

            public int NumberOfSymbols;

            public short SizeOfOptionalHeader;

            public Characteristics Characteristics;
        }

    }

}