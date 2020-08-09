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
    }
}