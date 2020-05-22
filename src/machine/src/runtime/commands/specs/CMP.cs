//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    using static HexCodes;

    /*
    | Expression     | Instruction      | M16 | M32 | M64 | CpuId | Id              |
    | 38 /r          | CMP r/m8, r8     | Y   | Y   | Y   | 8086+ | Cmp_rm8_r8      |
    | 39 /r          | CMP r/m16, r16   | Y   | Y   | Y   | 8086+ | Cmp_rm16_r16    |
    | 39 /r          | CMP r/m32, r32   | Y   | Y   | Y   | 386+  | Cmp_rm32_r32    |
    | REX.W 39 /r    | CMP r/m64, r64   | N   | N   | Y   | X64   | Cmp_rm64_r64    |
    | 3A /r          | CMP r8, r/m8     | Y   | Y   | Y   | 8086+ | Cmp_r8_rm8      |
    | 3B /r          | CMP r16, r/m16   | Y   | Y   | Y   | 8086+ | Cmp_r16_rm16    |
    | 3B /r          | CMP r32, r/m32   | Y   | Y   | Y   | 386+  | Cmp_r32_rm32    |
    | REX.W 3B /r    | CMP r64, r/m64   | N   | N   | Y   | X64   | Cmp_r64_rm64    |
    | 3C ib          | CMP AL, imm8     | Y   | Y   | Y   | 8086+ | Cmp_AL_imm8     |
    | 3D id          | CMP EAX, imm32   | Y   | Y   | Y   | 386+  | Cmp_EAX_imm32   |
    | REX.W 3D id    | CMP RAX, imm32   | N   | N   | Y   | X64   | Cmp_RAX_imm32   |
    | 3D iw          | CMP AX, imm16    | Y   | Y   | Y   | 8086+ | Cmp_AX_imm16    |
    | 80 /7 ib       | CMP r/m8, imm8   | Y   | Y   | Y   | 8086+ | Cmp_rm8_imm8    |
    | 81 /7 id       | CMP r/m32, imm32 | Y   | Y   | Y   | 386+  | Cmp_rm32_imm32  |
    | REX.W 81 /7 id | CMP r/m64, imm32 | N   | N   | Y   | X64   | Cmp_rm64_imm32  |
    | 81 /7 iw       | CMP r/m16, imm16 | Y   | Y   | Y   | 8086+ | Cmp_rm16_imm16  |
    | 82 /7 ib       | CMP r/m8, imm8   | Y   | Y   | N   | 8086+ | Cmp_rm8_imm8_82 |
    | 83 /7 ib       | CMP r/m16, imm8  | Y   | Y   | Y   | 8086+ | Cmp_rm16_imm8   |
    | 83 /7 ib       | CMP r/m32, imm8  | Y   | Y   | Y   | 386+  | Cmp_rm32_imm8   |
    | REX.W 83 /7 ib | CMP r/m64, imm8  | N   | N   | Y   | X64   | Cmp_rm64_imm8   |

    */
    partial class Commands
    {
        public readonly struct CMP
        {
            public readonly HexKind OpCode;

            public readonly Operand OpA;

            public readonly Operand OpB;

            public CMP(HexKind oc, Operand a, Operand b)
            {
                this.OpCode = oc;
                this.OpA = a;
                this.OpB = b;
            }


            // public static CMP cmp(X38 x, Reg8 a, Reg8 b)
            //     => new CMP(x38, a,b);

            // public static CMP cmp(X38 x, Mem8 a, Reg8 b)
            //     => default;

            // public static CMP cmp(X39 x, Reg16 a, Reg16 b)
            //     => default;

            // public static CMP cmp(X39 x, Mem16 a, Reg16 b)
            //     => default;

            // public static CMP cmp(X39 x, Mem32 a, Reg32 b)
            //     => default;


            // public static CMP define(X39 x, Reg64 a, Reg64 b)
            //     => default;

            // public static CMP define(X39 x, Mem64 a, Reg64 b)
            //     => default;

        }
    }

}