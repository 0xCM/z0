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
        [MethodImpl(Inline), CImpl(BL), Closures(UnsignedInts)]
        public static BitVector<T> cimpl<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.cimpl(x.Scalar, y.Scalar);
    }
}