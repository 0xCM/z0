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

    partial struct Resources
    {
        [MethodImpl(Inline)]
        public static ResourceSet<A> load<A>(in asci32 name, ReadOnlySpan<byte> src)
            where A : unmanaged, IBytes
                => new ResourceSet<A>(name, src);

        [MethodImpl(Inline)]
        public static ResourceSet<A> load<A>(string name, ReadOnlySpan<byte> src)
            where A : unmanaged, IBytes
                => new ResourceSet<A>(name, src);
    }
}