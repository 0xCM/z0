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
    }
}