//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    partial class BitVector
    {
        [MethodImpl(Inline), Eq, Closures(UnsignedInts)]
        public static bit same<T>(in BitVector<T> x, in BitVector<T> y)
            where T : unmanaged
                => gmath.eq(x.data,y.data);
    }
}