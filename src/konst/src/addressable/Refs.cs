//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    [ApiHost]
    public readonly struct Refs
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Ref<T> from<T>(Vector128<ulong> src)
            => new Ref<T>(new Ref(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe Ref located(ulong location, uint size)
            => new Ref(location, size);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe Ref<T> from<T>(in T src, uint count)
            => new Ref<T>(z.@ref(z.pvoid(src), z.size<T>(count)));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe Ref<T> from<T>(in T src, int count)
            => new Ref<T>(z.@ref(z.pvoid(src), z.size<T>((uint)count)));

        [MethodImpl(Inline), Op]
        public static unsafe Ref<T> from<T>(T[] src)
            => from(z.span(src));

        [MethodImpl(Inline)]
        public static unsafe Ref<T> from<T>(Span<T> src)
            => new Ref<T>(define(z.pvoid(z.first(src)), z.size<T>((uint)src.Length)));

        [MethodImpl(Inline)]
        public static unsafe Ref<T> one<T>(in T src)
            => new Ref<T>(z.@ref(z.pvoid(src), z.size<T>()));

        [MethodImpl(Inline), Op]
        public static unsafe Ref boxed(object src)
            => z.@ref(z.pvoid(src), 8);

        [MethodImpl(Inline), Op]
        public static unsafe Ref from(sbyte[] src)
            => z.@ref(z.pvoid(z.first(z.span(src))), (uint)src.Length);

        [MethodImpl(Inline), Op]
        public static unsafe Ref from(byte[] src)
            => z.@ref(z.pvoid(z.first(z.span(src))), (uint)src.Length);

        [MethodImpl(Inline), Op]
        public static unsafe Ref from(ulong[] src)
            => z.@ref(z.pvoid(z.first(z.span(src))), (uint)src.Length);

        [MethodImpl(Inline)]
        static unsafe Ref define(void* pSrc, ulong size)
            => new Ref((ulong)pSrc, (uint)size);

        [MethodImpl(Inline)]
        static unsafe Ref define(void* pSrc, int size)
            => new Ref((ulong)pSrc, (uint)size);
    }
}