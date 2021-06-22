//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmRegs
    {
        [MethodImpl(Inline), Op]
        public static Register from(RegKind kind)
            => kind;

        [MethodImpl(Inline), Op]
        public static Register from(@enum<RegKind,uint> src)
            => new Register(src.Literal);

        [MethodImpl(Inline), Op]
        public static Register from(Sym<RegKind> src)
            => new Register(src.Kind);

        [MethodImpl(Inline), Op]
        public static Register from(RegIndex c, RegClass k, RegWidth w)
            => new Register(c, k, w);
    }
}