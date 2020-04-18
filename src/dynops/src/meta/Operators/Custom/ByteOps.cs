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

    public static class ByteOps
    {
        public static Expression<Func<byte, byte>> Abs
            => f((byte x) => x);

        public static Expression<Func<byte, byte, byte>> Add
            => f<byte>((x, y) => (byte)(x + y));

        public static Expression<Func<byte, byte, byte>> Sub
            => f<byte>((x, y) => (byte)(x - y));

        public static Expression<Func<byte, byte, byte>> Mul
            => f<byte>((x, y) => (byte)(x * y));

        public static Expression<Func<byte, byte>> Inc
            => f((byte x) => ++x);

        public static Expression<Func<byte, byte>> Dec
            => f((byte x) => --x);

        public static Expression<Func<byte, byte, bool>> LT
            => f((byte x, byte y) => x < y);

        public static Expression<Func<byte, byte, bool>> LTEQ
            => f((byte x, byte y) => x <= y);

        public static Expression<Func<byte, byte, bool>> GT
            => f((byte x, byte y) => x > y);

        public static Expression<Func<byte, byte, bool>> GTEQ
            => f((byte x, byte y) => x >= y);
    }
}