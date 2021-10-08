//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct Strings
    {
        public static String<S> @string<S>(params Symbol<S>[] src)
            where S : unmanaged
                => new String<S>(src);
    }
}