//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class AsmPatterns
    {
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
    }
}