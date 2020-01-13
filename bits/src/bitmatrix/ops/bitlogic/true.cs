//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitMatrix
    {
        [MethodImpl(Inline)]
        public static BitMatrix<T> @true<T>()
            where T:unmanaged
                => ones<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> @true<T>(in BitMatrix<T> A)
            where T:unmanaged
                => @true<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> @true<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T:unmanaged
                => @true<T>();

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> @true<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T:unmanaged
        {
            Z.Data.Fill(gmath.maxval<T>());
            return ref Z;
        }
    }
}