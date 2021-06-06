//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmHexCode code(ulong src)
            => AsmBytes.code(src);

        [MethodImpl(Inline), Op]
        public static AsmHexCode code(string src)
            => AsmBytes.parse(src);
    }
}