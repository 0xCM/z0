//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics.Operators
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    using static Konst;
    using static XFunc;

    public static class StringOps
    {
        public static Expression<Func<string, string, bool>> LT
            => f((string x, string y) => x.CompareTo(y) < 0 ? true : false);

        public static Expression<Func<string, string, bool>> LTEQ
            => f((string x, string y) => x.CompareTo(y) <= 0 ? true : false);

        public static Expression<Func<string, string, bool>> GT
            => f((string x, string y) => x.CompareTo(y) > 0 ? true : false);

        public static Expression<Func<string, string, bool>> GTEQ
            => f((string x, string y) => x.CompareTo(y) >= 0 ? true : false);
    }
}