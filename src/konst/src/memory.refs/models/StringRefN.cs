//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    public readonly struct StringRefs<N>
        where N : unmanaged, ITypeNat
    {
        readonly StringRef[] Refs;

        [MethodImpl(Inline)]
        public StringRefs(StringRef[] src)
            => Refs = z.insist(src, default(N));

        [MethodImpl(Inline)]
        public ref readonly StringRef Ref<I>(I i = default)
            where I : unmanaged, ITypeNat
        {
            var idx = z.nat64u(i);
            insist(idx < Count, $"{idx} < {Count}");
            return ref Refs[idx];
        }

        public uint Count
            => (uint)z.nat64u<N>();
    }
}