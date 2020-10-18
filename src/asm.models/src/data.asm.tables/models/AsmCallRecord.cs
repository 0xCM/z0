//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential), Table(TableId, FieldCount)]
    public struct AsmCallRecord
    {
        public const string TableId = "asm.calls";

        public const byte FieldCount = 5;

        public const string RenderPattern = "| {0,-16} | {1,-16} | {2,-16} | {3,-16} | {4}";

        public MemoryAddress Source;

        public MemoryAddress Target;

        public ByteSize InstructionSize;

        public MemoryAddress TargetOffset;

        public BinaryCode Encoded;

        [MethodImpl(Inline)]
        public static string format(in AsmCallRecord src)
            => string.Format(AsmCallRecord.RenderPattern, src.Source, src.Target, src.InstructionSize, src.TargetOffset, src.Encoded);

        [MethodImpl(Inline)]
        public static string header()
            => string.Format(RenderPattern, nameof(Source), nameof(Target), nameof(InstructionSize), nameof(TargetOffset), nameof(Encoded));
    }
}