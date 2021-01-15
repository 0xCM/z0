//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmRegs;

    using M = AsmMnemonics;

    partial struct AsmBuilder
    {
        [MethodImpl(Inline), Op]
        public static AsmStatement<r16> push(r16 r)
            => statement(M.push, r);

        [MethodImpl(Inline), Op]
        public static AsmStatement<r32> push(r32 r)
            => statement(M.push, r);

        [MethodImpl(Inline), Op]
        public static AsmStatement<r64> push(r64 r)
            => statement(M.push, r);
    }
}