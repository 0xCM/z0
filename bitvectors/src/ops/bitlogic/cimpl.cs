//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;    

    partial class BitVector
    {

        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static BitVector<T> cimpl<T>(BitVector<T> x, BitVector<T> y)
            where T : unmanaged
                => gmath.cimpl(x.Scalar, y.Scalar);

    }
}