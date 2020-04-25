//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIV
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static LogicSig;

    using ULK = UnaryLogicKind;
    using BLK = BinaryLogicKind;

    partial class BitMatrixOps
    {
        [Op, NumericClosures(UnsignedInts)]
        public static BitMatrix<T> eval<T>(ULK kind, BitMatrix<T> A)
            where T : unmanaged
        {
            switch(kind)
            {
                case ULK.Not: return not(A);
                case ULK.Identity: return identity(A);
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        [Op, NumericClosures(UnsignedInts)]
        public static BitMatrix<T> eval<T>(ULK kind, BitMatrix<T> A, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            switch(kind)
            {
                case ULK.Not: return not(A, ref Z);
                case ULK.Identity: return identity(A, ref Z);
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        [Op, NumericClosures(UnsignedInts)]
        public static BitMatrix<T> eval<T>(BLK kind, BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
        {
            switch(kind)
            {
                case BLK.True: return @true<T>();
                case BLK.False: return @false<T>();
                case BLK.And: return and(A,B);
                case BLK.Nand: return nand(A,B);
                case BLK.Or: return or(A,B);
                case BLK.Nor: return nor(A,B);
                case BLK.Xor: return xor(A,B);
                case BLK.Xnor: return xnor(A,B);
                case BLK.LProject: return left(A,B);
                case BLK.RProject: return right(A,B);
                case BLK.LNot: return lnot(A,B);
                case BLK.RNot: return rnot(A,B);
                case BLK.Impl: return impl(A,B);
                case BLK.NonImpl: return nonimpl(A,B);
                case BLK.CImpl: return cimpl(A,B);
                case BLK.CNonImpl: return cnonimpl(A,B);
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        [Op, NumericClosures(UnsignedInts)]
        public static BitMatrix<T> eval<T>(BLK kind, in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            switch(kind)
            {
                case BLK.True: return @true<T>();
                case BLK.False: return @false<T>();
                case BLK.And: return and(A, B, ref Z);
                case BLK.Nand: return nand(A, B, ref Z);
                case BLK.Or: return or(A, B, ref Z);
                case BLK.Nor: return nor(A, B, ref Z);
                case BLK.Xor: return xor(A, B, ref Z);
                case BLK.Xnor: return xnor(A, B, ref Z);
                case BLK.LProject: return left(A,B, ref Z);
                case BLK.LNot: return lnot(A,B, ref Z);
                case BLK.RProject: return right(A,B, ref Z);
                case BLK.RNot: return rnot(A, B, ref Z);
                case BLK.Impl: return impl(A,B, ref Z);
                case BLK.NonImpl: return nonimpl(A,B, ref Z);
                case BLK.CImpl: return cimpl(A,B, ref Z);
                case BLK.CNonImpl: return cnonimpl(A,B, ref Z);
                default: throw Unsupported.define<T>(sig<T>(kind));
            }

        }

        [Op, NumericClosures(UnsignedInts)]
        public static BitMatrixBinaryRefOp<T> refop<T>(BLK kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BLK.True: return @true;
                case BLK.False: return @false;
                case BLK.And: return and;
                case BLK.Nand: return nand;
                case BLK.Or: return or;
                case BLK.Nor: return nor;
                case BLK.Xor: return xor;
                case BLK.Xnor: return xnor;
                case BLK.LProject: return left;
                case BLK.LNot: return lnot;
                case BLK.RProject: return right;
                case BLK.RNot: return rnot;
                case BLK.Impl: return impl;
                case BLK.NonImpl: return nonimpl;
                case BLK.CImpl: return cimpl;
                case BLK.CNonImpl: return cnonimpl;
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> @false<T>()
            where T:unmanaged
                => BitMatrix.@false<T>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> @true<T>()
            where T:unmanaged
                => BitMatrixA.@true<T>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> @false<T>(in BitMatrix<T> a)
            where T:unmanaged
                => BitMatrix.@false(a);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> @true<T>(in BitMatrix<T> a)
            where T:unmanaged
                => BitMatrixA.@true(a);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> not<T>(in BitMatrix<T> a)
            where T : unmanaged
                => BitMatrix.not(a);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> not<T>(in BitMatrix<T> a, ref BitMatrix<T> dst)
            where T : unmanaged
                => ref BitMatrix.not(a, ref dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly BitMatrix<T> identity<T>(in BitMatrix<T> A)
            where T : unmanaged
                => ref BitMatrix.identity(A);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> identity<T>(in BitMatrix<T> A, ref BitMatrix<T> dst)
            where T : unmanaged
                => ref BitMatrix.identity(A, ref dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> @false<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T:unmanaged
                => BitMatrix.@false<T>(A,B);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> @false<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> dst)
            where T:unmanaged
            => ref BitMatrix.@false(A,B, ref dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> @true<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T:unmanaged
                => BitMatrixA.@true<T>(A,B);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> @true<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T:unmanaged
            => ref BitMatrix.@true(A,B, ref Z);


        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> and<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.and(A,B);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> and<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.and(A, B, ref Z);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> nand<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrixA.nand(A,B);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> nand<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrixA.nand(A,B, ref Z);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> or<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.or(A,B);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> or<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.or(A,B, ref Z);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> nor<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrixA.nor(A,B);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> nor<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrixA.nor(A,B, ref Z);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> xor<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrixA.xor(A,B);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> xor<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrixA.xor(A,B, ref Z);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> xnor<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrixA.xnor(A,B);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> xnor<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.xnor(A,B, ref Z);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> left<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.left(A,B);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> left<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.left(A,B, ref Z);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> right<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.right(A,B);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> right<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.right(A, B, ref Z);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> lnot<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.lnot(A,B);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> lnot<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.lnot(A, B, ref Z);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> rnot<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.rnot(A,B);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> rnot<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.rnot(A, B, ref Z);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> impl<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.impl(A,B);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> impl<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.impl(A,B, ref Z);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> nonimpl<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.nonimpl(A,B);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> nonimpl<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.nonimpl(A,B, ref Z);

        [MethodImpl(Inline)]
        public static BitMatrix<T> cimpl<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.cimpl(A,B);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> cimpl<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.cimpl(A,B, ref Z);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> cnonimpl<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.cnonimpl(A,B);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> cnonimpl<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.cnonimpl(A,B, ref Z);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> xornot<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
                => BitMatrix.xornot(A,B);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> xornot<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.xornot(A,B, ref Z);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BitMatrix<T> select<T>(in BitMatrix<T> A, in BitMatrix<T> B, in BitMatrix<T> C)
            where T : unmanaged
                => BitMatrix.select(A,B,C);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref BitMatrix<T> select<T>(in BitMatrix<T> A, in BitMatrix<T> B, in BitMatrix<T> C, ref BitMatrix<T> Z)
            where T : unmanaged
                => ref BitMatrix.select(A,B,C, ref Z);


        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly BitMatrix<T> @true2<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T:unmanaged
                => ref BitMatrix.@true(A,B, ref Z);
    }
}