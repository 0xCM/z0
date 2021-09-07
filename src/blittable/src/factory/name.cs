//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Blit
    {
        partial struct Factory
        {
            [MethodImpl(Inline), Op]
            public static name<CharBlock8> name(N8 n, string src)
                => src;

            [MethodImpl(Inline), Op]
            public static name<CharBlock16> name(N16 n, string src)
                => src;

            [MethodImpl(Inline), Op]
            public static name<CharBlock32> name(N32 n, string src)
                => src;

            [MethodImpl(Inline), Op]
            public static name<CharBlock64> name(N64 n, string src)
                => src;
        }
    }
}