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
        [MethodImpl(Inline)]
        public static AsmInstructionSummary Define(MemoryAddress @base, ushort offset, string content, 
            AsmInstructionCode spec, AsmOperandInfo[] operands, byte[] encoded)
                => new AsmInstructionSummary(@base, offset, content, spec, operands, encoded);
        
        [MethodImpl(Inline)]
        internal AsmInstructionSummary(MemoryAddress @base, ushort offset, string content, AsmInstructionCode spec, AsmOperandInfo[] operands, byte[] encoded)
        {
            Base = @base;
            Offset = offset;
            AsmContent = content;
            Operands = operands;
            Encoded = encoded;
            Spec = spec;
        }
        
        /// <summary>
        /// The base address
        /// </summary>
        public MemoryAddress Base {get;}
        
        /// <summary>
        /// The zero-based offset of the function, relative to the base address
        /// </summary>
        public ushort Offset {get;}

        /// <summary>
        /// The instruction content, suitable for display
        /// </summary>
        public string AsmContent {get;}
        
        /// <summary>
        /// The instruction string paired with the op code
        /// </summary>
        public AsmInstructionCode Spec {get;}

        /// <summary>
        /// Describes the instruction operands
        /// </summary>
        public AsmOperandInfo[] Operands {get;}

        /// <summary>
        /// The encoded bytes
        /// </summary>
        public byte[] Encoded {get;}
    }
}