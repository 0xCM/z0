
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CalcHosts;

    partial struct Calcs
    {

        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static Impl128<T> impl<T>(W128 w)
            where T : unmanaged
                => default(Impl128<T>);

        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static Impl256<T> impl<T>(W256 w)
            where T : unmanaged
                => default(Impl256<T>);

        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static NonImpl128<T> nonimpl<T>(W128 w)
            where T : unmanaged
                => default(NonImpl128<T>);

        [MethodImpl(Inline), Factory, Closures(Integers)]
        public static NonImpl256<T> nonimpl<T>(W256 w)
            where T : unmanaged
                => default(NonImpl256<T>);

    }
}