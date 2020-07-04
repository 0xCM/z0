﻿//-----------------------------------------------------------------------------
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

    public class Ops32i
    {
        public static Expression<Func<int, int>> Abs
            => f((int x) => x);

        public static Expression<Func<int, int, int>> Add
            => f<int>((x, y) => (int)(x + y));

        public static Expression<Func<int, int, int>> Mul
            => f<int>((x, y) => (int)(x * y));

        public static Expression<Func<int, int, int>> Sub
            => f<int>((x, y) => (int)(x - y));

        public static Expression<Func<int, int>> Inc
            => f((int x) => ++x);

        public static Expression<Func<int, int>> Dec
            => f((int x) => --x);

        public static Expression<Func<int, int, bool>> LT
            => f((int x, int y) => x < y);

        public static Expression<Func<int, int, bool>> LTEQ
            => f((int x, int y) => x <= y);

        public static Expression<Func<int, int, bool>> GT
            => f((int x, int y) => x > y);

        public static Expression<Func<int, int, bool>> GTEQ
            => f((int x, int y) => x >= y);
    }
}