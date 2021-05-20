//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using Z0.Asm;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct AsmCallRow : IRecord<AsmCallRow>
    {
        public const string TableId = "asm.calls";

        public const byte FieldCount = 7;

        /// <summary>
        /// The block base address
        /// </summary>
        public MemoryAddress Block;

        /// <summary>
        /// The callsite IP
        /// </summary>
        public MemoryAddress Source;

        /// <summary>
        /// The destination address
        /// </summary>
        public MemoryAddress Target;

        /// <summary>
        /// The call instruction size
        /// </summary>
        public ByteSize InstructionSize;

        /// <summary>
        /// Target - (Source + InstructionSize)
        /// </summary>
        public MemoryAddress TargetOffset;

        /// <summary>
        /// The call statement
        /// </summary>
        public AsmStatementExpr Instruction;

        /// <summary>
        /// The statement encoding
        /// </summary>
        public BinaryCode Encoded;

        public static ReadOnlySpan<byte> RenderWidths
            => new byte[FieldCount]{16,16,16,16,16,36,16};
    }
}