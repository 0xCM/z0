//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct asci
    {
        [MethodImpl(Inline)]
        public static string @string<A>(in A src)
            where A : unmanaged, IBytes
                => src.Format();
    }
}