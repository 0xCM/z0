//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Flags
    {
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static Flags8<E> create<E>(W8 w, E e)
            where E : unmanaged
                => new Flags8<E>(e);

        [MethodImpl(Inline), Op, Closures(UInt8k | UInt16k)]
        public static Flags16<E> create<E>(W16 w, E e)
            where E : unmanaged
                => new Flags16<E>(e);

        [MethodImpl(Inline), Op, Closures(UInt8k | UInt16k | UInt32k)]
        public static Flags32<E> create<E>(W32 w, E e)
            where E : unmanaged
                => new Flags32<E>(e);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Flags64<E> create<E>(W64 w, E e)
            where E : unmanaged
                => new Flags64<E>(e);
    }
}
