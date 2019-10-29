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
        public static BitMatrix<T> zero<T>()
            where T : unmanaged
                => BitMatrix.zero<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> identity<T>(BitMatrix<T> A)
            where T : unmanaged
                => A;

        [MethodImpl(Inline)]
        public static BitMatrix<T> identity<T>(BitMatrix<T> A, ref BitMatrix<T> Z)
            where T : unmanaged
        {
                Z.Update(A);
                return Z;
        }

        [MethodImpl(Inline)]
        public static BitMatrix<T> ones<T>()
            where T : unmanaged
                => BitMatrix.ones<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> @false<T>()
            where T:unmanaged
                => zero<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> @false<T>(BitMatrix<T> A)
            where T:unmanaged
                => @false<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> @false<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T:unmanaged
                => @false<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> @true<T>()
            where T:unmanaged
                => ones<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> @true<T>(BitMatrix<T> A)
            where T:unmanaged
                => @true<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> @true<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T:unmanaged
                => @true<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> not<T>(BitMatrix<T> A)
            where T : unmanaged
                => BitMatrix.not(A);

        [MethodImpl(Inline)]
        public static BitMatrix<T> not<T>(BitMatrix<T> A, ref BitMatrix<T> Z)
            where T : unmanaged
                => BitMatrix.not(A, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> and<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.and(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix<T> and<T>(BitMatrix<T> A, BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => BitMatrix.and(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> or<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.or(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix<T> or<T>(BitMatrix<T> A, BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => BitMatrix.or(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> xor<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.xor(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix<T> xor<T>(BitMatrix<T> A, BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => BitMatrix.xor(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> nand<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.nand(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix<T> nand<T>(BitMatrix<T> A, BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => BitMatrix.nand(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> nor<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.nor(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix<T> nor<T>(BitMatrix<T> A, BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => BitMatrix.nor(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> xnor<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.xnor(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix<T> xnor<T>(BitMatrix<T> A, BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => BitMatrix.xnor(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> cnotimply<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.andnot(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix<T> andnot<T>(BitMatrix<T> A, BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => BitMatrix.andnot(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> left<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => A;

        [MethodImpl(Inline)]
        public static BitMatrix<T> left<T>(BitMatrix<T> A, BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            Z.Update(A);
            return Z;
        }

        [MethodImpl(Inline)]
        public static BitMatrix<T> right<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => B;

        [MethodImpl(Inline)]
        public static BitMatrix<T> right<T>(BitMatrix<T> A, BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            Z.Update(B);
            return Z;
        }

        [MethodImpl(Inline)]
        public static BitMatrix<T> lnot<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => not(A);

        [MethodImpl(Inline)]
        public static BitMatrix<T> leftnot<T>(BitMatrix<T> A, BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => not(A, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> rnot<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => not(B);

        [MethodImpl(Inline)]
        public static BitMatrix<T> rightnot<T>(BitMatrix<T> A, BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => not(B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> cimply<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => not(cnotimply(A, B));

        [MethodImpl(Inline)]
        public static BitMatrix<T> implies<T>(BitMatrix<T> A, BitMatrix<T> B, ref BitMatrix<T> C)
            where T : unmanaged
                => not(andnot(A,B, ref C), ref C);       

        [MethodImpl(Inline)]
        public static BitMatrix<T> xornot<T>(BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.xornot(A,B);

        [MethodImpl(Inline)]
        public static BitMatrix<T> xornot<T>(BitMatrix<T> A, BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => BitMatrix.xornot(A,B, ref Z);


        [MethodImpl(Inline)]
        public static BitMatrix<T> select<T>(BitMatrix<T> A, BitMatrix<T> B, BitMatrix<T> C)
            where T : unmanaged
                => BitMatrix.select(A,B,C);

        [MethodImpl(Inline)]
        public static BitMatrix<T> select<T>(BitMatrix<T> A, BitMatrix<T> B, BitMatrix<T> C, ref BitMatrix<T> Z)
            where T : unmanaged
                => BitMatrix.select(A,B,C, ref Z);

    }
}
