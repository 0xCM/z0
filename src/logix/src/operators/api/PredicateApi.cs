//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Security;

    using static Konst;    
    using static Memories;
    using static LogicSig;

    using BCK = BinaryComparisonKind;

    [ApiHost]
    public readonly struct PredicateApi
    {
        [Op, NumericClosures(Integers)]
        public static T eval<T>(BinaryComparisonKind kind, T a, T b)
            where T : unmanaged            
        {
            switch(kind)
            {
                case BCK.Eq: return NumericLogix.equals(a,b);
                case BCK.Neq: return NumericLogix.neq(a,b);
                case BCK.Lt: return NumericLogix.lt(a,b);
                case BCK.LtEq: return NumericLogix.lteq(a,b);
                case BCK.Gt: return NumericLogix.gt(a,b);
                case BCK.GtEq: return NumericLogix.gteq(a,b);
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }

        [Op, NumericClosures(AllNumeric)]
        public static BinaryOp<T> lookup<T>(BCK kind)
            where T : unmanaged
        {
            switch(kind)
            {
                case BCK.Eq: return NumericLogix.equals;
                case BCK.Neq: return NumericLogix.neq;
                case BCK.Lt: return NumericLogix.lt;
                case BCK.LtEq: return NumericLogix.lteq;
                case BCK.Gt: return NumericLogix.gt;
                case BCK.GtEq: return NumericLogix.gteq;
                default: throw new NotSupportedException(sig<T>(kind));
            }
        }
    }
}