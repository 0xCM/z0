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

    public class Ops64f
    {
        public static Expression<Func<double, double>> Abs
            => f((double x) => x);

        public static Expression<Func<double, double, double>> Add
            => f<double>((x, y) => (double)(x + y));

        public static Expression<Func<double, double, double>> Mul
            => f<double>((x, y) => (double)(x * y));

        public static Expression<Func<double, double, double>> Sub
            => f<double>((x, y) => (double)(x - y));

        public static Expression<Func<double, double>> Inc
            => f((double x) => ++x);

        public static Expression<Func<double, double>> Dec
            => f((double x) => --x);

        public static Expression<Func<double, double, bool>> LT
            => f((double x, double y) => x < y);

        public static Expression<Func<double, double, bool>> LTEQ
            => f((double x, double y) => x <= y);

        public static Expression<Func<double, double, bool>> GT
            => f((double x, double y) => x > y);

        public static Expression<Func<double, double, bool>> GTEQ
            => f((double x, double y) => x >= y);
    }
}