//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class BitMatrix
    {
        [MethodImpl(Inline), LNot, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> lnot<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => not(A);

        [MethodImpl(Inline), LNot, NumericClosures(NumericKind.UnsignedInts)]
        public static ref BitMatrix<T> lnot<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref not(A, ref Z);
    }
}