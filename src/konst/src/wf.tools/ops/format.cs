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
        [MethodImpl(Inline), Formatter]
        public static string format(ToolOption src)
            => src.IsAnonymous || src.IsEmpty ? EmptyString : src.Name;

        [MethodImpl(Inline), Formatter, Closures(Closure)]
        public static string format<K>(ToolOption<K> src)
            where K : unmanaged
                => src.IsAnonymous || src.IsEmpty ? EmptyString : src.Name;

        [Formatter]
        public static string format(ToolArg src, char specifier)
            => string.Format("{0}{1}{2}", src.Option, specifier, src.Value);

        public static string format<K,V>(ToolArg<K,V> src, char specifier)
            where K : unmanaged
                => string.Format("{0}{1}{2}", src.Option, specifier, src.Value);
    }
}