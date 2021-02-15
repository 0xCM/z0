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

    partial struct AsmCases
    {
        public struct CallRel32
        {
            public AsmCaller Caller;

            public MemoryAddress Ip;

            public MemoryAddress NextIp;

            public MemoryAddress Target;

            public Address32 RelTarget;

            public AsmHexCode Encoding;

            public Address32 Offset => (Address32)(Target - NextIp);

            public ByteSize IpDelta => (ByteSize)(NextIp - Ip);

            public string Format()
                => format(this);

            public bool Validate(ITextBuffer errors)
                => validate(this, errors);

            public override string ToString()
                => Format();
        }
    }
}