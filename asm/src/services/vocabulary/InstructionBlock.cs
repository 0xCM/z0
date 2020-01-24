//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Iced.Intel;
    
    using static zfunc;
        
    /// <summary>
    /// Encapsulates a contiguous instruction sequence
    /// </summary>
    public class InstructionBlock
    {
        /// <summary>
        /// Defines an instruction sequence, in both encoded and decoded form
        /// </summary>
        /// <param name="encoded">The encoded instructions</param>
        /// <param name="decoded">The decoded instructions</param>
        public static InstructionBlock Define(AsmCode encoded, CaptureTermCode tc, IEnumerable<Instruction> decoded)
            => new InstructionBlock(encoded, tc, decoded.ToArray());

        InstructionBlock(AsmCode encoded, CaptureTermCode tc, Instruction[] decoded)
        {
            this.Label = encoded.Label;
            this.NativeCode = encoded;
            this.Decoded = decoded;
            this.Origin = encoded.Origin;
            this.TermCode = tc;
        }

        /// <summary>
        /// A description for the block
        /// </summary>
        public string Label {get;}

        /// <summary>
        /// The memory segment from which the code was taken
        /// </summary>
        public MemoryRange Origin {get;}

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
    }
}