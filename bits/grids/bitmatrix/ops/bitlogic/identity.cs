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
        [MethodImpl(Inline)]
        public static BitMatrix<T> identity<T>(in BitMatrix<T> A)
            where T : unmanaged
                => A;

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> identity<T>(in BitMatrix<T> A, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            Z.Update(A);
            return ref Z;
        }
    }

}