//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    partial class AsmCases
    {
        public readonly struct JmpRel32Case
        {
            public MemoryAddress Ip {get;}

            public MemoryAddress Target {get;}

            public AsmHexCode Encoded {get;}

            public JmpRel32Case(MemoryAddress ip, MemoryAddress dst, AsmHexCode encoded)
            {
                Ip = ip;
                Target = dst;
                Encoded = encoded;
            }
        }

        public struct CallRel32Case
        {
            public AsmFragment AsmSource;

            public AsmCaller Caller;

            public MemoryAddress Ip;

            public MemoryAddress NextIp;

            public MemoryAddress Target;

            public Address32 RelTarget;

            public AsmHexCode Encoding;

            public Address32 Offset
                => (Address32)(Target - NextIp);

            public ByteSize IpDelta
                => (ByteSize)(NextIp - Ip);

            public string Format()
                => format(this);

            public bool Validate(ITextBuffer errors)
                => validate(this, errors);

            public override string ToString()
                => Format();
        }
    }
}