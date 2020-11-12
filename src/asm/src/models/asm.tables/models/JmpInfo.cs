//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using Z0.Asm;

    using static Konst;
    using static z;

    [Table(TableId, FieldCount), StructLayout(LayoutKind.Sequential)]
    public struct JmpInfo
    {
        public const string TableId = "asm.jumps";

        public const byte FieldCount = 7;

        public MemoryAddress Base;

        public MemoryAddress Source;

        public ByteSize InstructionSize;

        public MemoryAddress CallSite;

        public MemoryAddress Target;

        public JccKind Kind;

        public string Asm;
    }
}