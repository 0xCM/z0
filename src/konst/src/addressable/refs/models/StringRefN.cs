//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static core;

    public readonly struct StringRefs<N>
        where N : unmanaged, ITypeNat
    {
        readonly StringRef[] Refs;

        [MethodImpl(Inline)]
        public StringRefs(StringRef[] src)
            => Refs = core.insist(src, default(N));

        [MethodImpl(Inline)]
        public ref readonly StringRef Ref<I>(I i = default)
            where I : unmanaged, ITypeNat
        {
            var idx = core.value(i);
            insist(idx < Count);
            return ref Refs[idx];
        }        

        public uint Count
            => (uint)core.value<N>();
    }
}