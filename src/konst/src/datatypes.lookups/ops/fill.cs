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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Lu8<V> fill<V>(Index<byte> keys, Index<V> values, ref Lu8<V> dst)
        {
            var count = keys.Length;
            ref readonly var kSrc = ref keys.First;
            ref readonly var vSrc = ref values.First;
            ref var luDst = ref dst.First;
            for(var i=0; i<count; i++)
                seek(luDst,i) = entry(skip(kSrc,i), skip(vSrc,i));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Lu16<V> fill<V>(Index<ushort> keys, Index<V> values, ref Lu16<V> dst)
        {
            var count = keys.Length;
            ref readonly var kSrc = ref keys.First;
            ref readonly var vSrc = ref values.First;
            ref var luDst = ref dst.First;
            for(var i=0; i<count; i++)
                seek(luDst,i) = entry(skip(kSrc,i), skip(vSrc,i));
            return ref dst;
        }
    }
}