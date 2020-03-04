//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0.Asm;

    using static Root;

    public readonly struct AsmMemoryExtract
    {
        [MethodImpl(Inline)]
        public static AsmMemoryExtract Define(MemoryAddress address, AsmCaptureBits data, AsmInstructionList instructions, string formatted)
            => new AsmMemoryExtract(address, data, instructions,formatted);
        

        [MethodImpl(Inline)]
        AsmMemoryExtract(MemoryAddress address, AsmCaptureBits data, AsmInstructionList instructions, string formatted)
        {
            this.Address = address;
            this.Data = data;
            this.Instructions = instructions;
            this.FormattedAsm = formatted;
        }

        public readonly MemoryAddress Address;

        public readonly AsmCaptureBits Data;

        public readonly AsmInstructionList Instructions;

        public readonly string FormattedAsm;
    }
}