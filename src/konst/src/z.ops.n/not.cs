//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op]
        public static bool not(bool src)
            => !src;

        [MethodImpl(Inline), Op]
        public static bit not(bit src)
            => !src;
    }
}