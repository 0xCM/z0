//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

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
        public static InstructionBlock Define(string name, ReadOnlySpan<byte> encoded, Instruction[] decoded)
            => new InstructionBlock(name,encoded,decoded);


        InstructionBlock(string name, ReadOnlySpan<byte> encoded, Instruction[] decoded)
        {
            this.Identity = name;
            this.EncodedData = encoded.ToArray();
            this.Decoded = decoded;
        }

        byte[] EncodedData; 

        /// <summary>
        /// The identity given to the block
        /// </summary>
        public string Identity {get;}

        /// <summary>
        /// The encoded instructions
        /// </summary>
        public ReadOnlySpan<byte> Encoded 
            => EncodedData;

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
        
        public int EncodedByteCount
            => EncodedData.Length;
    
        public ulong BaseAddress
            => Decoded[0].IP;       
    }
}