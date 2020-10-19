//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct SymbolStore
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq1,T,N1> bits<T>(N1 n)
            where T : unmanaged
                => symbols<BitSeq1,T,N1>();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq2,T,N2> bits<T>(N2 n)
            where T : unmanaged
            => symbols<BitSeq2,T,N2>();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq3,T,N3> bits<T>(N3 n)
            where T : unmanaged
            => symbols<BitSeq3,T,N3>();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq4,T,N4> bits<T>(N4 n)
            where T : unmanaged
            => symbols<BitSeq4,T,N4>();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq5,T,N5> bits<T>(N5 n)
            where T : unmanaged
            => symbols<BitSeq5,T,N5>();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SymbolStore<BitSeq6,T,N6> bits<T>(N6 n)
            where T : unmanaged
                => symbols<BitSeq6,T,N6>();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NamedSymbols<BitSeq8,T,N8> bits<T>(N8 n)
            where T : unmanaged
                => SymbolStore.named<BitSeq8,T,N8>();
    }
}