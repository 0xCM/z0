//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly partial struct emath
    {
        [MethodImpl(Inline)]
        public static @enum<E,T> define<E,T>(E src, T t = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => new @enum<E,T>(src);

        [MethodImpl(Inline)]
        public static @enum<E,byte> e8u<E>(E src)
            where E : unmanaged, Enum
                => define<E,byte>(src);

        [MethodImpl(Inline)]
        public static @enum<E,sbyte> e8i<E>(E src)
            where E : unmanaged, Enum
                => define<E,sbyte>(src);

        [MethodImpl(Inline)]
        public static @enum<E,ushort> e16u<E>(E src)
            where E : unmanaged, Enum
                => define<E,ushort>(src);

        [MethodImpl(Inline)]
        public static @enum<E,int> e32i<E>(E src)
            where E : unmanaged, Enum
                => define<E,int>(src);

        [MethodImpl(Inline)]
        public static @enum<E,uint> e32u<E>(E src)
            where E : unmanaged, Enum
                => define<E,uint>(src);

        [MethodImpl(Inline)]
        public static @enum<E,long> e64i<E>(E src)
            where E : unmanaged, Enum
                => define<E,long>(src);

        [MethodImpl(Inline)]
        public static @enum<E,ulong> e64u<E>(E src)
            where E : unmanaged, Enum
                => define<E,ulong>(src);
    }
}