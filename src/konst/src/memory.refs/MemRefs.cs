//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.MemoryRefs, true)]
    public readonly partial struct MemRefs
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe void copy<T>(MemorySegment src, Span<T> dst)
            where T : unmanaged
                => MemoryReader.create<T>(src).ReadAll(dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Ref<byte> from(ReadOnlySpan<byte> src)
            => new Ref<byte>(new Ref(memory.address(src), (uint)src.Length));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Ref<T> define<T>(in T src, uint size)
            => new Ref<T>(new Ref(memory.address(src), size));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> read<T>(in Ref src)
            => src.As<T>();

        [MethodImpl(Inline), Op]
        public static Span<byte> replicate(in MemorySegment src)
        {
            Span<byte> dst = sys.alloc<byte>(src.DataSize);
            copy(src, dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static void refs<T>(ReadOnlySpan<T> src, Span<Ref<T>> dst)
            where T : struct
        {
            for(var i=0u; i<src.Length; i++)
                memory.seek(dst,i) = define(memory.skip<T>(src,i), memory.size<T>());
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Ref<T> one<T>(in T src)
            => new Ref<T>(memory.segref(pvoid(src), size<T>()));

        [MethodImpl(Inline), Op]
        public static unsafe Ref boxed(object src)
            => memory.segref(pvoid(src), 8);
    }
}