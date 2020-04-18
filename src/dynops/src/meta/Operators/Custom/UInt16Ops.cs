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