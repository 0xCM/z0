//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; using static Memories;

    partial class BitMatrix
    {
        [MethodImpl(Inline), RProject, Closures(UnsignedInts)]
        public static BitMatrix<T> right<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => B;

        [MethodImpl(Inline), RProject, Closures(UnsignedInts)]
        public static ref BitMatrix<T> right<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            Z.Update(B);
            return ref Z;
        }
    }
}