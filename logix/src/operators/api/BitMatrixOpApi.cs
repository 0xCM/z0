//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;

    using static zfunc;    
    using static OpHelpers;
    using static BitMatrixOps;

    public delegate ref BitMatrix<T> BitMatrixUnaryRefOp<T>(in BitMatrix<T> A, ref BitMatrix<T> Z)
        where T : unmanaged;

    public delegate ref BitMatrix<T> BitMatrixBinaryRefOp<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
        where T : unmanaged;

    /// <summary>
    /// Defines services for bitmatrix operators
    /// </summary>
    //[ApiHost("bitmatrix.api",ApiHostKind.Generic)]
    public static class BitMatrixOpApi
    {
        /// <summary>
        /// Advertises the supported unary bitwise operators
        /// </summary>
        public static ReadOnlySpan<UnaryBitLogicKind> UnaryBitwiseKinds
            => array(UnaryBitLogicKind.Not, UnaryBitLogicKind.Identity);

        /// <summary>
        /// Advertises the supported binary bitwise operators
        /// </summary>
        public static ReadOnlySpan<BinaryBitLogicKind> BinaryBitwiseKinds
            => ScalarOpApi.BinaryBitLogicKinds;

        [Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> eval<T>(UnaryBitLogicKind kind, BitMatrix<T> A)
            where T : unmanaged
        {
            switch(kind)
            {
                case UnaryBitLogicKind.Not: return not(A);
                case UnaryBitLogicKind.Identity: return identity(A);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> eval<T>(UnaryBitLogicKind kind, BitMatrix<T> A, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            switch(kind)
            {
                case UnaryBitLogicKind.Not: return not(A, ref Z);
                case UnaryBitLogicKind.Identity: return identity(A, ref Z);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> eval<T>(BinaryBitLogicKind kind, BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitLogicKind.True: return @true<T>();
                case BinaryBitLogicKind.False: return @false<T>();
                case BinaryBitLogicKind.And: return and(A,B);
                case BinaryBitLogicKind.Nand: return nand(A,B);
                case BinaryBitLogicKind.Or: return or(A,B);
                case BinaryBitLogicKind.Nor: return nor(A,B);
                case BinaryBitLogicKind.Xor: return xor(A,B);
                case BinaryBitLogicKind.Xnor: return xnor(A,B);
                case BinaryBitLogicKind.LProject: return left(A,B);
                case BinaryBitLogicKind.RProject: return right(A,B);
                case BinaryBitLogicKind.LNot: return lnot(A,B);
                case BinaryBitLogicKind.RNot: return rnot(A,B);
                case BinaryBitLogicKind.Impl: return impl(A,B);
                case BinaryBitLogicKind.NonImpl: return nonimpl(A,B);
                case BinaryBitLogicKind.CImpl: return cimpl(A,B);
                case BinaryBitLogicKind.CNonImpl: return cnonimpl(A,B);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> eval<T>(BinaryBitLogicKind kind, BitMatrix<T> A, BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitLogicKind.True: return @true<T>();
                case BinaryBitLogicKind.False: return @false<T>();
                case BinaryBitLogicKind.And: return and(A, B, ref Z);
                case BinaryBitLogicKind.Nand: return nand(A, B, ref Z);
                case BinaryBitLogicKind.Or: return or(A, B, ref Z);
                case BinaryBitLogicKind.Nor: return nor(A, B, ref Z);
                case BinaryBitLogicKind.Xor: return xor(A, B, ref Z);
                case BinaryBitLogicKind.Xnor: return xnor(A, B, ref Z);
                case BinaryBitLogicKind.LProject: return left(A,B, ref Z);
                case BinaryBitLogicKind.LNot: return lnot(A,B, ref Z);
                case BinaryBitLogicKind.RProject: return right(A,B, ref Z);
                case BinaryBitLogicKind.RNot: return rnot(A, B, ref Z);
                case BinaryBitLogicKind.Impl: return impl(A,B, ref Z);
                case BinaryBitLogicKind.NonImpl: return nonimpl(A,B, ref Z);
                case BinaryBitLogicKind.CImpl: return cimpl(A,B, ref Z);
                case BinaryBitLogicKind.CNonImpl: return cnonimpl(A,B, ref Z);
                default: throw new NotSupportedException(sig<T>(kind));
            }

        }

        [Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrixBinaryRefOp<T> lookup<T>(BinaryBitLogicKind kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitLogicKind.True: return @true;
                case BinaryBitLogicKind.False: return @false;
                case BinaryBitLogicKind.And: return and;
                case BinaryBitLogicKind.Nand: return nand;
                case BinaryBitLogicKind.Or: return or;
                case BinaryBitLogicKind.Nor: return nor;
                case BinaryBitLogicKind.Xor: return xor;
                case BinaryBitLogicKind.Xnor: return xnor;
                case BinaryBitLogicKind.LProject: return left;
                case BinaryBitLogicKind.LNot: return lnot;
                case BinaryBitLogicKind.RProject: return right;
                case BinaryBitLogicKind.RNot: return rnot;
                case BinaryBitLogicKind.Impl: return impl;
                case BinaryBitLogicKind.NonImpl: return nonimpl;
                case BinaryBitLogicKind.CImpl: return cimpl;
                case BinaryBitLogicKind.CNonImpl: return cnonimpl;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }
    }
}