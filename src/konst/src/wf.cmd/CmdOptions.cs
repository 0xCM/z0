//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct CmdOptions
    {
        [MethodImpl(Inline), Formatter]
        public static string format(CmdOptionSpec src)
            => src.IsAnonymous || src.IsEmpty ? EmptyString : src.Name;

        [MethodImpl(Inline), Formatter, Closures(UnsignedInts)]
        public static string format<K>(CmdOptionSpec<K> src)
            where K : unmanaged
                => src.IsAnonymous || src.IsEmpty ? EmptyString : src.Name;
    }
}