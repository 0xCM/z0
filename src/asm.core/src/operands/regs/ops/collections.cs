//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

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
