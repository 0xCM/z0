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

    public readonly struct ApiMemoryCapture
    {
        [MethodImpl(Inline)]
        public static ApiMemoryCapture Define(MemoryAddress address, ParsedMemoryExtract data, AsmInstructionList instructions, string formatted)
            => new ApiMemoryCapture(address, data, instructions,formatted);
        
        [MethodImpl(Inline)]
        ApiMemoryCapture(MemoryAddress address, ParsedMemoryExtract data, AsmInstructionList instructions, string formatted)
        {
            this.Address = address;
            this.ExtractedData = data;
            this.Instructions = instructions;
            this.FormattedAsm = formatted;
        }

        public readonly MemoryAddress Address;

        public readonly ParsedMemoryExtract ExtractedData;

        public readonly AsmInstructionList Instructions;

        public readonly string FormattedAsm;
    }
}