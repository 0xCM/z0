//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial class text
    {
        [MethodImpl(Inline), Op]
        public static bool contains(string src, string match)
            => src.Contains(match);

        [MethodImpl(Inline), Op]
        public static bool contains(string src, char match)
            => src.Contains(match);
    }
}