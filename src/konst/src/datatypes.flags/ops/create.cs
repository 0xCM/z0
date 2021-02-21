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

    partial struct Flags
    {
        [MethodImpl(Inline)]
        public static Flags8<E> create<E>(W8 w, E e)
            where E : unmanaged, Enum
                => new Flags8<E>(e);

        [MethodImpl(Inline)]
        public static Flags16<E> create<E>(W16 w, E e)
            where E : unmanaged, Enum
                => new Flags16<E>(e);

        [MethodImpl(Inline)]
        public static Flags32<E> create<E>(W32 w, E e)
            where E : unmanaged, Enum
                => new Flags32<E>(e);

        [MethodImpl(Inline)]
        public static Flags64<E> create<E>(W64 w, E e)
            where E : unmanaged, Enum
                => new Flags64<E>(e);
    }
}
