//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class BitMatrix
    {
        [MethodImpl(Inline), LNot, Closures(UnsignedInts)]
        public static ref readonly BitMatrix<T> lnot<T>(in BitMatrix<T> A, in BitMatrix<T> B, in BitMatrix<T> Z)
            where T : unmanaged
                => ref not(A, Z);
    }
}