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
    public readonly struct AsmFxBlock 
    {
        /// <summary>
        /// Encoded assembly
        /// </summary>
        public readonly MemberCode Encoded;

        /// <summary>
        /// The decoded instructions
        /// </summary>
        public readonly Instruction[] Decoded;

        /// <summary>
        /// The reason capture was terminated
        /// </summary>
        public readonly ExtractTermCode TermCode;

        [MethodImpl(Inline)]
        public AsmFxBlock(MemberCode encoded, Instruction[] decoded, ExtractTermCode term)
        {
            Encoded = encoded;
            Decoded = decoded;
            TermCode = term;
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