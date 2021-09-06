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
            public static bits<N,T> bits<N,T>(N n, T value)
                where N : unmanaged, ITypeNat
                where T : unmanaged
                    => new bits<N,T>(value);

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static bits<T> bits<T>(uint n, T value)
                where T : unmanaged
                    => new bits<T>(n, value);
        }
    }
}