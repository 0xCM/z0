//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static uint bitwidth<T>(T t = default)
            => (uint)SizeOf<T>() * 8;

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static byte bitwidth<T>(W8 w)
            => (byte)(SizeOf<T>() * 8);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ushort bitwidth<T>(W16 w)
            => (ushort)(SizeOf<T>() * 8);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static uint bitwidth<T>(W32 w)
            => (uint)(SizeOf<T>() * 8);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ulong bitwidth<T>(W64 w)
            => (ulong)(SizeOf<T>() * 8);

        [MethodImpl(Inline), Op]
        public static BitSize bitsize<T>()
            => Unsafe.SizeOf<T>()*8;
    }
}