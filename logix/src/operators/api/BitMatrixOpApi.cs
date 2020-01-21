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
        public static IEnumerable<UnaryBitwiseOpKind> UnaryBitwiseKinds
            => items(UnaryBitwiseOpKind.Not, UnaryBitwiseOpKind.Identity);

        /// <summary>
        /// Advertises the supported binary bitwise operators
        /// </summary>
        public static ReadOnlySpan<BinaryBitwiseOpKind> BinaryBitwiseKinds
            => ScalarOpApi.BinaryBitwiseKinds;

        [Op, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> eval<T>(UnaryBitwiseOpKind kind, BitMatrix<T> A)
            where T : unmanaged
        {
            switch(kind)
            {
                case UnaryBitwiseOpKind.Not: return not(A);
                case UnaryBitwiseOpKind.Identity: return identity(A);
                default: return dne(kind,A);
            }
        }

        [BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> eval<T>(UnaryBitwiseOpKind kind, BitMatrix<T> A, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            switch(kind)
            {
                case UnaryBitwiseOpKind.Not: return not(A, ref Z);
                case UnaryBitwiseOpKind.Identity: return identity(A, ref Z);
                default: return dne(kind,A);
            }
        }

        [BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> eval<T>(BinaryBitwiseOpKind kind, BitMatrix<T> A, BitMatrix<T> B)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitwiseOpKind.True: return @true<T>();
                case BinaryBitwiseOpKind.False: return @false<T>();
                case BinaryBitwiseOpKind.And: return and(A,B);
                case BinaryBitwiseOpKind.Nand: return nand(A,B);
                case BinaryBitwiseOpKind.Or: return or(A,B);
                case BinaryBitwiseOpKind.Nor: return nor(A,B);
                case BinaryBitwiseOpKind.XOr: return xor(A,B);
                case BinaryBitwiseOpKind.Xnor: return xnor(A,B);
                case BinaryBitwiseOpKind.LeftProject: return left(A,B);
                case BinaryBitwiseOpKind.RightProject: return right(A,B);
                case BinaryBitwiseOpKind.LeftNot: return lnot(A,B);
                case BinaryBitwiseOpKind.RightNot: return rnot(A,B);
                case BinaryBitwiseOpKind.Implication: return impl(A,B);
                case BinaryBitwiseOpKind.Nonimplication: return nonimpl(A,B);
                case BinaryBitwiseOpKind.ConverseImplication: return cimpl(A,B);
                case BinaryBitwiseOpKind.ConverseNonimplication: return cnonimpl(A,B);
                default: return dne(kind,A,B);
            }
        }

        [BitMatrixOp, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrix<T> eval<T>(BinaryBitwiseOpKind kind, BitMatrix<T> A, BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitwiseOpKind.True: return @true<T>();
                case BinaryBitwiseOpKind.False: return @false<T>();
                case BinaryBitwiseOpKind.And: return and(A, B, ref Z);
                case BinaryBitwiseOpKind.Nand: return nand(A, B, ref Z);
                case BinaryBitwiseOpKind.Or: return or(A, B, ref Z);
                case BinaryBitwiseOpKind.Nor: return nor(A, B, ref Z);
                case BinaryBitwiseOpKind.XOr: return xor(A, B, ref Z);
                case BinaryBitwiseOpKind.Xnor: return xnor(A, B, ref Z);
                case BinaryBitwiseOpKind.LeftProject: return left(A,B, ref Z);
                case BinaryBitwiseOpKind.LeftNot: return lnot(A,B, ref Z);
                case BinaryBitwiseOpKind.RightProject: return right(A,B, ref Z);
                case BinaryBitwiseOpKind.RightNot: return rnot(A, B, ref Z);
                case BinaryBitwiseOpKind.Implication: return impl(A,B, ref Z);
                case BinaryBitwiseOpKind.Nonimplication: return nonimpl(A,B, ref Z);
                case BinaryBitwiseOpKind.ConverseImplication: return cimpl(A,B, ref Z);
                case BinaryBitwiseOpKind.ConverseNonimplication: return cnonimpl(A,B, ref Z);
                default: return dne(kind,A,B);
            }

        }

        [Op, PrimalClosures(PrimalKind.Integers)]
        public static BitMatrixBinaryRefOp<T> lookup<T>(BinaryBitwiseOpKind kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitwiseOpKind.True: return @true;
                case BinaryBitwiseOpKind.False: return @false;
                case BinaryBitwiseOpKind.And: return and;
                case BinaryBitwiseOpKind.Nand: return nand;
                case BinaryBitwiseOpKind.Or: return or;
                case BinaryBitwiseOpKind.Nor: return nor;
                case BinaryBitwiseOpKind.XOr: return xor;
                case BinaryBitwiseOpKind.Xnor: return xnor;
                case BinaryBitwiseOpKind.LeftProject: return left;
                case BinaryBitwiseOpKind.LeftNot: return lnot;
                case BinaryBitwiseOpKind.RightProject: return right;
                case BinaryBitwiseOpKind.RightNot: return rnot;
                case BinaryBitwiseOpKind.Implication: return impl;
                case BinaryBitwiseOpKind.Nonimplication: return nonimpl;
                case BinaryBitwiseOpKind.ConverseImplication: return cimpl;
                case BinaryBitwiseOpKind.ConverseNonimplication: return cnonimpl;
                default: return nomareftop<T>(kind);
            }

        }

        static BitMatrix<T> dne<T,E>(E kind,BitMatrix<T> A, BitMatrix<T> B = default)
            where T : unmanaged
            where E : unmanaged, Enum
                =>  throw new NotSupportedException($"{kind}");

    }
}