//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
    
    using static Seed;

    public readonly struct MemoryCapture
    {
        public readonly MemoryAddress Address;

        public readonly ParsedMemoryExtract Parsed;

        public readonly AsmInstructionList Decoded;

        public readonly string FormattedAsm;        

        [MethodImpl(Inline)]
        public static MemoryCapture Define(MemoryAddress address, ParsedMemoryExtract data, AsmInstructionList instructions, string formatted)
            => new MemoryCapture(address, data, instructions,formatted);
        
        [MethodImpl(Inline)]
        MemoryCapture(MemoryAddress address, ParsedMemoryExtract data, AsmInstructionList instructions, string formatted)
        {
            this.Address = address;
            this.Parsed = data;
            this.Decoded = instructions;
            this.FormattedAsm = formatted;
        }
    }
}