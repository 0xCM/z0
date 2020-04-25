//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static LogicSig;
    using static BitLogix;

    using BLK = BinaryLogicKind;

    partial class BitLogixOps
    {
        /// <summary>
        /// Evaluates a binary operator without lookup/delegate indirection
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        public static bit eval(BLK kind, bit a, bit b)
        {
            switch(kind)
            {
                case BLK.True: return @true(a,b);
                case BLK.False: return @false(a,b);

                case BLK.And: return and(a,b);
                case BLK.Nand: return nand(a,b);

                case BLK.Or: return or(a,b);
                case BLK.Nor: return nor(a,b);

                case BLK.Xor: return xor(a,b);
                case BLK.Xnor: return xnor(a,b);

                case BLK.Impl: return impl(a,b); 
                case BLK.NonImpl: return nonimpl(a,b);

                case BLK.LProject: return left(a,b);
                case BLK.RProject: return right(a,b);

                case BLK.LNot: return lnot(a,b);
                case BLK.RNot: return rnot(a,b);
                
                case BLK.CImpl: return cimpl(a,b);
                case BLK.CNonImpl: return cnonimpl(a,b);

                default: throw Unsupported.value(sig(kind));
            }
        }
    }
}