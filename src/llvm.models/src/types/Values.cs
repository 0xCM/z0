//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Types;

    [ApiHost]
    public readonly partial struct Values
    {
        const NumericKind Closure = UnsignedInts;

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