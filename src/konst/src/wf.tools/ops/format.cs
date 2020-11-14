//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Tooling
    {
        [Op]
        public static string format(ToolOption src, char specifier)
            => string.Format("{0}{1}{2}", src.Key, specifier, src.Value);

        public static string format<K,V>(ToolOption<K,V> src, char specifier)
            where K : unmanaged
                => string.Format("{0}{1}{2}", src.Key, specifier, src.Value);
    }
}