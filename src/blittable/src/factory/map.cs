//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Blit
    {
        partial struct Factory
        {
            [MethodImpl(Inline)]
            public static map<S,T> map<S,T>(S src, T dst)
                where S : unmanaged
                where T : unmanaged
                    => new map<S,T>(src,dst);
        }
    }
}