//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static BitVectorOps;
    using static OpHelpers;
    using static LogixOpNames;

    /// <summary>
    /// Services for scalar operators
    /// </summary>
    public static class BitVectorOpApi
    {
        /// <summary>
        /// Advertises the supported binary operators
        /// </summary>
        public static ReadOnlySpan<BinaryBitLogicKind> BinaryBitwiseKinds
            => ScalarOpApi.BinaryBitLogicKinds;

        [BitVectorOp(bbl), PrimalClosures(NumericKind.Integers)]
        public static BitVector<T> eval<T>(BinaryBitLogicKind kind, BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitLogicKind.True: return @true(x,y);
                case BinaryBitLogicKind.False: return @false(x,y);
                case BinaryBitLogicKind.And: return and(x,y);
                case BinaryBitLogicKind.Nand: return nand(x,y);
                case BinaryBitLogicKind.Or: return or(x,y);
                case BinaryBitLogicKind.Nor: return nor(x,y);
                case BinaryBitLogicKind.Xor: return xor(x,y);
                case BinaryBitLogicKind.Xnor: return xnor(x,y);
                case BinaryBitLogicKind.LProject: return left(x,y);
                case BinaryBitLogicKind.RProject: return right(x,y);
                case BinaryBitLogicKind.LNot: return lnot(x,y);
                case BinaryBitLogicKind.RNot: return rnot(x,y);
                case BinaryBitLogicKind.Impl: return impl(x,y);                    
                case BinaryBitLogicKind.NonImpl: return nonimpl(x,y);
                case BinaryBitLogicKind.CImpl: return cimpl(x,y);                    
                case BinaryBitLogicKind.CNonImpl: return cnonimpl(x,y);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [BitVectorOp, PrimalClosures(NumericKind.Integers)]
        public static BitVector<T> evalspec<T>(BinaryBitLogicKind kind, BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitLogicKind.True: return @true(x,y);
                case BinaryBitLogicKind.False: return @false(x,y);
                case BinaryBitLogicKind.And: return BitVectorOpSpecs.and(x,y);
                case BinaryBitLogicKind.Nand: return BitVectorOpSpecs.nand(x,y);
                case BinaryBitLogicKind.Or: return BitVectorOpSpecs.or(x,y);
                case BinaryBitLogicKind.Nor: return BitVectorOpSpecs.nor(x,y);
                case BinaryBitLogicKind.Xor: return BitVectorOpSpecs.xor(x,y);
                case BinaryBitLogicKind.Xnor: return BitVectorOpSpecs.xnor(x,y);
                case BinaryBitLogicKind.LProject: return x;
                case BinaryBitLogicKind.RProject: return y;
                case BinaryBitLogicKind.LNot: return BitVectorOpSpecs.lnot(x,y);
                case BinaryBitLogicKind.RNot: return BitVectorOpSpecs.rnot(x,y);
                case BinaryBitLogicKind.Impl: return BitVectorOpSpecs.impl(x,y);                    
                case BinaryBitLogicKind.NonImpl: return BitVectorOpSpecs.nonimpl(x,y);
                case BinaryBitLogicKind.CImpl: return BitVectorOpSpecs.cimpl(x,y);                    
                case BinaryBitLogicKind.CNonImpl: return BitVectorOpSpecs.cnonimpl(x,y);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op(bbl), PrimalClosures(NumericKind.Integers)]
        public static BinaryOp<BitVector<T>> lookup<T>(BinaryBitLogicKind kind)
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
                case BinaryBitLogicKind.RProject: return right;
                case BinaryBitLogicKind.LNot: return lnot;
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
