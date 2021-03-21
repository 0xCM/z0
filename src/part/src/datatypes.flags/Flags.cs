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

    public readonly partial struct Flags
    {
        [MethodImpl(Inline)]
        public static Flags8<E> flags8<E>(E e)
            where E : unmanaged, Enum
                => new Flags8<E>(e);

        [MethodImpl(Inline)]
        public static Flags16<E> flags16<E>(E e)
            where E : unmanaged, Enum
                => new Flags16<E>(e);

        [MethodImpl(Inline)]
        public static Flags32<E> flags32<E>(E e)
            where E : unmanaged, Enum
                => new Flags32<E>(e);

        [MethodImpl(Inline)]
        public static Flags64<E> flags64<E>(E e)
            where E : unmanaged, Enum
                => new Flags64<E>(e);
    }
}