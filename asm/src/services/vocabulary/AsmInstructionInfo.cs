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
        public static AsmInstructionInfo Define(ushort Offset, string Display, string Instruction, string Encoding, AsmOperandInfo[] Operands, byte[] Encoded)
            => new AsmInstructionInfo(Offset, Display, Instruction, Encoding, Operands, Encoded);
        
        AsmInstructionInfo(ushort Offset, string Display, string Instruction, string Encoding, AsmOperandInfo[] Operands, byte[] Encoded)
        {
            this.Offset = Offset;
            this.Display = Display;
            this.Instruction = Instruction;
            this.Encoding = Encoding;
            this.Operands = Operands;
            this.Encoded = Encoded;
        }
        
        /// <summary>
        /// The zero-based offset of the function, relative to the function address
        /// </summary>
        public ushort Offset {get;}

        /// <summary>
        /// The instruction content, suitable for display
        /// </summary>
        public string Display {get;}

        
        /// <summary>
        /// The full instruction string
        /// </summary>
        public string Instruction {get;}

        /// <summary>
        /// The instruction encoding
        /// </summary>
        public string Encoding {get;}

        /// <summary>
        /// The encoded bytes
        /// </summary>
        public byte[] Encoded {get;}

        /// <summary>
        /// Describes the instruction operands
        /// </summary>
        public AsmOperandInfo[] Operands {get;}

    }
}