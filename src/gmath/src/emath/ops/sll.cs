//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct emath
    {
        [MethodImpl(Inline)]
        public static @enum<E,T> sll<E,T>(@enum<E,T> a, byte count)
            where E : unmanaged, Enum
            where T : unmanaged
                => new @enum<E,T>(gmath.sll(a.Scalar, count));

        [MethodImpl(Inline)]
        public static uint sll<E>(bit src, E offset)
            where E : unmanaged, Enum
                => gmath.sll((uint)src, @as<E,byte>(offset));

        [MethodImpl(Inline)]
        public static T sll<T,E>(T src, E offset)
            where T : unmanaged
            where E : unmanaged, Enum
                => gmath.sll(src, ClrEnums.scalar<E,byte>(offset));
    }
}