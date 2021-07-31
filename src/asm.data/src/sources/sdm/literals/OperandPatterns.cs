//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct SdmModels
    {
        public readonly struct OperandPatterns
        {
            public static string[] Data = new string[]
            {
                "AL",
                "AX",
                "EAX",
                "RAX",
                "DX",

                "imm8",
                "imm16",
                "imm32",
                "imm64",

                "k1",
                "k2",
                "k3",

                "mm1",
                "mm2",

                "m8",
                "m16",
                "m32",
                "m64",
                "m128",
                "m256",

                "r8",
                "r16",
                "r32",
                "r64",

                "rel8",
                "rel16",
                "rel32",

                "xmm1",
                "xmm2",
                "xmm3",

                "ymm1",
                "ymm2",
                "ymm3",

                "zmm1",
                "zmm2",
                "zmm3",

                "r32/m8",
                "r32/m32",
                "r64/m64",

                "r/m8",
                "r/m16",
                "r/m32",
                "r/m64",

                "mm2/m64",

                "xmm1{k1}{z}",
                "xmm2/m16",
                "xmm2/m32",
                "xmm2/m64",
                "xmm2/m128",
                "xmm2/m128/m32bcst",
                "xmm3/m128",
                "xmm3/m128/m32bcst",
                "xmm3/m128/m64bcst",

                "ymm1{k1}{z}",
                "ymm2/m256",
                "ymm2/m256/m32bcst",
                "ymm3/m256",
                "ymm3/m256/m32bcst",
                "ymm3/m256/m64bcst",

                "zmm1{k1}{z}",
                "zmm2/m512/m32bcst",
                "zmm3/m512",
                "zmm3/m512/m32bcst",
                "zmm3/m512/m64bcst",
            };
        }
    }
}