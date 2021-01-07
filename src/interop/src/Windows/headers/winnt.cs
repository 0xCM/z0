//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Windows
{
    using System;
    using System.Runtime.CompilerServices;

    using static Z0.root;

    public readonly partial struct winnt
    {
        public struct WORD
        {
            ushort Value;

            [MethodImpl(Inline)]
            public WORD(ushort value)
                => Value = value;

            [MethodImpl(Inline)]
            public static implicit operator WORD(ushort src)
                => new WORD(src);

            [MethodImpl(Inline)]
            public static implicit operator ushort(WORD src)
                => src.Value;
        }

        public struct DWORD
        {
            uint Value;

            [MethodImpl(Inline)]
            public DWORD(uint value)
                => Value = value;

            [MethodImpl(Inline)]
            public static implicit operator DWORD(uint src)
                => new DWORD(src);

            [MethodImpl(Inline)]
            public static implicit operator uint(DWORD src)
                => src.Value;
        }

        public struct LONG
        {
            int Value;

            [MethodImpl(Inline)]
            public LONG(int value)
                => Value = value;

            [MethodImpl(Inline)]
            public static implicit operator LONG(int src)
                => new LONG(src);

            [MethodImpl(Inline)]
            public static implicit operator int(LONG src)
                => src.Value;
        }

        // DOS .EXE header
        public struct IMAGE_DOS_HEADER
        {
            public WORD   e_magic;                     // Magic number

            public WORD   e_cblp;                      // Bytes on last page of file

            public WORD   e_cp;                        // Pages in file

            public WORD   e_crlc;                      // Relocations

            public WORD   e_cparhdr;                   // Size of header in paragraphs

            public WORD   e_minalloc;                  // Minimum extra paragraphs needed

            public WORD   e_maxalloc;                  // Maximum extra paragraphs needed

            public WORD   e_ss;                        // Initial (relative) SS value

            public WORD   e_sp;                        // Initial SP value

            public WORD   e_csum;                      // Checksum

            public WORD   e_ip;                        // Initial IP value

            public WORD   e_cs;                        // Initial (relative) CS value

            public WORD   e_lfarlc;                    // File address of relocation table

            public WORD   e_ovno;                      // Overlay number

            //WORD   e_res[4];                    // Reserved words

            public WORD   e_oemid;                     // OEM identifier (for e_oeminfo)

            public WORD   e_oeminfo;                   // OEM information; e_oemid specific

            //WORD   e_res2[10];                  // Reserved words
            public LONG   e_lfanew;                    // File address of new exe header
        }

        public unsafe struct PIMAGE_DOS_HEADER
        {
            readonly IMAGE_DOS_HEADER* P;

            [MethodImpl(Inline)]
            public PIMAGE_DOS_HEADER(IMAGE_DOS_HEADER* p)
                => P = p;

            [MethodImpl(Inline)]
            public static implicit operator PIMAGE_DOS_HEADER(IMAGE_DOS_HEADER* src)
                => new PIMAGE_DOS_HEADER(src);

            [MethodImpl(Inline)]
            public static implicit operator IMAGE_DOS_HEADER*(PIMAGE_DOS_HEADER src)
                => src.P;
        }
    }
}