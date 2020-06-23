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

    public readonly partial struct emath
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
        public static @enum<E,T> nand<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum            
            where T : unmanaged
                => new @enum<E,T>(gmath.nand(a.Scalar, b.Scalar));    

        [MethodImpl(Inline)]
        public static @enum<E,T> nor<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum            
            where T : unmanaged
                => new @enum<E,T>(gmath.nor(a.Scalar, b.Scalar));    

        [MethodImpl(Inline)]
        public static @enum<E,T> xnor<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum            
            where T : unmanaged
                => new @enum<E,T>(gmath.xnor(a.Scalar, b.Scalar));    

        [MethodImpl(Inline)]
        public static bit eq<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum            
            where T : unmanaged
                => gmath.eq(a.Scalar, b.Scalar);    

        [MethodImpl(Inline)]
        public static bit neq<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum            
            where T : unmanaged
                => gmath.neq(a.Scalar, b.Scalar);    

        [MethodImpl(Inline)]
        public static bit lt<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum            
            where T : unmanaged
                => gmath.lt(a.Scalar, b.Scalar);    

        [MethodImpl(Inline)]
        public static bit lteq<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum            
            where T : unmanaged
                => gmath.lteq(a.Scalar, b.Scalar);    

        [MethodImpl(Inline)]
        public static bit gt<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum            
            where T : unmanaged
                => gmath.lt(a.Scalar, b.Scalar);    

        [MethodImpl(Inline)]
        public static bit gteq<E,T>(@enum<E,T> a, @enum<E,T> b)
            where E : unmanaged, Enum            
            where T : unmanaged
                => gmath.lteq(a.Scalar, b.Scalar);    

        [MethodImpl(Inline)]
        public static @enum<E,T> sll<E,T>(@enum<E,T> a, byte count)
            where E : unmanaged, Enum            
            where T : unmanaged
                => new @enum<E,T>(gmath.sll(a.Scalar, count));    

        [MethodImpl(Inline)]
        public static @enum<E,T> srl<E,T>(@enum<E,T> a, byte count)
            where E : unmanaged, Enum            
            where T : unmanaged
                => new @enum<E,T>(gmath.srl(a.Scalar, count));    

        [MethodImpl(Inline)]
        public static @enum<E,T> negate<E,T>(@enum<E,T> a)
            where E : unmanaged, Enum            
            where T : unmanaged
                => new @enum<E,T>(gmath.negate(a.Scalar));    

        [MethodImpl(Inline)]
        public static bit nonz<E,T>(@enum<E,T> a)
            where E : unmanaged, Enum            
            where T : unmanaged
                => gmath.nonz(a.Scalar);    

        [MethodImpl(Inline)]
        public static @enum<E,T> not<E,T>(@enum<E,T> a)
            where E : unmanaged, Enum            
            where T : unmanaged
                => new @enum<E,T>(gmath.not(a.Scalar));
    }
}