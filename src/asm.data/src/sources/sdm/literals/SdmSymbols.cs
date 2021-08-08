//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static SdmModels.EncodingMarkers;


    partial struct SdmModels
    {
        public readonly partial struct SdmSymbols
        {
            public const string RegSpecial = "AL/AX/EAX/RAX";

            public static string[] LegacyMode = new string[]{
                "Valid",
                "N.E.",
            };

            public enum LegacyModeKind : byte
            {
                Valid,

                NE,
            }

            public enum Mode64Kind : byte
            {

                Valid,

                NE,

                VNE,
            }

            public static string[] Mode64 = new string[]{
                "Valid",
                "N.E.",
                "V/N.E.",
            };

            public enum Mode64x32Kind
            {
                VV,

                VNE,

                V1V,

                VI2,
            }

            public static string[] Mode64x32 = new string[]{
                "V/V",
                "V/N. E.",
                "V 1 /V",
                "V/I 2"
            };


            public static string[] Operands = new string[]{
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

            public static readonly string[] Imm = new string[]{
                "imm8",
                "imm8/r",
                "imm8/16/32",
                "imm8/16/32/64",
                };

            public static string[] ModRM = new string[]{
                EncodingMarkers.ModRM + RmR,
                EncodingMarkers.ModRM + RmW,
                EncodingMarkers.ModRM + RmRW,
                EncodingMarkers.ModRM + RegR,
                EncodingMarkers.ModRM + RegW,
                EncodingMarkers.ModRM + RegRW,
                EncodingMarkers.ModRM + RmRMust11,
                EncodingMarkers.ModRM + RmWNot11,
            };

            public static readonly string[] Vex = new string[]{
                "VEX.vvvv",
                "VEX.vvvv (r, w)",
                "VEX.vvvv (r)",
                "VEX.1vvv (r)",
                };

            public static readonly string[] Evex = new string[]{
                "EVEX.vvvv",
                "EVEX.R",
                "EVEX.V'",
                "EVEX.R'",
                "EVEX.vvvv (r)",
                "EVEX.RC",
                "EVEX.RX",
                "EVEX.RXB",
                };

            public static readonly string[] OpCodeArithmetic = new string[]{
                "opcode + rd (w)",
                "opcode + rd (r)",
                "opcode + rd (r, w)",
                };

            public static readonly string[] EncodingVersions = new string[]
            {
                "(128-bit Legacy SSE version)",
                "(128-bit load- and register-copy- form Legacy SSE version)",
                "(128-bit store-form version)",
                "(VEX.128 encoded version)",
                "(VEX.128 and EVEX.128 encoded version)",
                "(VEX.256 encoded version)",
                "(VEX.256 encoded version, load - and register copy)",
                "(VEX.256 encoded version, store-form)",
                "(VEX.256 and EVEX.256 encoded version)",
                "(EVEX encoded version)",
                "(EVEX and VEX.128 encoded version)",
                "(EVEX encoded versions, register-copy form)",
                "(EVEX encoded versions, load-form)",
                "(EVEX.U1.512 encoded version)",
                "(EVEX.512 encoded version)"
            };
        }
    }
}