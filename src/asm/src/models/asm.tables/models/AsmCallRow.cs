//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Record(TableId)]
    public struct AsmCallRow : IRecord<AsmCallRow>
    {
        public const string TableId = "asm.calls";

        public const string RenderPattern = "| {0,-16} | {1,-16} | {2,-16} | {3,-16} | {4, -22} | {5}";

        public MemoryAddress Source;

        public MemoryAddress Target;

        public ByteSize InstructionSize;

        public MemoryAddress TargetOffset;

        public string Instruction;

        public BinaryCode Encoded;

        [MethodImpl(Inline)]
        public static string format(in AsmCallRow src)
            => string.Format(AsmCallRow.RenderPattern, src.Source, src.Target, src.InstructionSize, src.TargetOffset, src.Instruction, src.Encoded);

        [MethodImpl(Inline)]
        public static string header()
            => string.Format(RenderPattern, nameof(Source), nameof(Target), nameof(InstructionSize), nameof(TargetOffset), nameof(Instruction), nameof(Encoded));
    }
}