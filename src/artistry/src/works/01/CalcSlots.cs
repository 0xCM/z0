//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    enum CalcSlotIndex : byte
    {
        Add = 0,

        Sub = 1,

        Mul = 2,

        Div = 3,

        And = 4,
    }
        
    readonly struct CalcSlots
    {
        [Size(20), MethodImpl(NotInline)]
        public static byte add(byte x, byte y)
            => (byte)(x+y);

        [Size(17), MethodImpl(NotInline)]
        public static byte sub(byte x, byte y)
            => (byte)(x-y);

        [Size(18), MethodImpl(NotInline)]
        public static byte mul(byte x, byte y)
            => (byte)(x*y);

        [Size(18), MethodImpl(NotInline)]
        public static byte div(byte x, byte y)
            => (byte)(x/y);

        [Size(17), MethodImpl(NotInline)]
        public static byte and(byte x, byte y)
            => (byte)(x&y);
    }
}