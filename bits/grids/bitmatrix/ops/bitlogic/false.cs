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
        [MethodImpl(Inline), False, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> @false<T>()
            where T:unmanaged
                => zero<T>();

        [MethodImpl(Inline), False, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> @false<T>(in BitMatrix<T> A)
            where T:unmanaged
                => @false<T>();

        [MethodImpl(Inline), False, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> @false<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T:unmanaged
                => @false<T>();

        [MethodImpl(Inline), False, NumericClosures(NumericKind.UnsignedInts)]
        public static ref BitMatrix<T> @false<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T:unmanaged
        {
            Z.Data.Fill(root.zero<T>());
            return ref Z;
        }
    }
}