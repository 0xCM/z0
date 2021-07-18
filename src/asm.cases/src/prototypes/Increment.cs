//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct Prototypes
    {

        [ApiHost(prototypes + "increment")]
        public unsafe readonly struct Increment
        {
            [Op]
            public static void inc(ref byte* pSrc)
                => pSrc++;

            [Op]
            public static void inc(ref sbyte* pSrc)
                => pSrc++;

            [Op]
            public static void inc(ref short* pSrc)
                => pSrc++;

            [Op]
            public static void inc(ref ushort* pSrc)
                => pSrc++;

            [Op]
            public static void inc(ref int* pSrc)
                => pSrc++;

            [Op]
            public static void inc(ref uint* pSrc)
                => pSrc++;

            [Op]
            public static void inc(ref long* pSrc)
                => pSrc++;

            [Op]
            public static void inc(ref ulong* pSrc)
                => pSrc++;

            [Op]
            public static void inc(ref float* pSrc)
                => pSrc++;

            [Op]
            public static void inc(ref double* pSrc)
                => pSrc++;

            [Op]
            public static void inc(ref Cell256* pSrc)
                => pSrc++;
        }
    }
}