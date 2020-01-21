//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Describes an assembly instruction
    /// </summary>
    public class AsmInstructionInfo
    {
        public static AsmInstructionInfo Define(ushort offset, string content, AsmInstructionSpec spec, AsmOperandInfo[] operands, byte[] encoded)
            => new AsmInstructionInfo(offset, content, spec, operands, encoded);
        
        AsmInstructionInfo(ushort offset, string content, AsmInstructionSpec spec, AsmOperandInfo[] operands, byte[] encoded)
        {
            this.Offset = offset;
            this.AsmContent = content;
            this.Operands = operands;
            this.Encoded = encoded;
            this.Spec = spec;
        }
        
        /// <summary>
        /// The zero-based offset of the function, relative to the function address
        /// </summary>
        public ushort Offset {get;}

        /// <summary>
        /// The instruction content, suitable for display
        /// </summary>
        public string AsmContent {get;}
        
        /// <summary>
        /// The instruction string paired with the op code
        /// </summary>
        public AsmInstructionSpec Spec {get;}

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