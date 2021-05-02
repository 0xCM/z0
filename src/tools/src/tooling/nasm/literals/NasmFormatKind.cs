//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    public enum NasmFormatKind : byte
    {
        None = 0,

        [Symbol("bin")]
        Bin,

        [Symbol("ith")]
        IntelHex,

        [Symbol("srec")]
        Motorola,

        [Symbol("aout")]
        LinuxOut,

        [Symbol("coff")]
        Coff,

        [Symbol("elf32")]
        Elf32,

        [Symbol("elf64")]
        Elf64,

        [Symbol("obj")]
        Obj,

        [Symbol("win32")]
        Win32,

        [Symbol("win64")]
        Win64,

        [Symbol("dbg")]
        Debug,
    }
}