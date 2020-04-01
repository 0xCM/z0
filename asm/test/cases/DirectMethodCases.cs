//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    class DirectMethodCases
    {
        [Op]
        public static uint and(uint a, uint b)
            => a & b;
        [Op]
        public static uint or(uint a, uint b)
            => a | b;

        [Op]
        public static byte xor(byte a, byte b)
            => (byte)(a ^ b);
    }
}