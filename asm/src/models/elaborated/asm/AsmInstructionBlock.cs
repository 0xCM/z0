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
        public static AsmInstructionBlock Define(AsmCode encoded, Instruction[] decoded, CaptureOutcome captureinfo)
            => new AsmInstructionBlock(encoded, decoded, captureinfo);

        AsmInstructionBlock(AsmCode encoded, Instruction[] decoded, CaptureOutcome captureinfo)
        {
            this.Label = encoded.Label;
            this.NativeCode = encoded;
            this.Decoded = decoded;
            this.CaptureInfo = captureinfo;
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
        /// The decoded instructions
        /// </summary>
        public Instruction[] Decoded {get;}

        /// <summary>
        /// Describes the capture outcome
        /// </summary>
        public CaptureOutcome CaptureInfo {get;}

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