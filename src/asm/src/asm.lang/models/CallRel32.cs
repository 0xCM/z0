//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    // E8 cd | Call near, relative, displacement relative to next instruction. 32-bit displacement sign extended to 64-bits in 64-bit mode
    public readonly struct CallRel32
    {
        public Address32 Target {get;}

        public MemoryAddress IP {get;}

        public ByteSize InstructionSize => 5;

        public MemoryAddress NextIP => IP + InstructionSize;

        public ByteSize Displacement => (ulong)Target - (ulong)NextIP;

        public CallRel32(MemoryAddress ip,  Address32 target)
        {
            IP = ip;
            Target = target;
        }
    }
}