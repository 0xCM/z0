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
        public CodeBlock Encoded {get;}

        /// <summary>
        /// The zero-based offset of the function, relative to the base address
        /// </summary>
        public uint Offset {get;}

        /// <summary>
        /// The instruction content, suitable for display
        /// </summary>
        public string Formatted {get;}

        /// <summary>
        /// The instruction string paired with the op code
        /// </summary>
        public AsmInstructionSpecExprLegacy Spec {get;}

        /// <summary>
        /// Describes the instruction operands
        /// </summary>
        public IceOperandInfo[] Operands {get;}

        [MethodImpl(Inline)]
        public AsmInstructionSummary(MemoryAddress @base, uint offset, string content, AsmInstructionSpecExprLegacy spec, IceOperandInfo[] operands, byte[] encoded)
        {
            Encoded = new CodeBlock(@base, encoded);
            Offset = offset;
            Formatted = content;
            Operands = operands;
            Spec = spec;
        }
    }
}