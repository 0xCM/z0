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

    partial struct AsmInstructions
    {
        public readonly struct CallRel32
        {
            public Address32 Target {get;}

            public MemoryAddress Ip {get;}

            public ByteSize InstructionSize
                => 5;

            public MemoryAddress NextIp
                => Ip + InstructionSize;

            public long Displacement
                => NextIp - Target;

            [MethodImpl(Inline)]
            public CallRel32(MemoryAddress ip,  Address32 target)
            {
                Ip = ip;
                Target = target;
            }

            public string Format()
                => format(this);

            public override string ToString()
                => Format();
        }
    }
}