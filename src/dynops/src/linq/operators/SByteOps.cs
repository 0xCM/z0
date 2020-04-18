//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics.Operators
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    using static Seed;
    using static Memories;
    using static XFunc;

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