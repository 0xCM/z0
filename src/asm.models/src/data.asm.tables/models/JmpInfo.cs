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

        public const string RenderPattern = "| {0,-16} | {1,-16} | {2,-16} | {3,-16} | {4,-16} | {5,-16:g} | {6,-32}";

        public const byte FieldCount = 7;

        public MemoryAddress Base;

        public MemoryAddress Source;

        public ByteSize InstructionSize;

        public MemoryAddress CallSite;

        public MemoryAddress Target;

        public JccKind Kind;

        public string Asm;

        public static string format(in JmpInfo jmp)
            => string.Format(RenderPattern, jmp.Base, jmp.Source, jmp.InstructionSize, jmp.CallSite, jmp.Target, jmp.Kind, jmp.Asm);

        public static string header()
            => string.Format(RenderPattern, nameof(Base), nameof(Source), nameof(InstructionSize), nameof(CallSite), nameof(Target), nameof(Kind), nameof(Asm));
    }
}