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

    [ApiHost]
    public readonly partial struct CmdArgs
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static string name<K,T>(in CmdArg<K,T> src)
            where K : unmanaged
                => src.Key.ToString();
    }
}
