//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;

    using static Root;    
    using static OpHelpers;
    using static BitMatrixOps;

    /// <summary>
    /// Defines services for bitmatrix operators
    /// </summary>
    //[ApiHost("bitmatrix.api",ApiHostKind.Generic)]
    public static class BitMatrixOpApi
    {
        /// <summary>
        /// Advertises the supported unary bitwise operators
        /// </summary>
        public static ReadOnlySpan<UnaryBitLogicOpKind> UnaryBitwiseKinds
            => array(UnaryBitLogicOpKind.Not, UnaryBitLogicOpKind.Identity);

        /// <summary>
        /// Advertises the supported binary bitwise operators
        /// </summary>
        public static ReadOnlySpan<BinaryBitLogicOpKind> BinaryBitwiseKinds
            => NumericOpApi.BinaryBitLogicKinds;

        [Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> eval<T>(UnaryBitLogicOpKind kind, BitMatrix<T> A)
            where T : unmanaged
        {
            switch(kind)
            {
                case UnaryBitLogicOpKind.Not: return not(A);
                case UnaryBitLogicOpKind.Identity: return identity(A);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> eval<T>(UnaryBitLogicOpKind kind, BitMatrix<T> A, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            switch(kind)
            {
                case UnaryBitLogicOpKind.Not: return not(A, ref Z);
                case UnaryBitLogicOpKind.Identity: return identity(A, ref Z);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> eval<T>(BinaryBitLogicOpKind kind, BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitLogicOpKind.True: return @true<T>();
                case BinaryBitLogicOpKind.False: return @false<T>();
                case BinaryBitLogicOpKind.And: return and(A,B);
                case BinaryBitLogicOpKind.Nand: return nand(A,B);
                case BinaryBitLogicOpKind.Or: return or(A,B);
                case BinaryBitLogicOpKind.Nor: return nor(A,B);
                case BinaryBitLogicOpKind.Xor: return xor(A,B);
                case BinaryBitLogicOpKind.Xnor: return xnor(A,B);
                case BinaryBitLogicOpKind.LProject: return left(A,B);
                case BinaryBitLogicOpKind.RProject: return right(A,B);
                case BinaryBitLogicOpKind.LNot: return lnot(A,B);
                case BinaryBitLogicOpKind.RNot: return rnot(A,B);
                case BinaryBitLogicOpKind.Impl: return impl(A,B);
                case BinaryBitLogicOpKind.NonImpl: return nonimpl(A,B);
                case BinaryBitLogicOpKind.CImpl: return cimpl(A,B);
                case BinaryBitLogicOpKind.CNonImpl: return cnonimpl(A,B);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrix<T> eval<T>(BinaryBitLogicOpKind kind, BitMatrix<T> A, BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitLogicOpKind.True: return @true<T>();
                case BinaryBitLogicOpKind.False: return @false<T>();
                case BinaryBitLogicOpKind.And: return and(A, B, ref Z);
                case BinaryBitLogicOpKind.Nand: return nand(A, B, ref Z);
                case BinaryBitLogicOpKind.Or: return or(A, B, ref Z);
                case BinaryBitLogicOpKind.Nor: return nor(A, B, ref Z);
                case BinaryBitLogicOpKind.Xor: return xor(A, B, ref Z);
                case BinaryBitLogicOpKind.Xnor: return xnor(A, B, ref Z);
                case BinaryBitLogicOpKind.LProject: return left(A,B, ref Z);
                case BinaryBitLogicOpKind.LNot: return lnot(A,B, ref Z);
                case BinaryBitLogicOpKind.RProject: return right(A,B, ref Z);
                case BinaryBitLogicOpKind.RNot: return rnot(A, B, ref Z);
                case BinaryBitLogicOpKind.Impl: return impl(A,B, ref Z);
                case BinaryBitLogicOpKind.NonImpl: return nonimpl(A,B, ref Z);
                case BinaryBitLogicOpKind.CImpl: return cimpl(A,B, ref Z);
                case BinaryBitLogicOpKind.CNonImpl: return cnonimpl(A,B, ref Z);
                default: throw new NotSupportedException(sig<T>(kind));
            }

        }

        [Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitMatrixBinaryRefOp<T> lookup<T>(BinaryBitLogicOpKind kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitLogicOpKind.True: return @true;
                case BinaryBitLogicOpKind.False: return @false;
                case BinaryBitLogicOpKind.And: return and;
                case BinaryBitLogicOpKind.Nand: return nand;
                case BinaryBitLogicOpKind.Or: return or;
                case BinaryBitLogicOpKind.Nor: return nor;
                case BinaryBitLogicOpKind.Xor: return xor;
                case BinaryBitLogicOpKind.Xnor: return xnor;
                case BinaryBitLogicOpKind.LProject: return left;
                case BinaryBitLogicOpKind.LNot: return lnot;
                case BinaryBitLogicOpKind.RProject: return right;
                case BinaryBitLogicOpKind.RNot: return rnot;
                case BinaryBitLogicOpKind.Impl: return impl;
                case BinaryBitLogicOpKind.NonImpl: return nonimpl;
                case BinaryBitLogicOpKind.CImpl: return cimpl;
                case BinaryBitLogicOpKind.CNonImpl: return cnonimpl;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }
    }
}