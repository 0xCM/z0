//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    public enum NasmOutFileIndex : byte
    {
        bin = 0,

        ith = 1,

        srec = 2,

        aout = 3,

        coff = 4,

        elf32 = 5,

        elf64 = 6,

        elfx32 = 7,

        as86 = 8,

        obj = 9,

        win32 = 10,

        win64 = 11,

        ieee = 12,

        macho32 = 13,

        macho64 = 14,

        dbg = 15,
    }
}