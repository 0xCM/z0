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

    using BCK = BinaryComparisonKind;

    public static class PredicateApi
    {
        /// <summary>
        /// Specifies the supported comparison predicates
        /// </summary>
        public static ReadOnlySpan<BCK> ComparisonKinds
            => array(
                BCK.Eq, BCK.Neq, 
                BCK.Lt, BCK.LtEq, 
                BCK.Gt, BCK.GtEq );


        [Op, Closures(Integers)]
        public static bit eval<T>(BCK kind, T a, T b)
            where T : unmanaged            
        {
            switch(kind)
            {
                case BCK.Eq: return gmath.eq(a,b);
                case BCK.Neq: return gmath.neq(a,b);
                case BCK.Lt: return gmath.lt(a,b);
                case BCK.LtEq: return gmath.lteq(a,b);
                case BCK.Gt: return gmath.gt(a,b);
                case BCK.GtEq: return gmath.gteq(a,b);
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }

        [Op, Closures(Integers)]
        public static BinaryPred<T> lookup<T>(BCK kind)
            where T : unmanaged            
        {
            switch(kind)
            {
                case BCK.Eq: return gmath.eq;
                case BCK.Neq: return gmath.neq;
                case BCK.Lt: return gmath.lt;
                case BCK.LtEq: return gmath.lteq;
                case BCK.Gt: return gmath.gt;
                case BCK.GtEq: return gmath.gteq;
                default: throw Unsupported.define<T>(sig<T>(kind));
            }
        }
    }
}