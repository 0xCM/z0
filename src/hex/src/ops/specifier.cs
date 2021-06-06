//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Hex
    {
        [MethodImpl(Inline), Op]
        public static bit specifier(AsciCharCode c)
            => c == AsciCharCode.X || c == AsciCharCode.x || c == AsciCharCode.h;

        [MethodImpl(Inline), Op]
        public static bit specifier(char c)
            => specifier((AsciCharCode)c);
    }
}