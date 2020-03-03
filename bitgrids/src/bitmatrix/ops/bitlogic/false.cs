//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;

    partial class BitMatrix
    {
        [MethodImpl(Inline)]
        public static BitMatrix<T> @false<T>()
            where T:unmanaged
                => zero<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> @false<T>(in BitMatrix<T> A)
            where T:unmanaged
                => @false<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> @false<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T:unmanaged
                => @false<T>();

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> @false<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T:unmanaged
        {
            Z.Data.Fill(Literals.zero<T>());
            return ref Z;
        }
    }
}