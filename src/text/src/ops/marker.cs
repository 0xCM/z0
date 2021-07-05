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
        public static TextMarker marker(string src)
            => new TextMarker(src);

        [MethodImpl(Inline), Op]
        public static TextMarker marker(char src)
            => new TextMarker(src.ToString());
    }
}