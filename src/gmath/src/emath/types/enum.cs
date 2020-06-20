//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public class @enum
    {
        [MethodImpl(Inline)]
        public static @enum<E,T> define<E,T>(E literal, T t = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => new @enum<E,T>(literal);
        
        [MethodImpl(Inline)]
        public static @enum<E,byte> e8u<E>(E literal)
            where E : unmanaged, Enum
                => define<E,byte>(literal);            

        [MethodImpl(Inline)]
        public static @enum<E,sbyte> e8i<E>(E literal)
            where E : unmanaged, Enum
                => define<E,sbyte>(literal);            

        [MethodImpl(Inline)]
        public static @enum<E,ushort> e16u<E>(E literal)
            where E : unmanaged, Enum
                => define<E,ushort>(literal);            

        [MethodImpl(Inline)]
        public static @enum<E,int> e32i<E>(E literal)
            where E : unmanaged, Enum
                => define<E,int>(literal);            

        [MethodImpl(Inline)]
        public static @enum<E,uint> e32u<E>(E literal)
            where E : unmanaged, Enum
                => define<E,uint>(literal);            

        [MethodImpl(Inline)]
        public static @enum<E,long> e64i<E>(E literal)
            where E : unmanaged, Enum
                => define<E,long>(literal);            

        [MethodImpl(Inline)]
        public static @enum<E,ulong> e64u<E>(E literal)
            where E : unmanaged, Enum
                => define<E,ulong>(literal);            
    }
}