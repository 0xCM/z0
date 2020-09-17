//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Linq;

    using static Konst;
    using static z;

    readonly struct Checks
    {
        public const uint Reps = Pow2.T08;

        [MethodImpl(Inline)]
        public static BitVector64 bveq<T>(T x, T y, byte index)
            where T : unmanaged, Enum
                => (ulong)@byte(x.Equals(y)) << index;

        [MethodImpl(Inline)]
        public static uint1 eq<T>(T x, T y)
            where T : unmanaged
                => PrimalKinds.eq(x,y);
    }
}