//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;

    using static zfunc;    
    using static As;
    using static OpHelpers;
    using static BitMatrixOps;

    public delegate ref BitMatrix<T> BitMatrixUnaryRefOp<T>(in BitMatrix<T> A, ref BitMatrix<T> Z)
        where T : unmanaged;

    public delegate ref BitMatrix<T> BitMatrixBinaryRefOp<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
        where T : unmanaged;

    /// <summary>
    /// Defines services for bitmatrix operators
    /// </summary>
    public static class BitMatrixOpApi
    {
        /// <summary>
        /// Advertises the supported unary bitwise operators
        /// </summary>
        public static IEnumerable<UnaryBitLogicKind> UnaryBitwiseKinds
            => items(UnaryBitLogicKind.Not, UnaryBitLogicKind.Identity);

        /// <summary>
        /// Advertises the supported binary bitwise operators
        /// </summary>
        public static ReadOnlySpan<BinaryBitLogicKind> BinaryBitwiseKinds
            => ScalarOpApi.BinaryBitwiseKinds;

        [Op, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> eval<T>(UnaryBitLogicKind kind, BitMatrix<T> A)
            where T : unmanaged
        {
            switch(kind)
            {
                case UnaryBitLogicKind.Not: return not(A);
                case UnaryBitLogicKind.Identity: return identity(A);
                default: return dne(kind,A);
            }
        }

        [BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> eval<T>(UnaryBitLogicKind kind, BitMatrix<T> A, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            switch(kind)
            {
                case UnaryBitLogicKind.Not: return not(A, ref Z);
                case UnaryBitLogicKind.Identity: return identity(A, ref Z);
                default: return dne(kind,A);
            }
        }

        [BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
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
                case BinaryBitLogicKind.XOr: return xor(A,B);
                case BinaryBitLogicKind.Xnor: return xnor(A,B);
                case BinaryBitLogicKind.LeftProject: return left(A,B);
                case BinaryBitLogicKind.RightProject: return right(A,B);
                case BinaryBitLogicKind.LeftNot: return lnot(A,B);
                case BinaryBitLogicKind.RightNot: return rnot(A,B);
                case BinaryBitLogicKind.Implication: return impl(A,B);
                case BinaryBitLogicKind.Nonimplication: return nonimpl(A,B);
                case BinaryBitLogicKind.ConverseImplication: return cimpl(A,B);
                case BinaryBitLogicKind.ConverseNonimplication: return cnonimpl(A,B);
                default: return dne(kind,A,B);
            }
        }

        [BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
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
                case BinaryBitLogicKind.XOr: return xor(A, B, ref Z);
                case BinaryBitLogicKind.Xnor: return xnor(A, B, ref Z);
                case BinaryBitLogicKind.LeftProject: return left(A,B, ref Z);
                case BinaryBitLogicKind.LeftNot: return lnot(A,B, ref Z);
                case BinaryBitLogicKind.RightProject: return right(A,B, ref Z);
                case BinaryBitLogicKind.RightNot: return rnot(A, B, ref Z);
                case BinaryBitLogicKind.Implication: return impl(A,B, ref Z);
                case BinaryBitLogicKind.Nonimplication: return nonimpl(A,B, ref Z);
                case BinaryBitLogicKind.ConverseImplication: return cimpl(A,B, ref Z);
                case BinaryBitLogicKind.ConverseNonimplication: return cnonimpl(A,B, ref Z);
                default: return dne(kind,A,B);
            }

        }

        [Op, PrimalClosures(PrimalKind.Integers)]
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
                case BinaryBitLogicKind.XOr: return xor;
                case BinaryBitLogicKind.Xnor: return xnor;
                case BinaryBitLogicKind.LeftProject: return left;
                case BinaryBitLogicKind.LeftNot: return lnot;
                case BinaryBitLogicKind.RightProject: return right;
                case BinaryBitLogicKind.RightNot: return rnot;
                case BinaryBitLogicKind.Implication: return impl;
                case BinaryBitLogicKind.Nonimplication: return nonimpl;
                case BinaryBitLogicKind.ConverseImplication: return cimpl;
                case BinaryBitLogicKind.ConverseNonimplication: return cnonimpl;
                default: return nomareftop<T>(kind);
            }

        }

        static BitMatrix<T> dne<T,E>(E kind,BitMatrix<T> A, BitMatrix<T> B = default)
            where T : unmanaged
            where E : unmanaged, Enum
                =>  throw new NotSupportedException($"{kind}");

    }
}