//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
       
    using static Konst;

    public readonly struct emath
    {
        [MethodImpl(Inline)]
        public static @enum<E,T> add<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum            
            where T : unmanaged
                => new @enum<E,T>(gmath.add(a.Scalar, b.Scalar));    

        [MethodImpl(Inline)]
        public static @enum<E,T> sub<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum            
            where T : unmanaged
                => new @enum<E,T>(gmath.sub(a.Scalar, b.Scalar));    

        [MethodImpl(Inline)]
        public static @enum<E,T> mul<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum            
            where T : unmanaged
                => new @enum<E,T>(gmath.mul(a.Scalar, b.Scalar));    

        [MethodImpl(Inline)]
        public static @enum<E,T> div<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum            
            where T : unmanaged
                => new @enum<E,T>(gmath.div(a.Scalar, b.Scalar));    

        [MethodImpl(Inline)]
        public static @enum<E,T> mod<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum            
            where T : unmanaged
                => new @enum<E,T>(gmath.mod(a.Scalar, b.Scalar));    

        [MethodImpl(Inline)]
        public static @enum<E,T> and<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum            
            where T : unmanaged
                => new @enum<E,T>(gmath.and(a.Scalar, b.Scalar));    

        [MethodImpl(Inline)]
        public static @enum<E,T> or<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum            
            where T : unmanaged
                => new @enum<E,T>(gmath.or(a.Scalar, b.Scalar));    

        [MethodImpl(Inline)]
        public static @enum<E,T> xor<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum            
            where T : unmanaged
                => new @enum<E,T>(gmath.xor(a.Scalar, b.Scalar));    

        [MethodImpl(Inline)]
        public static @enum<E,T> sll<E,T>(@enum<E,T> a, byte count)
            where E : unmanaged, Enum            
            where T : unmanaged
                => new @enum<E,T>(gmath.sll(a.Scalar, count));    

        [MethodImpl(Inline)]
        public static @enum<E,T> srl<E,T>(@enum<E,T> a, byte count)
            where E : unmanaged, Enum            
            where T : unmanaged
                => gmath.srl(a.Scalar, count);
    }
}