//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    partial class Symbolic
    {
        public static Symbols<Singleton,T,N1> bits<T>(N1 n)         
            where T : unmanaged
                => Symbolic.enumerate<Singleton,T,N1>();

        public static Symbols<Duet,T,N2> bits<T>(N2 n)         
            where T : unmanaged
            => Symbolic.enumerate<Duet,T,N2>();

        public static Symbols<Triad,T,N3> bits<T>(N3 n)         
            where T : unmanaged
            => Symbolic.enumerate<Triad,T,N3>();

        public static Symbols<Quartet,T,N4> bits<T>(N4 n)         
            where T : unmanaged
            => Symbolic.enumerate<Quartet,T,N4>();

        public static Symbols<Quintet,T,N5> bits<T>(N5 n)         
            where T : unmanaged
            => Symbolic.enumerate<Quintet,T,N5>();

        public static Symbols<Sextet,T,N6> bits<T>(N6 n)         
            where T : unmanaged
            => Symbolic.enumerate<Sextet,T,N6>();

        public static Symbols<Octet,T,N8> bits<T>(N8 n)         
            where T : unmanaged
            => Symbolic.enumerate<Octet,T,N8>();
    }
}