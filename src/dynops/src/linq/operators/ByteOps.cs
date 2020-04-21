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

    public static class ByteOps
    {
        public static Expression<Func<byte,byte>> Abs
            => f((byte x) => x);

        public static Expression<Func<byte,byte,byte>> Add
            => f<byte>((x, y) => (byte)(x + y));

        public static Expression<Func<byte,byte,byte>> Sub
            => f<byte>((x, y) => (byte)(x - y));

        public static Expression<Func<byte,byte,byte>> Mul
            => f<byte>((x, y) => (byte)(x * y));

        public static Expression<Func<byte,byte>> Inc
            => f((byte x) => ++x);

        public static Expression<Func<byte,byte>> Dec
            => f((byte x) => --x);

        public static Expression<Func<byte,byte,bool>> LT
            => f((byte x, byte y) => x < y);

        public static Expression<Func<byte,byte,bool>> LTEQ
            => f((byte x, byte y) => x <= y);

        public static Expression<Func<byte,byte,bool>> GT
            => f((byte x, byte y) => x > y);

        public static Expression<Func<byte,byte,bool>> GTEQ
            => f((byte x, byte y) => x >= y);
    }
}