//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

namespace Z0.Dynamics.Operators
{
    using System;
    using System.Linq.Expressions;

    using static LinqXFunc;

    public class Ops16u
    {
        public static Expression<Func<ushort, ushort>> Abs
            => f((ushort x) => x);

        public static Expression<Func<ushort, ushort, ushort>> Add
            => f<ushort>((x, y) => (ushort)(x + y));

        public static Expression<Func<ushort, ushort, ushort>> Mul
            => f<ushort>((x, y) => (ushort)(x * y));

        public static Expression<Func<ushort, ushort, ushort>> Sub
            => f<ushort>((x, y) => (ushort)(x - y));

        public static Expression<Func<ushort,ushort,ushort>> And
            => f<ushort>((x, y) => (ushort)(x & y));

        public static Expression<Func<ushort,ushort,ushort>> Or
            => f<ushort>((x, y) => (ushort)(x | y));

        public static Func<ushort,ushort,ushort> Xor
            => (x,y) => (ushort)(x ^ y);

        public static Expression<Func<ushort,ushort,ushort>> XorX
            => f<ushort>(Xor);

        public static Expression<Func<ushort, ushort>> Inc
            => f((ushort x) => ++x);

        public static Expression<Func<ushort, ushort>> Dec
            => f((ushort x) => --x);

        public static Expression<Func<ushort, ushort, bool>> LT
            => f((ushort x, ushort y) => x < y);

        public static Expression<Func<ushort, ushort, bool>> LtEq
            => f((ushort x, ushort y) => x <= y);

        public static Expression<Func<ushort, ushort, bool>> GT
            => f((ushort x, ushort y) => x > y);

        public static Expression<Func<ushort, ushort, bool>> GtEq
            => f((ushort x, ushort y) => x >= y);
    }
}