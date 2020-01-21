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

    /// <summary>
    /// Services for scalar operators
    /// </summary>
    public static class BitVectorOpApi
    {
        /// <summary>
        /// Advertises the supported binary operators
        /// </summary>
        public static ReadOnlySpan<BinaryBitLogicKind> BinaryBitwiseKinds
            => ScalarOpApi.BinaryBitwiseKinds;

        [BitVectorOp, PrimalClosures(PrimalKind.Integers)]
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
                case BinaryBitLogicKind.XOr: return xor(x,y);
                case BinaryBitLogicKind.Xnor: return xnor(x,y);
                case BinaryBitLogicKind.LeftProject: return left(x,y);
                case BinaryBitLogicKind.RightProject: return right(x,y);
                case BinaryBitLogicKind.LeftNot: return lnot(x,y);
                case BinaryBitLogicKind.RightNot: return rnot(x,y);
                case BinaryBitLogicKind.Implication: return impl(x,y);                    
                case BinaryBitLogicKind.Nonimplication: return nonimpl(x,y);
                case BinaryBitLogicKind.ConverseImplication: return cimpl(x,y);                    
                case BinaryBitLogicKind.ConverseNonimplication: return cnonimpl(x,y);
                default: return dne<BinaryBitLogicKind,T>(kind);
            }
        }

        [BitVectorOp, PrimalClosures(PrimalKind.Integers)]
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
                case BinaryBitLogicKind.XOr: return BitVectorOpSpecs.xor(x,y);
                case BinaryBitLogicKind.Xnor: return BitVectorOpSpecs.xnor(x,y);
                case BinaryBitLogicKind.LeftProject: return x;
                case BinaryBitLogicKind.RightProject: return y;
                case BinaryBitLogicKind.LeftNot: return BitVectorOpSpecs.lnot(x,y);
                case BinaryBitLogicKind.RightNot: return BitVectorOpSpecs.rnot(x,y);
                case BinaryBitLogicKind.Implication: return BitVectorOpSpecs.impl(x,y);                    
                case BinaryBitLogicKind.Nonimplication: return BitVectorOpSpecs.nonimpl(x,y);
                case BinaryBitLogicKind.ConverseImplication: return BitVectorOpSpecs.cimpl(x,y);                    
                case BinaryBitLogicKind.ConverseNonimplication: return BitVectorOpSpecs.cnonimpl(x,y);
                default: return dne<BinaryBitLogicKind,T>(kind);
            }
        }

        [Op, PrimalClosures(PrimalKind.Integers)]
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
                case BinaryBitLogicKind.XOr: return xor;
                case BinaryBitLogicKind.Xnor: return xnor;
                case BinaryBitLogicKind.LeftProject: return left;
                case BinaryBitLogicKind.RightProject: return right;
                case BinaryBitLogicKind.LeftNot: return lnot;
                case BinaryBitLogicKind.RightNot: return rnot;
                case BinaryBitLogicKind.Implication: return impl;
                case BinaryBitLogicKind.Nonimplication: return nonimpl;
                case BinaryBitLogicKind.ConverseImplication: return cimpl;
                case BinaryBitLogicKind.ConverseNonimplication: return cnonimpl;
                default: return dne<BitVector<T>>(kind);
            }
        }
    }
}
