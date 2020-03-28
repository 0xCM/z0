//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;

    partial class BitMatrix
    {
        [MethodImpl(Inline), IdentityFunction, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> identity<T>(in BitMatrix<T> A)
            where T : unmanaged
                => A;

        [MethodImpl(Inline), IdentityFunction, NumericClosures(NumericKind.UnsignedInts)]
        public static ref BitMatrix<T> identity<T>(in BitMatrix<T> A, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            Z.Update(A);
            return ref Z;
        }
    }
}