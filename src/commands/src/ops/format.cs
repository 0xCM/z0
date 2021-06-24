//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Cmd
    {
        [MethodImpl(Inline), Formatter, Closures(Closure)]
        public static string format<K>(in CmdOptionSpec<K> src)
            where K : unmanaged
                => src.IsAnonymous || src.IsEmpty ? EmptyString : src.Name;

        [MethodImpl(Inline), Formatter]
        public static string format(CmdOptionSpec src)
            => src.IsAnonymous || src.IsEmpty ? EmptyString : src.Name;
    }
}