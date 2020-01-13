//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    using static OpHelpers;

    public static class PredicateApi
    {
        /// <summary>
        /// Specifies the supported comparison predicates
        /// </summary>
        public static ComparisonKind[] ComparisonKinds
            => new ComparisonKind[]{
                ComparisonKind.Eq, ComparisonKind.Neq, 
                ComparisonKind.Lt, ComparisonKind.LtEq, 
                ComparisonKind.Gt, ComparisonKind.GtEq, 
            };

        public static bit eval<T>(ComparisonKind kind, T a, T b)
            where T : unmanaged            
        {
            switch(kind)
            {
                case ComparisonKind.Eq: return gmath.eq(a,b);
                case ComparisonKind.Neq: return gmath.neq(a,b);
                case ComparisonKind.Lt: return gmath.lt(a,b);
                case ComparisonKind.LtEq: return gmath.lteq(a,b);
                case ComparisonKind.Gt: return gmath.gt(a,b);
                case ComparisonKind.GtEq: return gmath.gteq(a,b);
                default: return dne<ComparisonKind,bit>(kind);
            }
        }

        public static BinaryPred<T> lookup<T>(ComparisonKind kind)
            where T : unmanaged            
        {
            switch(kind)
            {
                case ComparisonKind.Eq: return gmath.eq;
                case ComparisonKind.Neq: return gmath.neq;
                case ComparisonKind.Lt: return gmath.lt;
                case ComparisonKind.LtEq: return gmath.lteq;
                case ComparisonKind.Gt: return gmath.gt;
                case ComparisonKind.GtEq: return gmath.gteq;
                default: return dne<ComparisonKind,BinaryPred<T>>(kind);
            }
        }


    }

}