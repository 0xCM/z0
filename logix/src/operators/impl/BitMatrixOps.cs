//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIV
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static As;
    using static TernaryBitOpKind;

    public static class BitMatrixOps
    {
        [MethodImpl(Inline)]
        public static RowBits<T> identity<T>(RowBits<T> A)
            where T : unmanaged
                => A;

        [MethodImpl(Inline)]
        public static RowBits<T> not<T>(RowBits<T> A)
            where T : unmanaged
                => BitMatrix.not(A);

        [MethodImpl(Inline)]
        public static RowBits<T> @false<T>(RowBits<T> A, RowBits<T> B)
            where T:unmanaged
                => A.Replicate(true);

        [MethodImpl(Inline)]
        public static RowBits<T> @true<T>(RowBits<T> A, RowBits<T> B)
            where T:unmanaged
                => A.Replicate(true).Fill(gmath.maxval<T>());

        [MethodImpl(Inline)]
        public static RowBits<T> and<T>(RowBits<T> A, RowBits<T> B)
            where T : unmanaged
                => RowBits.and(A,B);

        [MethodImpl(Inline)]
        public static RowBits<T> or<T>(RowBits<T> A, RowBits<T> B)
            where T : unmanaged
                => RowBits.or(A,B);

        [MethodImpl(Inline)]
        public static RowBits<T> xor<T>(RowBits<T> A, RowBits<T> B)
            where T : unmanaged
                => BitMatrix.xor(A,B);

        [MethodImpl(Inline)]
        public static RowBits<T> nand<T>(RowBits<T> A, RowBits<T> B)
            where T : unmanaged
                => BitMatrix.nand(A,B);

        [MethodImpl(Inline)]
        public static RowBits<T> nor<T>(RowBits<T> A, RowBits<T> B)
            where T : unmanaged
                => BitMatrix.nor(A,B);

        [MethodImpl(Inline)]
        public static RowBits<T> xnor<T>(RowBits<T> A, RowBits<T> B)
            where T : unmanaged
                => BitMatrix.xnor(A,B);

        [MethodImpl(Inline)]
        public static RowBits<T> andnot<T>(RowBits<T> A, RowBits<T> B)
            where T : unmanaged
                => RowBits.andnot(A,B);


    }
}
