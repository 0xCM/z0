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

    [ApiHost(ApiNames.MemoryRefs, true)]
    public readonly partial struct MemRefs
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Ref<byte> from(ReadOnlySpan<byte> src)
            => new Ref<byte>(new Ref(address(src), (uint)src.Length));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Ref<T> define<T>(in T src, uint size)
            => new Ref<T>(new Ref(address(src), size));

        [MethodImpl(Inline), Op]
        public static Span<byte> replicate(MemoryRange src)
        {
            Span<byte> dst = alloc<byte>(src.Length);
            memory.copy(src, dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static void refs<T>(ReadOnlySpan<T> src, Span<Ref<T>> dst)
            where T : struct
        {
            for(var i=0u; i<src.Length; i++)
                seek(dst,i) = define(skip<T>(src,i), size<T>());
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Ref<T> one<T>(in T src)
            => new Ref<T>(segref(pvoid(src), size<T>()));

        [MethodImpl(Inline), Op]
        public static unsafe Ref boxed(object src)
            => segref(pvoid(src), 8);
    }
}