//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;

    using static Predicates;
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
                case ComparisonKind.Eq: return equals(a,b);
                case ComparisonKind.Neq: return neq(a,b);
                case ComparisonKind.Lt: return lt(a,b);
                case ComparisonKind.LtEq: return lteq(a,b);
                case ComparisonKind.Gt: return gt(a,b);
                case ComparisonKind.GtEq: return gteq(a,b);
                default: return dne<ComparisonKind,bit>(kind);
            }
        }

        public static BinaryPred<T> lookup<T>(ComparisonKind kind)
            where T : unmanaged            
        {
            switch(kind)
            {
                case ComparisonKind.Eq: return equals;
                case ComparisonKind.Neq: return neq;
                case ComparisonKind.Lt: return lt;
                case ComparisonKind.LtEq: return lteq;
                case ComparisonKind.Gt: return gt;
                case ComparisonKind.GtEq: return gteq;
                default: return dne<ComparisonKind,BinaryPred<T>>(kind);
            }
        }


    }

}