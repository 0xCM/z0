//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly partial struct AsmRegOps
    {

    }

    [ApiHost]
    public static partial class XAsm
    {
        [MethodImpl(Inline), Op]
        public static bool IsHi(this Sym<Gp8> src)
            => (src.Kind & (Gp8)RegIndex.r16) != 0;

        [MethodImpl(Inline), Op]
        public static bool IsLo(this Sym<Gp8> src)
            => (src.Kind & (Gp8)RegIndex.r16) == 0;
    }
}