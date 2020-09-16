//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public struct X86IndexStatus : ITextual
    {
        public PartId[] Parts;

        public ApiHostUri[] Hosts;

        public MemoryAddress[] Addresses;

        public Count32 MemberCount;

        public X86MemoryIndex Encoded;

        public string Format()
            => text.format(RenderPatterns.PSx5, Parts.Length, Hosts.Length, MemberCount, Addresses.Length, Encoded.Count);

        public override string ToString()
            => Format();
    }

}