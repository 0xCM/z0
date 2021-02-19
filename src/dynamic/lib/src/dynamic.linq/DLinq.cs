//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq.Expressions;

    using static LinqXFunc;

    public readonly struct DLinq
    {
        public static Expression<Func<ushort, ushort>> abs16u()
            => f((ushort x) => x);

        public static Expression<Func<ushort, ushort, ushort>> add16u()
            => f<ushort>((x, y) => (ushort)(x + y));

        public static Expression<Func<ushort, ushort, ushort>> mul16u()
            => f<ushort>((x, y) => (ushort)(x * y));

        public static Expression<Func<ushort, ushort, ushort>> sub16u()
            => f<ushort>((x, y) => (ushort)(x - y));

        public static Expression<Func<ushort,ushort,ushort>> and16u()
            => f<ushort>((x, y) => (ushort)(x & y));

        public static Expression<Func<ushort,ushort,ushort>> or16u()
            => f<ushort>((x, y) => (ushort)(x | y));

        public static Expression<Func<ushort,ushort,ushort>> xor16u()
            => f<ushort>((x, y) => (ushort)(x ^ y));

        public static Expression<Func<ushort, ushort>> inc16u
            => f((ushort x) => ++x);

        public static Expression<Func<ushort, ushort>> dec16u()
            => f((ushort x) => --x);

        public static Expression<Func<ushort, ushort, bool>> lt16u()
            => f((ushort x, ushort y) => x < y);

        public static Expression<Func<ushort, ushort, bool>> lteq16u()
            => f((ushort x, ushort y) => x <= y);

        public static Expression<Func<ushort, ushort, bool>> gt16u()
            => f((ushort x, ushort y) => x > y);

        public static Expression<Func<ushort, ushort, bool>> gteq16u()
            => f((ushort x, ushort y) => x >= y);
    }
}