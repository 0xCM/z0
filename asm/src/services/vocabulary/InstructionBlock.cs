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
        public static InstructionBlock Define(Moniker id, string label, AddressSegment location,  ReadOnlySpan<byte> encoded, Instruction[] decoded)
            => new InstructionBlock(id, label, location, encoded, decoded);

        InstructionBlock(Moniker id, string label, AddressSegment location, ReadOnlySpan<byte> encoded, Instruction[] decoded)
        {
            this.Label = label;
            this.Code = AsmCode.Define(id, label, encoded);
            this.Decoded = decoded;
            this.Location = location;
        }

        /// <summary>
        /// A description for the block
        /// </summary>
        public string Label {get;}

        public AsmCode Code {get;}

        /// <summary>
        /// The decoded instructions
        /// </summary>
        public Instruction[] Decoded {get;}

        public AddressSegment Location {get;}

        /// <summary>
        /// The encoded instructions
        /// </summary>
        public ReadOnlySpan<byte> Encoded 
            => Code.Encoded;

        /// <summary>
        /// Queries/Manipulates an index-identified instruction
        /// </summary>
        public ref Instruction this[int i]
            => ref Decoded[i];

        public int InstructionCount
            => Decoded.Length;        
    }
}