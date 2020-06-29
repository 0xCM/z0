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

    public class Ops128f
    {
        public static Expression<Func<decimal, decimal>> Abs
            => f((decimal x) => x);

        public static Expression<Func<decimal, decimal, decimal>> Add
            => f<decimal>((x, y) => (decimal)(x + y));

        public static Expression<Func<decimal, decimal, decimal>> Mul
            => f<decimal>((x, y) => (decimal)(x * y));

        public static Expression<Func<decimal, decimal, decimal>> Sub
            => f<decimal>((x, y) => (decimal)(x - y));

        public static Expression<Func<decimal, decimal>> Inc
            => f((decimal x) => ++x);

        public static Expression<Func<decimal, decimal>> Dec
            => f((decimal x) => --x);

        public static Expression<Func<decimal, decimal, bool>> LT
            => f((decimal x, decimal y) => x < y);

        public static Expression<Func<decimal, decimal, bool>> LTEQ
            => f((decimal x, decimal y) => x <= y);

        public static Expression<Func<decimal, decimal, bool>> GT
            => f((decimal x, decimal y) => x > y);

        public static Expression<Func<decimal, decimal, bool>> GTEQ
            => f((decimal x, decimal y) => x >= y);
    }
}