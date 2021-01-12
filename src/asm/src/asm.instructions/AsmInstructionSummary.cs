//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Describes an assembly instruction
    /// </summary>
    public readonly struct AsmInstructionSummary
    {
        /// <summary>
        /// The encoded bytes
        /// </summary>
        public readonly CodeBlock Encoded;

        /// <summary>
        /// The zero-based offset of the function, relative to the base address
        /// </summary>
        public readonly uint Offset;

        /// <summary>
        /// The instruction content, suitable for display
        /// </summary>
        public readonly string Formatted;

        /// <summary>
        /// The instruction string paired with the op code
        /// </summary>
        public readonly AsmSpecifier Spec;

        /// <summary>
        /// Describes the instruction operands
        /// </summary>
        public readonly AsmOperandInfo[] Operands;

        [MethodImpl(Inline)]
        public AsmInstructionSummary(MemoryAddress @base, uint offset, string content, AsmSpecifier spec, AsmOperandInfo[] operands, byte[] encoded)
        {
            Encoded = new CodeBlock(@base, encoded);
            Offset = offset;
            Formatted = content;
            Operands = operands;
            Spec = spec;
        }
    }
}