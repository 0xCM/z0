//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
                case BinaryBitwiseOpKind.Implication: return imply(x,y);                    
                case BinaryBitwiseOpKind.Nonimplication: return notimply(x,y);
                case BinaryBitwiseOpKind.ConverseImplication: return cimply(x,y);                    
                case BinaryBitwiseOpKind.ConverseNonimplication: return cnotimply(x,y);
                default: return dne<BinaryBitwiseOpKind,T>(kind);
            }
        }

        public static BitVector<T> evalref<T>(BinaryBitwiseOpKind kind, BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            switch(kind)
            {
                case BinaryBitwiseOpKind.True: return @true(x,y);
                case BinaryBitwiseOpKind.False: return @false(x,y);
                case BinaryBitwiseOpKind.And: return and_ref(x,y);
                case BinaryBitwiseOpKind.Nand: return nand_ref(x,y);
                case BinaryBitwiseOpKind.Or: return or_ref(x,y);
                case BinaryBitwiseOpKind.Nor: return nor_ref(x,y);
                case BinaryBitwiseOpKind.XOr: return xor_ref(x,y);
                case BinaryBitwiseOpKind.Xnor: return xnor_ref(x,y);
                case BinaryBitwiseOpKind.LeftProject: return left(x,y);
                case BinaryBitwiseOpKind.RightProject: return right(x,y);
                case BinaryBitwiseOpKind.LeftNot: return lnot_ref(x,y);
                case BinaryBitwiseOpKind.RightNot: return rnot_ref(x,y);
                case BinaryBitwiseOpKind.Implication: return imply_ref(x,y);                    
                case BinaryBitwiseOpKind.Nonimplication: return notimply_ref(x,y);
                case BinaryBitwiseOpKind.ConverseImplication: return cimply_ref(x,y);                    
                case BinaryBitwiseOpKind.ConverseNonimplication: return cnotimply_ref(x,y);
                default: return dne<BinaryBitwiseOpKind,T>(kind);
            }
        }

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
                case BinaryBitwiseOpKind.Implication: return imply;
                case BinaryBitwiseOpKind.Nonimplication: return notimply;
                case BinaryBitwiseOpKind.ConverseImplication: return cimply;
                case BinaryBitwiseOpKind.ConverseNonimplication: return cnotimply;
                default: return dne<BitVector<T>>(kind);
            }
        }


    }

}
