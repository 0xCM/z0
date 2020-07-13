//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Symbolic
    {        
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Symbols<BitSeq1,T,N1> bits<T>(N1 n)         
            where T : unmanaged
                => enumerate<BitSeq1,T,N1>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Symbols<BitSeq2,T,N2> bits<T>(N2 n)         
            where T : unmanaged
            => enumerate<BitSeq2,T,N2>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Symbols<BitSeq3,T,N3> bits<T>(N3 n)         
            where T : unmanaged
            => enumerate<BitSeq3,T,N3>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Symbols<BitSeq4,T,N4> bits<T>(N4 n)         
            where T : unmanaged
            => enumerate<BitSeq4,T,N4>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Symbols<BitSeq5,T,N5> bits<T>(N5 n)         
            where T : unmanaged
            => enumerate<BitSeq5,T,N5>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Symbols<BitSeq6,T,N6> bits<T>(N6 n)         
            where T : unmanaged
                => enumerate<BitSeq6,T,N6>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Symbols<BitSeq8,T,N8> bits<T>(N8 n)         
            where T : unmanaged
                => enumerate<BitSeq8,T,N8>();
    }
}