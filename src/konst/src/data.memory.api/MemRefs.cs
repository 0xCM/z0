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
    using static z;

    [ApiHost(ApiNames.MemRefs, true)]
    public readonly partial struct MemRefs
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Ref<byte> from(ReadOnlySpan<byte> src)
            => new Ref<byte>(new Ref(z.address(src), (uint)src.Length));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Ref<T> define<T>(in T src, uint size)
            => new Ref<T>(new Ref(z.address(src), size));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> read<T>(in Ref src)
            => src.As<T>();

        [MethodImpl(Inline), Op]
        public static Span<byte> replicate(in SegRef src)
        {
            Span<byte> dst = sys.alloc<byte>(src.DataSize);
            Copier.copy(src, dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static QuadRef<T> quad<T>(in T r0, in T r1, in T r2, in T r3)
            where T : struct
            => new QuadRef<T>(r0,r1,r2,r3);

        [MethodImpl(Inline), Op]
        public static void refs<T>(ReadOnlySpan<T> src, Span<Ref<T>> dst)
            where T : struct
        {
            for(var i=0u; i<src.Length; i++)
                seek(dst,i) = define(skip<T>(src,i), size<T>());
        }

        [MethodImpl(Inline), Op]
        public static Vector128<ulong> location(in SegRef src)
            => vparts(N128.N, src.Address, (ulong)src.DataSize);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Ref<T> one<T>(in T src)
            => new Ref<T>(segref(pvoid(src), size<T>()));

        [MethodImpl(Inline), Op]
        public static unsafe Ref boxed(object src)
            => segref(pvoid(src), 8);
    }
}