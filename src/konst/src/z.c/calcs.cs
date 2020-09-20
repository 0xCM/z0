//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {                                        
        [MethodImpl(Inline), Op]
        public static byte sll(byte x, byte count)
            => (byte)(x << count);

        [MethodImpl(Inline), Op]
        public static byte srl(byte x, byte count)
            => (byte)(x >> count);

        [MethodImpl(Inline), Op]
        public static byte sub(byte a, byte b)
            => (byte)(a - b);
    }
}