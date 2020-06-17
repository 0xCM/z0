//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    readonly struct CalcSlots
    {
        [Size(20)]
        public static byte add(byte x, byte y)
            => (byte)(x+y);

        [Size(17)]
        public static byte sub(byte x, byte y)
            => (byte)(x-y);

        [Size(18)]
        public static byte mul(byte x, byte y)
            => (byte)(x*y);

        [Size(18)]
        public static byte div(byte x, byte y)
            => (byte)(x/y);

        [Size(17)]
        public static byte and(byte x, byte y)
            => (byte)(x&y);
    }
}