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
        [MethodImpl(Inline), Op]
        public static byte scale<T>()
            => (byte)size<T>();

        [MethodImpl(Inline)]
        public static uint size<T>(T t = default)
            => (uint)SizeOf<T>();

        [MethodImpl(Inline)]
        public static uint size<T>(uint count)
            => (uint)SizeOf<T>() * count;

        [MethodImpl(Inline), Op]
        public static uint size(string src)
            => (uint)src.Length*scale<char>();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static byte size<T>(W8 w)
            => (byte)SizeOf<T>();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort size<T>(W16 w)
            => (ushort)SizeOf<T>();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint size<T>(W32 w)
            => (uint)SizeOf<T>();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong size<T>(W64 w)
            => (ulong)SizeOf<T>();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static sbyte size<T>(W8i w)
            => (sbyte)SizeOf<T>();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static short size<T>(W16i w)
            => (short)SizeOf<T>();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static int size<T>(W32i w)
            => (int)SizeOf<T>();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static long size<T>(W64i w)
            => (long)SizeOf<T>();
    }
}