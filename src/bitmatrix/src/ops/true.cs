//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst; 
    using static Memories;

    partial class BitMatrix
    {
        [MethodImpl(Inline), True, Closures(UnsignedInts)]
        public static ref readonly BitMatrix<T> @true<T>(in BitMatrix<T> A, in BitMatrix<T> B, in BitMatrix<T> Z)
            where T:unmanaged
        {
            Z.Content.Fill(maxval<T>());
            return ref Z;
        }
    }
}