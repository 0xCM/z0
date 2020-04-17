//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
        
    /// <summary>
    /// Encapsulates a contiguous instruction sequence along with the captured bits
    /// </summary>
    public readonly struct AsmInstructionBlock 
    {
        /// <summary>
        /// Defines an instruction sequence, in both encoded and decoded form
        /// </summary>
        /// <param name="encoded">The encoded instructions</param>
        /// <param name="decoded">The decoded instructions</param>
        [MethodImpl(Inline)]
        public static AsmInstructionBlock Define(LocatedBits encoded, Instruction[] decoded, ExtractTermCode term)
            => new AsmInstructionBlock(encoded, decoded, term);

        [MethodImpl(Inline)]
        AsmInstructionBlock(LocatedBits encoded, Instruction[] decoded, ExtractTermCode term)
        {
            this.NativeCode = encoded;
            this.Decoded = decoded;
            this.TermCode = term;
        }

        /// <summary>
        /// Encoded assembly
        /// </summary>
        public readonly LocatedBits NativeCode;

        /// <summary>
        /// The decoded instructions
        /// </summary>
        public readonly Instruction[] Decoded;

        /// <summary>
        /// The reason capture was terminated
        /// </summary>
        public readonly ExtractTermCode TermCode;
        
        /// <summary>
        /// Queries/Manipulates an index-identified instruction
        /// </summary>
        public ref Instruction this[int i]
            => ref Decoded[i];

        public int InstructionCount
            => Decoded.Length;     

        public MemoryRange Origin
            => NativeCode.Location;    
    }
}