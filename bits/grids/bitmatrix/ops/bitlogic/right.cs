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
        [MethodImpl(Inline), RProject, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> right<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => B;

        [MethodImpl(Inline), RProject, NumericClosures(NumericKind.UnsignedInts)]
        public static ref BitMatrix<T> right<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            Z.Update(B);
            return ref Z;
        }
    }
}