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
            => AsmHexCode.load(src);

        [MethodImpl(Inline), Op]
        public static AsmHexCode code(string src)
            => AsmHexCode.parse(src);
    }
}