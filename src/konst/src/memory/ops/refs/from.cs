//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Linq;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Refs
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Ref<T> from<T>(in T src)
            where T : struct
                => new Ref<T>(z.address(src), size<T>());

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Ref<T> from<T>(Vector128<ulong> src)
            => new Ref<T>(new Ref(src));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Ref<T> from<T>(in T src, uint count)
            => new Ref<T>(seg(pvoid(src), size<T>(count)));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Ref<T> from<T>(in T src, int count)
            => new Ref<T>(seg(pvoid(src), size<T>((uint)count)));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Ref<T> from<T>(T[] src)
            => from(span(src));

        [MethodImpl(Inline), Op]
        public static unsafe Ref<sbyte> from(sbyte[] src)
            => seg(address(src), (uint)src.Length);

        [MethodImpl(Inline), Op]
        public static unsafe Ref<byte> from(byte[] src)
            => seg(address(src), (uint)src.Length);

        [MethodImpl(Inline), Op]
        public static unsafe Ref<ulong> from(ulong[] src)
            => seg(address(src), (uint)src.Length);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Ref<T> from<T>(Span<T> src)
            => new Ref<T>(define(pvoid(first(src)), size<T>((uint)src.Length)));
    }
}