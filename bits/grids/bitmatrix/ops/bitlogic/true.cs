//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    partial class BitMatrix
    {
        [MethodImpl(Inline), True, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> @true<T>()
            where T:unmanaged
                => ones<T>();

        [MethodImpl(Inline), True, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> @true<T>(in BitMatrix<T> A)
            where T:unmanaged
                => @true<T>();

        [MethodImpl(Inline), True, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> @true<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T:unmanaged
                => @true<T>();

        [MethodImpl(Inline), True, NumericClosures(NumericKind.UnsignedInts)]
        public static ref BitMatrix<T> @true<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T:unmanaged
        {
            Z.Data.Fill(root.maxval<T>());
            return ref Z;
        }
    }
}