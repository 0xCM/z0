//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
namespace Meta.Core.Operators
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    using Z0;
    using static Z0.Seed;
    using static Z0.Memories;
    using static Z0.XFunc;

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