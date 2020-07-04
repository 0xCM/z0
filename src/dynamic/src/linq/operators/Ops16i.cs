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

    public class Ops16i
    {
        public static Expression<Func<short, short>> Abs
            => f((short x) => x);

        public static Expression<Func<short, short, short>> Add
            => f<short>((x, y) => (short)(x + y));

        public static Expression<Func<short, short, short>> Mul
            => f<short>((x, y) => (short)(x * y));

        public static Expression<Func<short, short, short>> Sub
            => f<short>((x, y) => (short)(x - y));

        public static Expression<Func<short, short>> Inc
            => f((short x) => ++x);

        public static Expression<Func<short, short>> Dec
            => f((short x) => --x);

        public static Expression<Func<short, short, bool>> LT
            => f((short x, short y) => x < y);

        public static Expression<Func<short, short, bool>> LTEQ
            => f((short x, short y) => x <= y);

        public static Expression<Func<short, short, bool>> GT
            => f((short x, short y) => x > y);

        public static Expression<Func<short, short, bool>> GTEQ
            => f((short x, short y) => x >= y);
    }
}