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

    public static class SByteOps
    {
        public static Expression<Func<sbyte, sbyte>> Abs
            => f((sbyte x) => x < 0 ? (sbyte) -x : x);

        public static Expression<Func<sbyte, sbyte, sbyte>> Add
            => f<sbyte>((x, y) => (sbyte)(x + y));

        public static Expression<Func<sbyte, sbyte, sbyte>> Mul
            => f<sbyte>((x, y) => (sbyte)(x * y));

        public static Expression<Func<sbyte, sbyte, sbyte>> Sub
            => f<sbyte>((x, y) => (sbyte)(x - y));

        public static Expression<Func<sbyte, sbyte>> Inc
            => f((sbyte x) => ++x);

        public static Expression<Func<sbyte, sbyte>> Dec
            => f((sbyte x) => --x);

        public static Expression<Func<sbyte, sbyte, bool>> GT
            => f((sbyte x, sbyte y) => x > y);

        public static Expression<Func<sbyte, sbyte, bool>> GTEQ
            => f((sbyte x, sbyte y) => x >= y);

        public static Expression<Func<sbyte, sbyte, bool>> LT
            => f((sbyte x, sbyte y) => x < y);

        public static Expression<Func<sbyte, sbyte, bool>> LTEQ
            => f((sbyte x, sbyte y) => x <= y);
    }
}