//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct ImmValues
    {
        [MethodImpl(Inline), Op]
        public static Imm8 imm8(byte src)
            => new Imm8(src);

        [MethodImpl(Inline), Op]
        public static Imm16 imm16(ushort src)
            => new Imm16(src);

        [MethodImpl(Inline), Op]
        public static Imm32 imm32(uint src)
            => new Imm32(src);

        [MethodImpl(Inline), Op]
        public static Imm64 imm64(uint src)
            => new Imm64(src);

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static Imm8<T> imm8<T>(T src)
            where T : unmanaged
                => new Imm8<T>(src);

        [MethodImpl(Inline), Op, Closures(UInt8k | UInt16k)]
        public static Imm16<T> imm16<T>(T src)
            where T : unmanaged
                => new Imm16<T>(src);

        [MethodImpl(Inline), Op, Closures(UInt8k | UInt16k | UInt32k)]
        public static Imm32<T> imm32<T>(T src)
            where T : unmanaged
                => new Imm32<T>(src);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Imm64<T> imm64<T>(T src)
            where T : unmanaged
                => new Imm64<T>(src);

        [MethodImpl(Inline)]
        public static Imm<W,T> imm<W,T>(T src)
            where T : unmanaged
            where W : unmanaged, INumericWidth
                => new Imm<W,T>(src);

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static Imm<W8,T> imm<T>(W8 w, T src)
            where T : unmanaged
                => imm<W8,T>(src);

        [MethodImpl(Inline), Op, Closures(UInt8k | UInt16k)]
        public static Imm<W16,T> imm<T>(W16 w, T src)
            where T : unmanaged
                => imm<W16,T>(src);

        [MethodImpl(Inline), Op, Closures(UInt8k | UInt16k | UInt32k)]
        public static Imm<W32,T> imm<T>(W32 w, T src)
            where T : unmanaged
                => imm<W32,T>(src);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Imm<W64,T> imm<T>(W64 w, T src)
            where T : unmanaged
                => imm<W64,T>(src);
    }
}