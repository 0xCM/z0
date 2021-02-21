//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Lookups
    {
        [MethodImpl(Inline)]
        public static Span<LookupEntry<T,V>> convert<S,V,T>(Span<LookupEntry<S,V>> src, T t = default)
            where S : unmanaged
            where T : unmanaged
        {
            var edit = src;
            ref var sv = ref first(edit);
            var tv = recover<LookupEntry<S,V>,LookupEntry<T,V>>(src);
            var count = src.Length;
            for(var i=0u; i<count; i++)
                seek(tv, i) = @as<LookupEntry<S,V>,LookupEntry<T,V>>(skip(sv,i));
            return tv;
        }
    }
}