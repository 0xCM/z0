//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Security;

    using static Seed;    
    using static Memories;
    using static LogicSig;

    using BCK = BinaryComparisonKind;


    public static class PredicateApi
    {
        [Op, NumericClosures(Integers)]
        public static T eval<T>(BinaryComparisonKind kind, T a, T b)
            where T : unmanaged            
        {
            switch(kind)
            {
                case BCK.Eq: return NumericBits.equals(a,b);
                case BCK.Neq: return NumericBits.neq(a,b);
                case BCK.Lt: return NumericBits.lt(a,b);
                case BCK.LtEq: return NumericBits.lteq(a,b);
                case BCK.Gt: return NumericBits.gt(a,b);
                case BCK.GtEq: return NumericBits.gteq(a,b);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(AllNumeric)]
        public static BinaryOp<T> lookup<T>(BCK kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BCK.Eq: return NumericBits.equals;
                case BCK.Neq: return NumericBits.neq;
                case BCK.Lt: return NumericBits.lt;
                case BCK.LtEq: return NumericBits.lteq;
                case BCK.Gt: return NumericBits.gt;
                case BCK.GtEq: return NumericBits.gteq;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }


    }
}