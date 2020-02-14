//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class FTK
    {
        [MethodImpl(Inline)]
        public static FixedType<F> ftk<F>(F f = default)
            where F : unmanaged, IFixed
                => default;

        [MethodImpl(Inline)]
        public static FixedType<F,T> ftk<F,T>(F f = default, T t = default)
            where F : unmanaged, IFixed
            where T : unmanaged
                => default; 
    }
}