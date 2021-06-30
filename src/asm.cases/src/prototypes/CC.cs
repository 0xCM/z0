//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.Intrinsics;

    using static core;

    partial struct Prototypes
    {
        [ApiHost(prototypes + "cc")]
        public readonly struct CC
        {
            [Op]
            public static Vector128<uint> f_u32_u32_128x4u(uint a0, uint a1)
            {
                return Vector128.Create(a0,0u,a1,0u);
            }

            [Op]
            public static unsafe void f_u32_u32_p32u(uint ecx, uint edx, uint* r8d)
            {
                r8d[0] = ecx*0x7;
                r8d[1] = ecx*0xd;
                r8d[2] = edx*0x11;
                r8d[3] = edx*0x17;
            }

            [Op]
            public static void f1x1(uint a0, out uint b0)
            {
                b0 = a0*0x77;
            }

            [Op]
            public static void f1x2(uint a0, out uint b0, out uint b1)
            {
                b0 = a0*0x11CC;
                b1 = a0*0xFFCC;
            }

            [Op]
            public static void f1x3(uint a0, out uint b0, out uint b1, out uint b2)
            {
                b0 = a0*0x1111;
                b1 = a0*0xFFCC;
                b2 = a0*0xCCFF;
            }

            [Op]
            public static void f2x1(uint a0, uint a1, out uint b0)
            {
                b0 = a0*a1;
            }

            [Op]
            public static void f3x0(uint a0, uint a1, Span<uint> dst)
            {
                seek(dst,0) = a0*0x1111;
                seek(dst,1) = a1*0xFFCC;
                seek(dst,2) = a0*0x3333;
                seek(dst,3) = skip(dst,2)*4;
            }

            [Op]
            public static void f2x3(uint a0, uint a1, out uint b0, out uint b1, out uint b2)
            {
                b0 = a0*0x1111;
                b1 = a1*0xFFCC;
                b2 = a0*a1;
            }

            [Op]
            public static void f2x4(uint a0, uint a1, out uint b0, out uint b1, out uint b2, out uint b3)
            {
                b0 = a0*0x1111;
                b1 = a1*0xFFCC;
                b2 = a0*a1;
                b3 = a1*0x8999;
            }

            [Op]
            public static void f3x1(uint a0, uint a1, uint a2, out uint b0)
            {
                b0 = a0*a1*a2;
            }


            [Op]
            public static void f3x2(uint a0, uint a1, uint a2, out uint b0, out uint b1)
            {
                b0 = a0*a1;
                b1 = a1*0x16;
            }


            [Op]
            public static void f3x3(uint a0, uint a1, uint a2, out uint b0, out uint b1, out uint b2)
            {
                b0 = a0*0x1111;
                b1 = a1*0xFFCC;
                b2 = a2*0xCCFF;
            }
        }
    }
}