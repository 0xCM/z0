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

    public struct CaptureIndexStatus : ITextual
    {
        public PartId[] Parts;

        public ApiHostUri[] Hosts;

        public MemoryAddress[] Addresses;

        public Count32 MemberCount;

        public EncodedMemoryIndex Encoded;

        public string Format()
            => text.format(RenderPatterns.PSx5, Parts.Length, Hosts.Length, MemberCount, Addresses.Length, Encoded.Count);

        public override string ToString()
            => Format();
    }

}