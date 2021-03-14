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


    [ApiHost]
    public readonly struct BitChecks
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Closures(Closure)]
        public static ref ulong eq<T>(T x, T y, ref byte index, ref ulong dst)
            where T : unmanaged
        {
            dst = (ulong)@byte(gmath.eq(x,y)) << index++;
            return ref dst;
        }

        [MethodImpl(Inline), Closures(Closure)]
        public static bit eq<T>(T x, T y)
            where T : unmanaged
                => gmath.eq(x,y);

        [MethodImpl(Inline), Closures(Closure)]
        public static BitVector64 bveq<T>(T x, T y, byte index)
            where T : unmanaged, Enum
                => (ulong)@byte(emath.eq<T>(x,y)) << index;
    }
}
