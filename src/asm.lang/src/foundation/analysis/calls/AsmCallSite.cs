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

        public Address16 LocalOffset {get;}

        public uint4 InstructionSize {get;}

        [MethodImpl(Inline)]
        public AsmCallSite(AsmCaller caller, Address16 offset, uint4 size)
        {
            Caller = caller;
            LocalOffset = offset;
            InstructionSize = size;
        }

        public MemoryAddress NextIp
        {
            [MethodImpl(Inline)]
            get => asm.nextip(this);
        }

        public string Format()
            => AsmRender.format(this);

        public override string ToString()
            => Format();
    }
}