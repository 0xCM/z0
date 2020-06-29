//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    partial class AsmPatterns
    {
        const byte imm8 = 0xF0;

        const sbyte imm8i = -0xF;

        const ushort imm16 = 0x5050;

        const short imm16i = -0x50;

        const uint imm32 = 0xA0A0A0;

        const int imm32i = -0xA0A0A0;

        const ulong imm64 = 0xA0A0A05050;

        const double imm64f = 34441.25;
        
        const decimal imm128 = 34.256m;

    }
}