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
        public static SegRef<T> define<T>(in T src, uint size)
            => new SegRef<T>(new SegRef(address(src), size));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static SegRef<byte> define(in byte src, uint size)
            => new SegRef<byte>(new SegRef(address(src), size));

        [MethodImpl(Inline), Op]
        public static Span<byte> replicate(MemoryRange src)
        {
            Span<byte> dst = alloc<byte>(src.Length);
            memory.copy(src, dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static void refs<T>(ReadOnlySpan<T> src, Span<SegRef<T>> dst)
            where T : struct
        {
            for(var i=0u; i<src.Length; i++)
                seek(dst,i) = define(skip<T>(src,i), size<T>());
        }

        // [MethodImpl(Inline), Op, Closures(Closure)]
        // public static unsafe SegRef<T> one<T>(in T src)
        //     => new SegRef<T>(segref(pvoid(src), size<T>()));

        // [MethodImpl(Inline), Op]
        // public static unsafe SegRef boxed(object src)
        //     => segref(pvoid(src), 8);
    }
}