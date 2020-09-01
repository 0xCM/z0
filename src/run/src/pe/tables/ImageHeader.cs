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

    partial struct ImageTables
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        [Table("https://docs.microsoft.com/en-us/windows/win32/api/winnt/ns-winnt-image_file_header")]
        public struct ImageHeader
        {
            /// <summary>
            /// The architecture type of the computer. An image file can only be run on the specified computer or a system that emulates the specified computer.
            /// </summary>
            public MachineKind Machine;

            /// <summary>
            /// The number of sections. This indicates the size of the section table, which immediately follows the headers. Note that the Windows loader limits the number of sections to 96.
            /// </summary>
            public ushort NumberOfSections;

            /// <summary>
            /// The low 32 bits of the time stamp of the image. This represents the date and time the image was created by the linker. The value is represented in the number of seconds elapsed since midnight (00:00:00), January 1, 1970, Universal Coordinated Time, according to the system clock.
            /// </summary>
            public uint TimeDateStamp;

            /// <summary>
            /// The offset of the symbol table, in bytes, or zero if no COFF symbol table exists.
            /// </summary>
            public uint PointerToSymbolTable;

            /// <summary>
            /// The number of symbols in the symbol table.
            /// </summary>
            public uint NumberOfSymbols;

            /// <summary>
            /// The size of the optional header, in bytes. This value should be 0 for object files.
            /// </summary>
            public ushort SizeOfOptionalHeader;

            /// <summary>
            /// The characteristics of the image.
            /// </summary>
            public AspectType Characteristics;
        }
    }
}