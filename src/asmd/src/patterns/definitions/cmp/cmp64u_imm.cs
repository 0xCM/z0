//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Kinds;

    partial class AsmPatterns
    {
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
    }
}