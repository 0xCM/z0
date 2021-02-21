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
        public static bit state<E>(Flags8<E> src, Pow2x8 flag)
            where E : unmanaged, Enum
                => (bw8(src.Value) & bw8(flag)) != 0;

        [MethodImpl(Inline)]
        public static bit state<E>(Flags16<E> src, Pow2x16 flag)
            where E : unmanaged, Enum
                => (bw16(src.Value) & bw16(flag)) != 0;

        [MethodImpl(Inline)]
        public static bit state<E>(Flags32<E> src, Pow2x32 flag)
            where E : unmanaged, Enum
                => (bw32(src.Value) & bw32(flag)) != 0;

        [MethodImpl(Inline)]
        public static bit state<E>(Flags64<E> src, Pow2x64 flag)
            where E : unmanaged, Enum
                => (bw64(src.Value) & bw64(flag)) != 0;

        [MethodImpl(Inline)]
        public static bit state<E>(Flags8<E> src, E flag)
            where E : unmanaged, Enum
                => bit.test(u8(src.Value), (byte)Pow2.log2(u8(flag)));

        [MethodImpl(Inline)]
        public static bit state<E>(Flags16<E> src, E flag)
            where E : unmanaged, Enum
                => bit.test(u16(src.Value), (byte)Pow2.log2(u16(flag)));

        [MethodImpl(Inline)]
        public static bit state<E>(Flags32<E> src, E flag)
            where E : unmanaged, Enum
                => bit.test(u32(src.Value), (byte)Pow2.log2(u32(flag)));

        [MethodImpl(Inline)]
        public static bit state<E>(Flags64<E> src, E flag)
            where E : unmanaged, Enum
                => bit.test(u64(src.Value), (byte)Pow2.log2(u64(flag)));
    }
}