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
    using static Memories;
    using static XFunc;

    public class UInt16Ops
    {
        public static Expression<Func<ushort, ushort>> Abs
            => f((ushort x) => x);

        public static Expression<Func<ushort, ushort, ushort>> Add
            => f<ushort>((x, y) => (ushort)(x + y));

        public static Expression<Func<ushort, ushort, ushort>> Mul
            => f<ushort>((x, y) => (ushort)(x * y));

        public static Expression<Func<ushort, ushort, ushort>> Sub
            => f<ushort>((x, y) => (ushort)(x - y));

        public static Expression<Func<ushort, ushort>> Inc
            => f((ushort x) => ++x);

        public static Expression<Func<ushort, ushort>> Dec
            => f((ushort x) => --x);

        public static Expression<Func<ushort, ushort, bool>> LT
            => f((ushort x, ushort y) => x < y);

        public static Expression<Func<ushort, ushort, bool>> LTEQ
            => f((ushort x, ushort y) => x <= y);

        public static Expression<Func<ushort, ushort, bool>> GT
            => f((ushort x, ushort y) => x > y);

        public static Expression<Func<ushort, ushort, bool>> GTEQ
            => f((ushort x, ushort y) => x >= y);
    }
}