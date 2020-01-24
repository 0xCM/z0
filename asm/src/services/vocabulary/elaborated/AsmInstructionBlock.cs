//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.AsmSpecs
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using static zfunc;
        
    /// <summary>
    /// Encapsulates a contiguous instruction sequence along with the captured bits
    /// </summary>
    public class AsmInstructionBlock
    {
        /// <summary>
        /// Defines an instruction sequence, in both encoded and decoded form
        /// </summary>
        /// <param name="encoded">The encoded instructions</param>
        /// <param name="decoded">The decoded instructions</param>
        public static AsmInstructionBlock Define(AsmCode encoded, Instruction[] decoded, CaptureTermCode tc)
            => new AsmInstructionBlock(encoded, decoded, tc);

        AsmInstructionBlock(AsmCode encoded, Instruction[] decoded, CaptureTermCode tc)
        {
            this.Label = encoded.Label;
            this.NativeCode = encoded;
            this.Decoded = decoded;
            this.TermCode = tc;
        }

        /// <summary>
        /// A description for the block
        /// </summary>
        public string Label {get;}

        /// <summary>
        /// Encoded assembly
        /// </summary>
        public AsmCode NativeCode {get;}

        /// <summary>
        /// The reason discerned for capture completion
        /// </summary>
        public CaptureTermCode TermCode {get;}

        /// <summary>
        /// The decoded instructions
        /// </summary>
        public Instruction[] Decoded {get;}

        /// <summary>
        /// Queries/Manipulates an index-identified instruction
        /// </summary>
        public ref Instruction this[int i]
            => ref Decoded[i];

        public int InstructionCount
            => Decoded.Length;     

        public MemoryRange Origin
            => NativeCode.Origin;   
 
    }

}