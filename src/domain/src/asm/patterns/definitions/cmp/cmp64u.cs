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
    }
}