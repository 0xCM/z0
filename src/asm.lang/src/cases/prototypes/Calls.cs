//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;


    partial struct Prototypes
    {
        [ApiHost(prototypes + calls)]
        public readonly struct Calls
        {
            [Op]
            public static unsafe byte* caller(byte* p)
                => receiver(p);

            [Op, MethodImpl(NotInline)]
            public static unsafe byte* receiver(byte* p)
                => p++;

            [Op]
            public static ulong caller_64_64_64(ulong a, ulong b)
                => receiver_64x64x64(a,b);

            [Op, MethodImpl(NotInline)]
            public static ulong receiver_64x64x64(ulong a, ulong b)
                => a*b;

            [Op]
            public static uint caller_32_32_32(uint a, uint b)
                => receiver_32_32_32(a,b);

            [Op, MethodImpl(NotInline)]
            public static uint receiver_32_32_32(uint a, uint b)
                => a*b;

            [Op]
            public static Vector128<byte> caller_128_128_128(Vector128<byte> a, Vector128<byte> b)
                => receiver_128_128_128(a,b);

            [Op, MethodImpl(NotInline)]
            public static Vector128<byte> receiver_128_128_128(Vector128<byte> a, Vector128<byte> b)
                => cpu.vadd(a,b);

            [Op]
            public static ulong caller_64_64_64_64_64_64_64(ulong a0, ulong a1, ulong a2, ulong a3, ulong a4, ulong a5)
                => receiver_64_64_64_64_64_64_64(a0,a1,a2,a3,a4,a5);

            [Op, MethodImpl(NotInline)]
            public static ulong receiver_64_64_64_64_64_64_64(ulong a0, ulong a1, ulong a2, ulong a3, ulong a4, ulong a5)
                => a0*a1*a2*a3*a4*a5;
        }
    }
}