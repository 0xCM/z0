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

    [ApiHost]
    public readonly partial struct Flags
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static Flags8<K> flags8<K>(K state)
            where K : unmanaged
                => new Flags8<K>(state);

        [MethodImpl(Inline), Op, Closures(UInt8k | UInt16k)]
        public static Flags16<K> flags16<K>(K state)
            where K : unmanaged
                => new Flags16<K>(state);

        [MethodImpl(Inline), Op, Closures(UInt8k | UInt16k | UInt32k)]
        public static Flags32<K> flags32<K>(K state)
            where K : unmanaged
                => new Flags32<K>(state);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Flags64<K> flags64<K>(K state)
            where K : unmanaged
                => new Flags64<K>(state);
    }
}