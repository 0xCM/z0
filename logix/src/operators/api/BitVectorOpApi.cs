//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static BitVectorOps;
    using static OpHelpers;

    //[ApiHost("bitvector.api", ApiHostKind.Generic)]
    public static class BitVectorOpApi
    {
        /// <summary>
        /// Advertises the supported binary operators
        /// </summary>
        public static ReadOnlySpan<BinaryBitLogicOpKind> BinaryBitwiseKinds
            => NumericOpApi.BinaryBitLogicKinds;

        [Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> eval<T>(BinaryBitLogicOpKind kind, BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitLogicOpKind.True: return @true(x,y);
                case BinaryBitLogicOpKind.False: return @false(x,y);
                case BinaryBitLogicOpKind.And: return and(x,y);
                case BinaryBitLogicOpKind.Nand: return nand(x,y);
                case BinaryBitLogicOpKind.Or: return or(x,y);
                case BinaryBitLogicOpKind.Nor: return nor(x,y);
                case BinaryBitLogicOpKind.Xor: return xor(x,y);
                case BinaryBitLogicOpKind.Xnor: return xnor(x,y);
                case BinaryBitLogicOpKind.LProject: return left(x,y);
                case BinaryBitLogicOpKind.RProject: return right(x,y);
                case BinaryBitLogicOpKind.LNot: return lnot(x,y);
                case BinaryBitLogicOpKind.RNot: return rnot(x,y);
                case BinaryBitLogicOpKind.Impl: return impl(x,y);                    
                case BinaryBitLogicOpKind.NonImpl: return nonimpl(x,y);
                case BinaryBitLogicOpKind.CImpl: return cimpl(x,y);                    
                case BinaryBitLogicOpKind.CNonImpl: return cnonimpl(x,y);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BitVector<T> evalspec<T>(BinaryBitLogicOpKind kind, BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitLogicOpKind.True: return @true(x,y);
                case BinaryBitLogicOpKind.False: return @false(x,y);
                case BinaryBitLogicOpKind.And: return BitVectorOpSpecs.and(x,y);
                case BinaryBitLogicOpKind.Nand: return BitVectorOpSpecs.nand(x,y);
                case BinaryBitLogicOpKind.Or: return BitVectorOpSpecs.or(x,y);
                case BinaryBitLogicOpKind.Nor: return BitVectorOpSpecs.nor(x,y);
                case BinaryBitLogicOpKind.Xor: return BitVectorOpSpecs.xor(x,y);
                case BinaryBitLogicOpKind.Xnor: return BitVectorOpSpecs.xnor(x,y);
                case BinaryBitLogicOpKind.LProject: return x;
                case BinaryBitLogicOpKind.RProject: return y;
                case BinaryBitLogicOpKind.LNot: return BitVectorOpSpecs.lnot(x,y);
                case BinaryBitLogicOpKind.RNot: return BitVectorOpSpecs.rnot(x,y);
                case BinaryBitLogicOpKind.Impl: return BitVectorOpSpecs.impl(x,y);                    
                case BinaryBitLogicOpKind.NonImpl: return BitVectorOpSpecs.nonimpl(x,y);
                case BinaryBitLogicOpKind.CImpl: return BitVectorOpSpecs.cimpl(x,y);                    
                case BinaryBitLogicOpKind.CNonImpl: return BitVectorOpSpecs.cnonimpl(x,y);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(NumericKind.UnsignedInts)]
        public static BinaryOp<BitVector<T>> lookup<T>(BinaryBitLogicOpKind kind)
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
                case BinaryBitLogicOpKind.RProject: return right;
                case BinaryBitLogicOpKind.LNot: return lnot;
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