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
        public static ReadOnlySpan<BinaryBitwiseOpKind> BinaryBitwiseKinds
            => ScalarOpApi.BinaryBitwiseKinds;

        [BitVectorOp, PrimalClosures(PrimalKind.Integers)]
        public static BitVector<T> eval<T>(BinaryBitwiseOpKind kind, BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitwiseOpKind.True: return @true(x,y);
                case BinaryBitwiseOpKind.False: return @false(x,y);
                case BinaryBitwiseOpKind.And: return and(x,y);
                case BinaryBitwiseOpKind.Nand: return nand(x,y);
                case BinaryBitwiseOpKind.Or: return or(x,y);
                case BinaryBitwiseOpKind.Nor: return nor(x,y);
                case BinaryBitwiseOpKind.XOr: return xor(x,y);
                case BinaryBitwiseOpKind.Xnor: return xnor(x,y);
                case BinaryBitwiseOpKind.LeftProject: return left(x,y);
                case BinaryBitwiseOpKind.RightProject: return right(x,y);
                case BinaryBitwiseOpKind.LeftNot: return lnot(x,y);
                case BinaryBitwiseOpKind.RightNot: return rnot(x,y);
                case BinaryBitwiseOpKind.Implication: return impl(x,y);                    
                case BinaryBitwiseOpKind.Nonimplication: return nonimpl(x,y);
                case BinaryBitwiseOpKind.ConverseImplication: return cimpl(x,y);                    
                case BinaryBitwiseOpKind.ConverseNonimplication: return cnonimpl(x,y);
                default: return dne<BinaryBitwiseOpKind,T>(kind);
            }
        }

        [BitVectorOp, PrimalClosures(PrimalKind.Integers)]
        public static BitVector<T> evalspec<T>(BinaryBitwiseOpKind kind, BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitwiseOpKind.True: return @true(x,y);
                case BinaryBitwiseOpKind.False: return @false(x,y);
                case BinaryBitwiseOpKind.And: return BitVectorOpSpecs.and(x,y);
                case BinaryBitwiseOpKind.Nand: return BitVectorOpSpecs.nand(x,y);
                case BinaryBitwiseOpKind.Or: return BitVectorOpSpecs.or(x,y);
                case BinaryBitwiseOpKind.Nor: return BitVectorOpSpecs.nor(x,y);
                case BinaryBitwiseOpKind.XOr: return BitVectorOpSpecs.xor(x,y);
                case BinaryBitwiseOpKind.Xnor: return BitVectorOpSpecs.xnor(x,y);
                case BinaryBitwiseOpKind.LeftProject: return x;
                case BinaryBitwiseOpKind.RightProject: return y;
                case BinaryBitwiseOpKind.LeftNot: return BitVectorOpSpecs.lnot(x,y);
                case BinaryBitwiseOpKind.RightNot: return BitVectorOpSpecs.rnot(x,y);
                case BinaryBitwiseOpKind.Implication: return BitVectorOpSpecs.impl(x,y);                    
                case BinaryBitwiseOpKind.Nonimplication: return BitVectorOpSpecs.nonimpl(x,y);
                case BinaryBitwiseOpKind.ConverseImplication: return BitVectorOpSpecs.cimpl(x,y);                    
                case BinaryBitwiseOpKind.ConverseNonimplication: return BitVectorOpSpecs.cnonimpl(x,y);
                default: return dne<BinaryBitwiseOpKind,T>(kind);
            }
        }

        [Op, PrimalClosures(PrimalKind.Integers)]
        public static BinaryOp<BitVector<T>> lookup<T>(BinaryBitwiseOpKind kind)
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
                case BinaryBitwiseOpKind.RightProject: return right;
                case BinaryBitwiseOpKind.LeftNot: return lnot;
                case BinaryBitwiseOpKind.RightNot: return rnot;
                case BinaryBitwiseOpKind.Implication: return impl;
                case BinaryBitwiseOpKind.Nonimplication: return nonimpl;
                case BinaryBitwiseOpKind.ConverseImplication: return cimpl;
                case BinaryBitwiseOpKind.ConverseNonimplication: return cnonimpl;
                default: return dne<BitVector<T>>(kind);
            }
        }
    }
}
