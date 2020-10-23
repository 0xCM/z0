//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmInstructionTokens
    {
        public enum Category : byte
        {
            DataTransfer,
        }

        const string Fields = "| Class | Category | Extension | IsaSet | BaseCode | Mod | Reg | Pattern                                                                                             | Operands";

        const string b11 = nameof(b11);

        const string rrr = nameof(rrr);

        const string nnn = nameof(nnn);

        const string mm = nameof(mm);

        const string VMOVDQU_0 = "| VMOVDQU | DATAXFER | AVX  |   | 6f | mm   | rrr | VV1 0x6F  VL128 VF3 V0F NOVSR MOD[mm] MOD!=3 REG[rrr] RM[nnn] MODRM()                               | REG0=XMM_R():w:dq  MEM0:r:dq";

        const string VMOVDQU_1 = "| VMOVDQU | DATAXFER | AVX  |  | 6f | 0b11 | rrr | VV1 0x6F  VL128 VF3 V0F NOVSR MOD[0b11] MOD=3 REG[rrr] RM[nnn]                                      | REG0=XMM_R():w:dq  REG1=XMM_B():r:dq";

        const string VMOVDQU_2 = "| VMOVDQU | DATAXFER | AVX  |  | 6f | mm   | rrr | VV1 0x6F  VL256 VF3 V0F NOVSR MOD[mm] MOD!=3 REG[rrr] RM[nnn] MODRM()                               | REG0=YMM_R():w:qq  MEM0:r:qq";

        const string VMOVDQU_3 = "| VMOVDQU | DATAXFER | AVX  |  | 6f | 0b11 | rrr | VV1 0x6F  VL256 VF3 V0F NOVSR MOD[0b11] MOD=3 REG[rrr] RM[nnn]                                      | REG0=YMM_R():w:qq  REG1=YMM_B():r:qq";

        const string VMOVDQU_4 = "| VMOVDQU | DATAXFER | AVX  |  | 7f | mm   | rrr | VV1 0x7F  VL128 VF3 V0F NOVSR MOD[mm] MOD!=3 REG[rrr] RM[nnn] MODRM()                               | MEM0:w:dq REG0=XMM_R():r:dq";

        const string VMOVDQU_5 = "| VMOVDQU | DATAXFER | AVX  |  | 7f | 0b11 | rrr | VV1 0x7F  VL128 VF3 V0F NOVSR MOD[0b11] MOD=3 REG[rrr] RM[nnn]                                      | REG0=XMM_B():w:dq REG1=XMM_R():r:dq";

        const string VMOVDQU_6 = "| VMOVDQU | DATAXFER | AVX  |  | 7f | mm   | rrr | VV1 0x7F  VL256 VF3 V0F NOVSR MOD[mm] MOD!=3 REG[rrr] RM[nnn] MODRM()                               | MEM0:w:qq REG0=YMM_R():r:qq";

        const string VMOVDQU_7 = "| VMOVDQU | DATAXFER | AVX  |  | 7f | 0b11 | rrr | VV1 0x7F  VL256 VF3 V0F NOVSR MOD[0b11] MOD=3 REG[rrr] RM[nnn]                                      | REG0=YMM_B():w:qq REG1=YMM_R():r:qq";

    }
}