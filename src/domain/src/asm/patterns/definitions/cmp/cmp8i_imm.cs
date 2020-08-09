//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    partial class AsmPatterns
    {
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
    }
}