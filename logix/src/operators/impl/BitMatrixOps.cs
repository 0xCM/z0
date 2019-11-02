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
    using static TernaryOpKind;

    public static class BitMatrixOps
    {
        [MethodImpl(Inline)]
        public static BitMatrix<T> zero<T>()
            where T : unmanaged
                => BitMatrix.zero<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> ones<T>()
            where T : unmanaged
                => BitMatrix.ones<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> @false<T>()
            where T:unmanaged
                => zero<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> @true<T>()
            where T:unmanaged
                => ones<T>();


        [MethodImpl(Inline)]
        public static BitMatrix<T> @false<T>(in BitMatrix<T> A)
            where T:unmanaged
                => @false<T>();


        [MethodImpl(Inline)]
        public static BitMatrix<T> @true<T>(in BitMatrix<T> A)
            where T:unmanaged
                => @true<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> not<T>(in BitMatrix<T> A)
            where T : unmanaged
                => BitMatrix.not(A);

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> not<T>(in BitMatrix<T> A, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.not(A, ref Z);

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

        [MethodImpl(Inline)]
        public static BitMatrix<T> @false<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T:unmanaged
                => @false<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> @true<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T:unmanaged
                => @true<T>();

        [MethodImpl(Inline)]
        public static BitMatrix<T> and<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.and(A,B);

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> and<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.and(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> nand<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.nand(A,B);

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> nand<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.nand(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> or<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.or(A,B);

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> or<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.or(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> nor<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.nor(A,B);

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> nor<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.nor(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> xor<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.xor(A,B);

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> xor<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.xor(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> xnor<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.xnor(A,B);

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> xnor<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.xnor(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> left<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => A;

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> left<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            Z.Update(A);
            return ref Z;
        }

        [MethodImpl(Inline)]
        public static BitMatrix<T> right<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => B;

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> right<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            Z.Update(B);
            return ref Z;
        }

        [MethodImpl(Inline)]
        public static BitMatrix<T> lnot<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => not(A);

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> leftnot<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref not(A, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> rnot<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => not(B);

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> rightnot<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref not(B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> imply<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.imply(A,B);

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> imply<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.imply(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> notimply<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.notimply(A,B);

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> notimply<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.notimply(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> cimply<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.cimply(A,B);

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> cimply<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.cimply(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> cnotimply<T>(in BitMatrix<T> A,in  BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.cnotimply(A,B);

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> cnotimply<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.cnotimply(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> xornot<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.xornot(A,B);

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> xornot<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.xornot(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> select<T>(in BitMatrix<T> A, in BitMatrix<T> B, in BitMatrix<T> C)
            where T : unmanaged
                => BitMatrix.select(A,B,C);

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> select<T>(in BitMatrix<T> A, in BitMatrix<T> B, in BitMatrix<T> C, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.select(A,B,C, ref Z);
    }
}
