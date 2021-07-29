//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct SdmModels
    {
        public readonly struct RulePatterns
        {
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
                "imm8/16/32"
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
        }
    }
}