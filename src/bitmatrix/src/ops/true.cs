//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; 
    using static Memories;

    partial class BitMatrix
    {
        [MethodImpl(Inline), True, NumericClosures(UnsignedInts)]
        public static ref BitMatrix<T> @true<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T:unmanaged
        {
            Z.Content.Fill(maxval<T>());
            return ref Z;
        }
    }
}