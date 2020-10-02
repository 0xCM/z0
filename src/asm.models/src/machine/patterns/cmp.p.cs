//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct FunctionPatterns
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

        [Op]
        public bool eq_8i(sbyte x, sbyte y)
            => x == y;

        [Op]
        public bool neq_8i(sbyte x, sbyte y)
            => x != y;

        [Op]
        public bool lt_8i(sbyte x, sbyte y)
            => x < y;

        [Op]
        public bool lteq_8i(sbyte x, sbyte y)
            => x <= y;

        [Op]
        public bool gt_8i(sbyte x, sbyte y)
            => x > y;

        [Op]
        public bool gteq_8i(sbyte x, sbyte y)
            => x >= y;

        [Op]
        public bool eq_imm8(sbyte x)
            => x == imm8i;

        [Op]
        public bool neq_imm8(sbyte x)
            => x != imm8i;

        [Op]
        public bool lt_imm8(sbyte x)
            => x < imm8i;

        [Op]
        public bool lteq_imm8(sbyte x)
            => x <= imm8i;

        [Op]
        public bool gt_imm8(sbyte x)
            => x > imm8i;

        [Op]
        public bool gteq_imm8(sbyte x)
            => x >= imm8i;

        [Op]
        public bool eq_8u(byte x, byte y)
            => x == y;

        [Op]
        public bool neq_8u(byte x, byte y)
            => x != y;

        [Op]
        public bool lt_8u(byte x, byte y)
            => x < y;

        [Op]
        public bool lteq_8u(byte x, byte y)
            => x <= y;

        [Op]
        public bool gt_8u(byte x, byte y)
            => x > y;

        [Op]
        public bool gteq_8u(byte x, byte y)
            => x >= y;

        [Op]
        public bool eq_imm8(byte x)
            => x == imm8;

        [Op]
        public bool neq_imm8(byte x)
            => x != imm8;

        [Op]
        public bool lt_imm8(byte x)
            => x < imm8;

        [Op]
        public bool lteq_imm8(byte x)
            => x <= imm8;

        [Op]
        public bool gt_imm8(byte x)
            => x > imm8;

        [Op]
        public bool gteq_imm8(byte x)
            => x >= imm8;

        [Op]
        public bool eq(uint x, uint y)
            => x == y;

        [Op]
        public bool neq(uint x, uint y)
            => x != y;

        [Op]
        public bool lt(uint x, uint y)
            => x < y;

        [Op]
        public bool lteq(uint x, uint y)
            => x <= y;

        [Op]
        public bool gt(uint x, uint y)
            => x > y;

        [Op]
        public bool gteq(uint x, uint y)
            => x >= y;

        [Op]
        public bool eq(ulong x, ulong y)
            => x == y;

        [Op]
        public bool neq(ulong x, ulong y)
            => x != y;

        [Op]
        public bool lt(ulong x, ulong y)
            => x < y;

        [Op]
        public bool lteq(ulong x, ulong y)
            => x <= y;

        [Op]
        public bool gt(ulong x, ulong y)
            => x > y;

        [Op]
        public bool gteq(ulong x, ulong y)
            => x >= y;

        [Op]
        public bool eq_imm64(ulong x)
            => x == imm64;

        [Op]
        public bool neq_imm64(ulong x)
            => x != imm64;

        [Op]
        public bool lt_imm64(ulong x)
            => x < imm64;

        [Op]
        public bool lteq_imm64(ulong x)
            => x <= imm64;

        [Op]
        public bool gt_imm64(ulong x)
            => x > imm64;

        [Op]
        public bool gteq_imm64(ulong x)
            => x >= imm64;

        [Op]
        public bool eq(double x, double y)
            => x == y;

        [Op]
        public bool neq(double x, double y)
            => x != y;

        [Op]
        public bool lt(double x, double y)
            => x < y;

        [Op]
        public bool lteq(double x, double y)
            => x <= y;

        [Op]
        public bool gt(double x, double y)
            => x > y;

        [Op]
        public bool gteq(double x, double y)
            => x >= y;

        [Op]
        public bool eq_imm64(double x)
            => x == imm64;

        [Op]
        public bool neq_imm64(double x)
            => x != imm64;

        [Op]
        public bool lt_imm64(double x)
            => x < imm64;

        [Op]
        public bool lteq_imm64(double x)
            => x <= imm64;

        [Op]
        public bool gt_imm64(double x)
            => x > imm64;

        [Op]
        public bool gteq_imm64(double x)
            => x >= imm64;
    }
}