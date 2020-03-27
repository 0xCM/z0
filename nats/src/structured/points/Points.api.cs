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

    using static Components;
    
    public static class Points
    {

        [MethodImpl(Inline)]
        public static Point<N1,T> point<T>(T x0)
            where T : unmanaged
                => new Point<N1, T>(x0);                 

        [MethodImpl(Inline)]
        public static Point<N2,T> point<T>(T x0, T x1)
            where T : unmanaged
                => new Point<N2,T>(x0,x1);

        [MethodImpl(Inline)]
        public static Point<N3,T> point<T>(T x0, T x1, T x2)
            where T : unmanaged
                => new Point<N3,T>(x0,x1,x2);         

        [MethodImpl(Inline)]
        public static Point<N4,T> point<T>(T x0, T x1, T x2, T x3)
            where T : unmanaged
                => new Point<N4, T>(x0,x1,x2,x3);         


    }
}