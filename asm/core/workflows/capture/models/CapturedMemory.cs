//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0.Asm;

    using static Root;

    public readonly struct CapturedMemory
    {
        [MethodImpl(Inline)]
        public static CapturedMemory Define(MemoryAddress address, ParsedMemoryExtract data, AsmInstructionList instructions, string formatted)
            => new CapturedMemory(address, data, instructions,formatted);
        
        [MethodImpl(Inline)]
        CapturedMemory(MemoryAddress address, ParsedMemoryExtract data, AsmInstructionList instructions, string formatted)
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