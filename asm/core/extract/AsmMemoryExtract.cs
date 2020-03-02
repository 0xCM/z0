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
        public static AsmMemoryExtract Define(MemoryAddress address, AsmCaptureBits data, AsmInstructionList instructions)
            => new AsmMemoryExtract(address, data, instructions);
        
        [MethodImpl(Inline)]
        public static implicit operator AsmMemoryExtract((MemoryAddress address, AsmCaptureBits data, AsmInstructionList instructions) src)
            => Define(src.address, src.data, src.instructions);

        [MethodImpl(Inline)]
        AsmMemoryExtract(MemoryAddress address, AsmCaptureBits data, AsmInstructionList instructions)
        {
            this.Address = address;
            this.Data = data;
            this.Instructions = instructions;
        }

        public readonly MemoryAddress Address;

        public readonly AsmCaptureBits Data;

        public readonly AsmInstructionList Instructions;
    }
}