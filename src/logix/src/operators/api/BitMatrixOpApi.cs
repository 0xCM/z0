//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;

    using static Seed;    
    using static Memories;
    using static OpHelpers;
    using static BitMatrixOps;

    using ULK = UnaryLogicKind;
    using BLK = BinaryLogicKind;
    using TLK = TernaryLogicKind;

    /// <summary>
    /// Defines services for bitmatrix operators
    /// </summary>
    //[ApiHost("bitmatrix.api",ApiHostKind.Generic)]
    public static class BitMatrixOpApi
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
    }
}