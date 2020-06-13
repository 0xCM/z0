//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
     
    using static Konst;

    partial class Symbolic
    {    
        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public static Symbols<Singleton,T,N1> bits<T>(N1 n)         
            where T : unmanaged
                => Symbolic.enumerate<Singleton,T,N1>();

        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public static Symbols<Duet,T,N2> bits<T>(N2 n)         
            where T : unmanaged
            => Symbolic.enumerate<Duet,T,N2>();

        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public static Symbols<Triad,T,N3> bits<T>(N3 n)         
            where T : unmanaged
            => Symbolic.enumerate<Triad,T,N3>();

        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public static Symbols<Quartet,T,N4> bits<T>(N4 n)         
            where T : unmanaged
            => Symbolic.enumerate<Quartet,T,N4>();

        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public static Symbols<Quintet,T,N5> bits<T>(N5 n)         
            where T : unmanaged
            => Symbolic.enumerate<Quintet,T,N5>();

        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public static Symbols<Sextet,T,N6> bits<T>(N6 n)         
            where T : unmanaged
            => Symbolic.enumerate<Sextet,T,N6>();

        [MethodImpl(Inline), Op, NumericClosures(UnsignedInts)]
        public static Symbols<Octet,T,N8> bits<T>(N8 n)         
            where T : unmanaged
            => Symbolic.enumerate<Octet,T,N8>();
    }
}