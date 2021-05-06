//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    partial struct Flags
    {
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static bit state<E>(Flags8<E> src, Pow2x8 flag)
            where E : unmanaged
                => (bw8(src.Value) & bw8(flag)) != 0;

        [MethodImpl(Inline), Op, Closures(UInt8k | UInt16k)]
        public static bit state<E>(Flags16<E> src, Pow2x16 flag)
            where E : unmanaged
                => (bw16(src.Value) & bw16(flag)) != 0;

        [MethodImpl(Inline), Op, Closures(UInt8k | UInt16k | UInt32k)]
        public static bit state<E>(Flags32<E> src, Pow2x32 flag)
            where E : unmanaged
                => (bw32(src.Value) & bw32(flag)) != 0;

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bit state<E>(Flags64<E> src, Pow2x64 flag)
            where E : unmanaged
                => (bw64(src.Value) & bw64(flag)) != 0;

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static bit state<E>(Flags8<E> src, E flag)
            where E : unmanaged
                => bit.test(u8(src.Value), (byte)Pow2.log(u8(flag)));

        [MethodImpl(Inline), Op, Closures(UInt8k | UInt16k)]
        public static bit state<E>(Flags16<E> src, E flag)
            where E : unmanaged
                => bit.test(u16(src.Value), (byte)Pow2.log(u16(flag)));

        [MethodImpl(Inline), Op, Closures(UInt8k | UInt16k | UInt32k)]
        public static bit state<E>(Flags32<E> src, E flag)
            where E : unmanaged
                => bit.test(u32(src.Value), (byte)Pow2.log(u32(flag)));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bit state<E>(Flags64<E> src, E flag)
            where E : unmanaged
                => bit.test(u64(src.Value), (byte)Pow2.log(u64(flag)));

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static bit state<T>(Flags<T> src, T flag)
            where T : unmanaged
        {
            if(size<T>() == 1)
                return bit.test(u8(src.Value), (byte)Pow2.log(u8(flag)));
            else if(size<T>() == 2)
                return bit.test(u16(src.Value), (byte)Pow2.log(u16(flag)));
            else if(size<T>() == 4)
                return bit.test(u32(src.Value), (byte)Pow2.log(u32(flag)));
            else
                return bit.test(u64(src.Value), (byte)Pow2.log(u64(flag)));
        }
    }
}