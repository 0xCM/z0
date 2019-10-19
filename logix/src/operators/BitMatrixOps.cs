//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIV
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static As;
    using static TernaryLogicOpKind;

    public static class BitMatrixOps
    {
        [MethodImpl(Inline)]
        public static BitMatrix<T> identity<T>(BitMatrix<T> A)
            where T : unmanaged
                => A;

        [MethodImpl(Inline)]
        public static BitMatrix<T> not<T>(BitMatrix<T> A)
            where T : unmanaged
                => BitMatrix.not(A);

        [MethodImpl(Inline)]
        public static BitMatrix<T> @false<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T:unmanaged
                => A.Replicate(true);

        [MethodImpl(Inline)]
        public static BitMatrix<T> @true<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T:unmanaged
                => A.Replicate(true).Fill(gmath.maxval<T>());

        [MethodImpl(Inline)]
        public static BitMatrix<T> and<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.and(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix<T> or<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.or(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix<T> xor<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.xor(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix<T> nand<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.nand(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix<T> nor<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.nor(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix<T> xnor<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.xnor(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix<T> andnot<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.andnot(A,B);


    }
}
