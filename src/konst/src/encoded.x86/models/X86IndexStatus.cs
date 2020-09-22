//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    [StructLayout(LayoutKind.Sequential)]
    public struct X86IndexStatus : ITextual
    {
        public PartId[] Parts;

        public ApiHostUri[] Hosts;

        public MemoryAddress[] Addresses;

        public Count MemberCount;

        public ApiHexAddresses Encoded;

        [MethodImpl(Inline)]
        public string Format()
            => text.format(RenderPatterns.PSx5, Parts.Length, Hosts.Length, MemberCount, Addresses.Length, Encoded.Count);

        public override string ToString()
            => Format();
    }
}