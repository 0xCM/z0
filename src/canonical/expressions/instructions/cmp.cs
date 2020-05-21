//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Kinds;

/*
-----------------------------------------------------------------------------------------------------------------------------------
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
    partial class AsmExpr
    {
        const byte imm8 = byte.MaxValue;

        const sbyte imm8i = sbyte.MinValue;

        const ushort imm16 = ushort.MaxValue;

        const short imm16i = short.MinValue;

        const uint imm32 = uint.MaxValue;

        const int imm32i = int.MinValue;

        [Op]
        public bool cmp(Lt kind, byte x)
            => x < imm8;

        [Op]
        public bool cmp(Lt kind, sbyte x)
            => x < imm8i;

        [Op]
        public bool cmp(Lt kind, ushort x)
            => x < imm16;

        [Op]
        public bool cmp(Lt kind, short x)
            => x < imm16i;

        [Op]
        public bool cmp(Lt kind, uint x)
            => x < imm32;

        [Op]
        public bool cmp(Neq kind, sbyte x, sbyte y)
            => x != y;

        [Op]
        public bool cmp(Lt kind, sbyte x, sbyte y)
            => x < y;

        [Op]
        public bool cmp(LtEq kind, sbyte x, sbyte y)
            => x <= y;

        [Op]
        public bool cmp(Gt kind, sbyte x, sbyte y)
            => x > y;

        [Op]
        public bool cmp(GtEq kind, sbyte x, sbyte y)
            => x >= y;

        [Op]
        public bool cmp(Eq kind, byte x, byte y)
            => x == y;

        [Op]
        public bool cmp(Neq kind, byte x, byte y)
            => x != y;

        [Op]
        public bool cmp(Lt kind, byte x, byte y)
            => x < y;

        [Op]
        public bool cmp(LtEq kind, byte x, byte y)
            => x <= y;

        [Op]
        public bool cmp(Gt kind, byte x, byte y)
            => x > y;

        [Op]
        public bool cmp(GtEq kind, byte x, byte y)
            => x >= y;

    }
}