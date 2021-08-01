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

    using blit = Z0.BZ;

    using Z0.BZ;

    partial struct Blit
    {
        [MethodImpl(Inline)]
        public static map<S,T> map<S,T>(S src, T dst)
            where S : unmanaged
            where T : unmanaged
                => new map<S,T>(src,dst);
    }
}