//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asci
    {
        [MethodImpl(Inline)]
        public static string @string<A>(in A src)
            where A : unmanaged, IByteSeq
                => src.Format();
    }
}