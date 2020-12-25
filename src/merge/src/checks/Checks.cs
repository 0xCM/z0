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

    public readonly struct Checks
    {
        public const uint Reps = Pow2.T08;

        [MethodImpl(Inline)]
        public static ref ulong eq<T>(T x, T y, ref byte index, ref ulong dst)
            where T : unmanaged
        {
            dst = (ulong)@byte(ClrPrimitives.eq(x,y)) << index++;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static bit eq<T>(T x, T y)
            where T : unmanaged
                => ClrPrimitives.eq(x,y);

        [MethodImpl(Inline)]
        public static BitVector64 bveq<T>(T x, T y, byte index)
            where T : unmanaged, Enum
                => (ulong)@byte(x.Equals(y)) << index;
    }
}