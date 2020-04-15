//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static BitVectorOps;
    using static OpHelpers;

    using BLK = BinaryLogicKind;
    using BVS = BitVectorOpSpecs;

    //[ApiHost("bitvector.api", ApiHostKind.Generic)]
    public static class BitVectorOpApi
    {
        /// <summary>
        /// Advertises the supported binary operators
        /// </summary>
        public static ReadOnlySpan<BLK> BinaryBitwiseKinds
            => NumericOpApi.BinaryLogicKinds;

        [Op, Closures(UnsignedInts)]
        public static BitVector<T> eval<T>(BLK kind, BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            switch(kind)
            {
                case BLK.True: return @true(x,y);
                case BLK.False: return @false(x,y);
                case BLK.And: return and(x,y);
                case BLK.Nand: return nand(x,y);
                case BLK.Or: return or(x,y);
                case BLK.Nor: return nor(x,y);
                case BLK.Xor: return xor(x,y);
                case BLK.Xnor: return xnor(x,y);
                case BLK.LProject: return left(x,y);
                case BLK.RProject: return right(x,y);
                case BLK.LNot: return lnot(x,y);
                case BLK.RNot: return rnot(x,y);
                case BLK.Impl: return impl(x,y);                    
                case BLK.NonImpl: return nonimpl(x,y);
                case BLK.CImpl: return cimpl(x,y);                    
                case BLK.CNonImpl: return cnonimpl(x,y);
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        [Op, Closures(UnsignedInts)]
        public static BitVector<T> evalspec<T>(BLK kind, BitVector<T> x, BitVector<T> y)
            where T : unmanaged
        {
            switch(kind)
            {
                case BLK.True: return @true(x,y);
                case BLK.False: return @false(x,y);
                case BLK.And: return BVS.and(x,y);
                case BLK.Nand: return BVS.nand(x,y);
                case BLK.Or: return BVS.or(x,y);
                case BLK.Nor: return BVS.nor(x,y);
                case BLK.Xor: return BVS.xor(x,y);
                case BLK.Xnor: return BVS.xnor(x,y);
                case BLK.LProject: return x;
                case BLK.RProject: return y;
                case BLK.LNot: return BVS.lnot(x,y);
                case BLK.RNot: return BVS.rnot(x,y);
                case BLK.Impl: return BVS.impl(x,y);                    
                case BLK.NonImpl: return BVS.nonimpl(x,y);
                case BLK.CImpl: return BVS.cimpl(x,y);                    
                case BLK.CNonImpl: return BVS.cnonimpl(x,y);
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        [Op, Closures(UnsignedInts)]
        public static BinaryOp<BitVector<T>> lookup<T>(BLK kind)
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
                case BLK.RProject: return right;
                case BLK.LNot: return lnot;
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