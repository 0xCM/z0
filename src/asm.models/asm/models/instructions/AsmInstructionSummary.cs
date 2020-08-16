//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Describes an assembly instruction
    /// </summary>
    public readonly struct AsmInstructionSummary
    {
        /// <summary>
        /// The base address
        /// </summary>
        public readonly MemoryAddress Base;
        
        /// <summary>
        /// The zero-based offset of the function, relative to the base address
        /// </summary>
        public readonly ushort Offset {get;}

        /// <summary>
        /// The instruction content, suitable for display
        /// </summary>
        public readonly string Formatted {get;}
        
        /// <summary>
        /// The instruction string paired with the op code
        /// </summary>
        public readonly AsmFxCode Spec {get;}

        /// <summary>
        /// Describes the instruction operands
        /// </summary>
        public readonly AsmOperandInfo[] Operands {get;}

        /// <summary>
        /// The encoded bytes
        /// </summary>
        public readonly byte[] Encoded {get;}        
        
        [MethodImpl(Inline)]
        public static AsmInstructionSummary Define(MemoryAddress @base, ushort offset, string content, 
            AsmFxCode spec, AsmOperandInfo[] operands, byte[] encoded)
                => new AsmInstructionSummary(@base, offset, content, spec, operands, encoded);
        
        [MethodImpl(Inline)]
        public AsmInstructionSummary(MemoryAddress @base, ushort offset, string content, AsmFxCode spec, AsmOperandInfo[] operands, byte[] encoded)
        {
            Base = @base;
            Offset = offset;
            Formatted = content;
            Operands = operands;
            Encoded = encoded;
            Spec = spec;
        }
        

    }
}