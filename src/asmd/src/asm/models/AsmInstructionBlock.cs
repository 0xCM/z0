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
    /// Encapsulates a contiguous instruction sequence along with the captured bits
    /// </summary>
    public readonly struct AsmInstructionBlock 
    {
        /// <summary>
        /// Encoded assembly
        /// </summary>
        public readonly UriCode Encoded;

        /// <summary>
        /// The decoded instructions
        /// </summary>
        public readonly Instruction[] Decoded;

        /// <summary>
        /// The reason capture was terminated
        /// </summary>
        public readonly ExtractTermCode TermCode;

        /// <summary>
        /// Defines an instruction sequence, in both encoded and decoded form
        /// </summary>
        /// <param name="encoded">The encoded instructions</param>
        /// <param name="decoded">The decoded instructions</param>
        [MethodImpl(Inline)]
        public static AsmInstructionBlock Define(UriCode encoded, Instruction[] decoded, ExtractTermCode term)
            => new AsmInstructionBlock(encoded, decoded, term);

        [MethodImpl(Inline)]
        AsmInstructionBlock(UriCode encoded, Instruction[] decoded, ExtractTermCode term)
        {
            this.Encoded = encoded;
            this.Decoded = decoded;
            this.TermCode = term;
        }

        public MemoryAddress BaseAddress 
        {
            [MethodImpl(Inline)]
            get => Encoded.Address;
        }
        
        /// <summary>
        /// Queries/Manipulates an index-identified instruction
        /// </summary>
        public ref Instruction this[int i]
            => ref Decoded[i];

        public int InstructionCount
            => Decoded.Length;     
    }
}