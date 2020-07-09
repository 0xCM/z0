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
            => new Ref<T>(core.@ref(core.pvoid(src), core.size<T>(count)));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe Ref<T> from<T>(in T src, int count)
            => new Ref<T>(core.@ref(core.pvoid(src), core.size<T>((uint)count)));

        [MethodImpl(Inline), Op]
        public static unsafe Ref<T> from<T>(T[] src)
            => from(core.span(src));

        [MethodImpl(Inline)]
        public static unsafe Ref<T> from<T>(Span<T> src)
            => new Ref<T>(define(core.pvoid(core.first(src)), core.size<T>((uint)src.Length)));

        [MethodImpl(Inline)]
        public static unsafe Ref<T> one<T>(in T src)
            => new Ref<T>(core.@ref(core.pvoid(src), core.size<T>()));

        [MethodImpl(Inline), Op]
        public static unsafe Ref boxed(object src)
            => core.@ref(core.pvoid(src), 8);

        [MethodImpl(Inline), Op]
        public static unsafe Ref from(sbyte[] src)
            => core.@ref(core.pvoid(@core.first(core.span(src))), (uint)src.Length);

        [MethodImpl(Inline), Op]
        public static unsafe Ref from(byte[] src)
            => core.@ref(core.pvoid(@core.first(core.span(src))), (uint)src.Length);

        [MethodImpl(Inline), Op]
        public static unsafe Ref from(ulong[] src)
            => core.@ref(core.pvoid(@core.first(core.span(src))), (uint)src.Length);

        [MethodImpl(Inline)]
        static unsafe Ref define(void* pSrc, ulong size)
            => new Ref((ulong)pSrc, (uint)size);

        [MethodImpl(Inline)]
        static unsafe Ref define(void* pSrc, int size)
            => new Ref((ulong)pSrc, (uint)size);
    }
}