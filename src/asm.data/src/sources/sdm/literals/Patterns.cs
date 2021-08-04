//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct SdmModels
    {
        public readonly struct Patterns
        {
            public static string[] Operands = new string[]
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

            public static string[] OcHeader0= new string[9]{
                "Opcode",
                "Instruction",
                "Op/",
                "En",
                "64-Bit",
                "Mode",
                "Compat/",
                "Leg Mode",
                "Description"
                };

            public static string[] OcHeader1 = new string[11]{
                "Opcode/",
                "Instruction",
                "Op/",
                "En",
                "64/32",
                "-bit",
                "Mode",
                "CPUID",
                "Feature",
                "Flag",
                "Description"
                };

            public static string[] OpCodeHeader2 = new string[12]{
                "Opcode/",
                "Instruction",
                "Op /",
                "En",
                "64/32",
                "bit",
                "Mode",
                "Support",
                "CPUID",
                "Feature",
                "Flag",
                "Description"
                };

            public static string[] EncodingHeader = new string[5]{
                "Op/En",
                "Operand 1",
                "Operand 2",
                "Operand 3",
                "Operand 4"
                };

            public static readonly string[] ModRM = new string[]{
                "ModRM:r/m (r)",
                "ModRM:r/m (w)",
                "ModRM:r/m (r, ModRM:[7:6] must be 11b)",
                "ModRM:r/m (w, ModRM:[7:6] must not be 11b)",
                "ModRM:reg (r)",
                "ModRM:reg (w)",
                "ModRM:reg (r,w)"
                };

            public static readonly string[] Reg = new string[]{
                "AL/AX/EAX/RAX"
                };

            public static readonly string[] Imm = new string[]{
                "imm8",
                "imm8/r",
                "imm8/16/32",
                "imm8/16/32/64",
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

            public static readonly string[] Arithmetic = new string[]{
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


            /// <summary>
            /// {Chapter}-{Page} Vol. {Vol}
            /// </summary>
            public const string PageNumber = "{0}-{1} Vol. {2}";

            /// <summary>
            /// {Mnemonic} — {Description}
            /// </summary>
            public const string MnemonicTitle = "{0} — {1}";

            /// <summary>
            /// {0}/{1}
            /// </summary>
            public const string MultiMnemonicTitle1 = "{Mnemonic}/{0}";

            /// <summary>
            /// {0}/{1}/{2}
            /// </summary>
            public const string MultiMnemonicTitle2 = "{0}/{1}/{2}";

            /// <summary>
            /// {0}/{1}/{2}/{3}
            /// </summary>
            public const string MultiMnemonicTitle3 = "{0}/{1}/{2}/{3}";

            public const string ChapterNumber = "CHAPTER " + "{0}";

            public const string TableNumber = "Table " + "{0}";

            public const string ChapterPage = "{0}-{1}";
        }
    }
}