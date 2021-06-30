//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Pow2x32;

    [Flags]
    public enum ObjFileKind : uint
    {
        None = 0,

        [Symbol("bin", "Flat raw binary")]
        bin = P2ᐞ00,

        [Symbol("ith", "Intel Hex encoded flat binary")]
        ith = P2ᐞ01,

        [Symbol("srec", "Motorola S-records encoded flat binary")]
        srec = P2ᐞ02,

        [Symbol("aout")]
        aout = P2ᐞ03,

        [Symbol("coff")]
        coff = P2ᐞ04,

        [Symbol("elf32")]
        elf32 = P2ᐞ05,

        [Symbol("elf64")]
        elf64 = P2ᐞ06,

        [Symbol("elfx32")]
        elfx32 = P2ᐞ07,

        [Symbol("as86")]
        as86 = P2ᐞ08,

        [Symbol("obj")]
        obj = P2ᐞ09,

        [Symbol("win32", "Microsoft extended COFF for Win32 (i386)")]
        win32 = P2ᐞ10,

        [Symbol("win64", "Microsoft extended COFF for Win64 (x86-64)")]
        win64 = P2ᐞ11,

        [Symbol("ieee", "IEEE-695 (LADsoft variant) object file format")]
        ieee = P2ᐞ12,

        [Symbol("macho32")]
        macho32 = P2ᐞ13,

        [Symbol("macho64")]
        macho64 = P2ᐞ14,

        [Symbol("dbg")]
        dbg = P2ᐞ15,
    }

    public enum AsmBinIndex : byte
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