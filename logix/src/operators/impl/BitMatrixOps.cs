//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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

    public static class BitMatrixOps
    {

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> @false<T>()
            where T:unmanaged
                => BitMatrix.@false<T>();

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> @true<T>()
            where T:unmanaged
                => BitMatrix.@true<T>();

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> @false<T>(in BitMatrix<T> A)
            where T:unmanaged
                => BitMatrix.@false(A);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> @true<T>(in BitMatrix<T> A)
            where T:unmanaged
                => BitMatrix.@true(A);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> not<T>(in BitMatrix<T> A)
            where T : unmanaged
                => BitMatrix.not(A);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> not<T>(in BitMatrix<T> A, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.not(A, ref Z);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> identity<T>(in BitMatrix<T> A)
            where T : unmanaged
                => BitMatrix.identity(A);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> identity<T>(in BitMatrix<T> A, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.identity(A, ref Z);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> @false<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T:unmanaged
                => BitMatrix.@false<T>(A,B);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> @false<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T:unmanaged
            => ref BitMatrix.@false(A,B, ref Z);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> @true<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T:unmanaged
                => BitMatrix.@true<T>(A,B);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> @true<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T:unmanaged
            => ref BitMatrix.@true(A,B, ref Z);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> and<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.and(A,B);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> and<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.and(A, B, ref Z);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> nand<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.nand(A,B);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> nand<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.nand(A,B, ref Z);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> or<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.or(A,B);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> or<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.or(A,B, ref Z);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> nor<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.nor(A,B);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> nor<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.nor(A,B, ref Z);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> xor<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.xor(A,B);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> xor<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.xor(A,B, ref Z);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> xnor<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.xnor(A,B);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> xnor<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.xnor(A,B, ref Z);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> left<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.left(A,B);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> left<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.left(A,B, ref Z);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> right<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.right(A,B);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> right<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.right(A,B, ref Z);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> lnot<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.lnot(A,B);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> lnot<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.lnot(A,B, ref Z);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> rnot<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.rnot(A,B);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> rnot<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.rnot(A,B, ref Z);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> impl<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.impl(A,B);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> impl<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.impl(A,B, ref Z);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> nonimpl<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.nonimpl(A,B);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> nonimpl<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.nonimpl(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> cimpl<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.cimpl(A,B);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> cimpl<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.cimpl(A,B, ref Z);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> cnonimpl<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.cnonimpl(A,B);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> cnonimpl<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.cnonimpl(A,B, ref Z);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> xornot<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.xornot(A,B);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> xornot<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.xornot(A,B, ref Z);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> select<T>(in BitMatrix<T> A, in BitMatrix<T> B, in BitMatrix<T> C)
            where T : unmanaged
                => BitMatrix.select(A,B,C);

        [MethodImpl(Inline), BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static ref BitMatrix<T> select<T>(in BitMatrix<T> A, in BitMatrix<T> B, in BitMatrix<T> C, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.select(A,B,C, ref Z);
    }
}
