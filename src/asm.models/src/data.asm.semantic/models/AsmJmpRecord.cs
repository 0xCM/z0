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
    public struct AsmJmpRecord
    {
        public const string TableId = "asm.jumps";

        public const string RenderPattern = "| {0,-16} | {1,-16} | {2,-16} | {3,-16} | {4,-16} | {5,-16:g} | {6,-32}";

        public const byte FieldCount = 7;

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{16,16,16,16,16,16,32};

        public MemoryAddress Base;

        public MemoryAddress Source;

        public ByteSize InstructionSize;

        public MemoryAddress CallSite;

        public MemoryAddress Target;

        public JmpKind Kind;

        public string Asm;
    }
}