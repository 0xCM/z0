//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static math;
    using static core;
    using static RegClasses;
    using static AsmDsl;

    partial struct AsmRegs
    {
        [Op]
        public static ReadOnlySpan<RegWidthIndex> widths()
            => Symbols.index<RegWidthIndex>().Kinds;
        [Op]
        public static ReadOnlySpan<RegClass> classes()
            => Symbols.index<RegClass>().Kinds;

        [Op]
        public static ReadOnlySpan<RegIndex> indices()
            => Symbols.index<RegIndex>().Kinds;
    }
}
