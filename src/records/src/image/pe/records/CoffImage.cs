//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    partial struct Pe
    {
        /// <summary>
        /// At the beginning of an object file, or immediately after the signature of an image file,
        /// is a standard COFF file header in the following format. Note that the Windows loader limits
        /// the number of sections to 96.
        /// </summary>
        [Record(CoffHeaderSchema, CoffHeaderInfo), StructLayout(LayoutKind.Sequential)]
        public struct CoffHeader
        {
            public MachineType Machine;

            public short NumberOfSections;

            public int TimeDateStamp;

            public int PointerToSymbolTable;

            public int NumberOfSymbols;

            public short SizeOfOptionalHeader;

            public Characteristics Characteristics;
        }

        const string CoffHeaderSchema = "[0:2],[2:2],[4:4],[8:4],[12:4],[16:2],[18:2]";

        const string CoffHeaderInfo = @"
            | Offset | Size | Field | Description |
            | 0 | 2 | Machine | The number that identifies the type of target machine. For more information, see Machine Types . |
            | 2 | 2 | NumberOfSections | The number of sections. This indicates the size of the section table, which immediately follows the headers. |
            | 4 | 4 | TimeDateStamp | The low 32 bits of the number of seconds since 00:00 January 1, 1970 (a C run-time time_t value), which indicates when the file was created. |
            | 8 | 4 | PointerToSymbolTable | The file offset of the COFF symbol table, or zero if no COFF symbol table is present. This value should be zero for an image because COFF debugging information is deprecated. |
            | 12 | 4 | NumberOfSymbols | The number of entries in the symbol table. This data can be used to locate the string table, which immediately follows the symbol table. This value should be zero for an image because COFF debugging information is deprecated. |
            | 16 | 2 | SizeOfOptionalHeader | The size of the optional header, which is required for executable files but not for object files. This value should be zero for an object file. For a description of the header format, see Optional Header (Image Only) . |
            | 18 | 2 | Characteristics | The flags that indicate the attributes of the file. For specific flag values, see Characteristics . |";
    }
}