//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class HomPoint
    {
        [MethodImpl(Inline)]
        public static HomPoint<N1,T> From<T>(T x0)
            where T : unmanaged
                => new HomPoint<N1, T>(x0);         

        [MethodImpl(Inline)]
        public static HomPoint<N2,T> From<T>(T x0, T x1)
            where T : unmanaged
                => new HomPoint<N2, T>(x0,x1);         

        [MethodImpl(Inline)]
        public static HomPoint<N3,T> From<T>(T x0, T x1, T x2)
            where T : unmanaged
                => new HomPoint<N3, T>(x0,x1,x2);         

        [MethodImpl(Inline)]
        public static HomPoint<N3,T> From<T>(N3 n, T[] src)
            where T : unmanaged
                => new HomPoint<N3, T>(n,src);         
    }
}