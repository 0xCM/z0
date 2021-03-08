//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmCallSite : ITextual
    {
        public AsmCaller Caller {get;}

        public Address16 InstructionOffset {get;}

        public uint4 InstructionSize {get;}

        [MethodImpl(Inline)]
        public AsmCallSite(AsmCaller caller, Address16 offset, uint4 size)
        {
            Caller = caller;
            InstructionOffset = offset;
            InstructionSize = size;
        }

        public MemoryAddress NextIp
        {
            [MethodImpl(Inline)]
            get => Caller.Base + InstructionOffset + InstructionSize;
        }

        public string Format()
            => string.Format("{0}:{1}", Caller, InstructionOffset);

        public override string ToString()
            => Format();
    }
}