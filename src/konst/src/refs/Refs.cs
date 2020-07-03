//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.InteropServices.MemoryMarshal;
    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    [ApiHost]
    public readonly struct Refs
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe Ref<T> from<T>(in T src, uint count)
            => new Ref<T>(define(ptr(src), size<T>(count)));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe Ref<T> from<T>(in T src, int count)
            => new Ref<T>(define(ptr(src), size<T>((uint)count)));

        [MethodImpl(Inline), Op]
        public static unsafe ConstRef<char> from(string src)
            => new ConstRef<char>(define(ptr(@ref(span(src))), src.Length));

        [MethodImpl(Inline), Op]
        public static unsafe Ref<T> from<T>(T[] src)
            => from(span(src));

        [MethodImpl(Inline)]
        public static unsafe ConstRef<T> from<T>(ReadOnlySpan<T> src)
            => new ConstRef<T>(define(ptr(@ref(src)), size<T>((uint)src.Length)));

        [MethodImpl(Inline)]
        public static unsafe Ref<T> from<T>(Span<T> src)
            => new Ref<T>(define(ptr(@ref(src)), size<T>((uint)src.Length)));

        [MethodImpl(Inline)]
        public static unsafe ConstRef<T> @const<T>(in T src, uint count)
            => new ConstRef<T>(define(ptr(src), size<T>(count)));

        [MethodImpl(Inline)]
        public static unsafe Ref<T> one<T>(in T src)
            where T : unmanaged
                => new Ref<T>(define(ptr(src), size<T>()));

        [MethodImpl(Inline), Op]
        public static unsafe Ref boxed(object src)
            => define(ptr(src), 8);

        [MethodImpl(Inline), Op]
        static unsafe Ref from(sbyte[] src)
            => define(ptr(@ref(span(src))), src.Length);

        [MethodImpl(Inline), Op]
        static unsafe Ref from(byte[] src)
            => define(ptr(@ref(span(src))), src.Length);

        [MethodImpl(Inline), Op]
        static unsafe Ref from(ulong[] src)
            => define(ptr(@ref(span(src))), src.Length);

        [MethodImpl(Inline)]
        static uint size<T>(uint count)
            => (uint)SizeOf<T>() * count;

        [MethodImpl(Inline)]
        static uint size<T>()
            => (uint)SizeOf<T>();

        [MethodImpl(Inline)]
        static unsafe Span<T> cover<T>(ulong location, uint count)
            => cover<T>((void*)location, count); 

        [MethodImpl(Inline)]
        static unsafe Span<T> cover<T>(void* pSrc, uint count)
            => CreateSpan(ref @as<T>(pSrc), (int)count); 

        [MethodImpl(Inline)]
        internal static unsafe ref T @ref<T>(ReadOnlySpan<T> src)
            => ref GetReference(src);           

        [MethodImpl(Inline)]
        static unsafe ref T @ref<T>(Span<T> src)
            => ref GetReference(src);           

        [MethodImpl(Inline)]
        internal static unsafe ref T @ref<T>(in T src)
            => ref AsRef(src);

        [MethodImpl(Inline)]
        static unsafe ref T @as<T>(void* pSrc)
            => ref AsRef<T>(pSrc);

        [MethodImpl(Inline)]
        static unsafe void* ptr<T>(in T src)
            => AsPointer<T>(ref @ref(src));   

        [MethodImpl(Inline)]
        static unsafe Span<byte> cover(ulong location, uint count)
            => cover<byte>((void*)location, count);

        [MethodImpl(Inline)]
        static Span<T> span<T>(T[] src)
            => src;

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> span(string src)
            => src;

        [MethodImpl(Inline)]
        static Ref define(ulong location, uint size)
            => new Ref(location, size);

        [MethodImpl(Inline)]
        static unsafe Ref define(void* pSrc, ulong size)
            => new Ref((ulong)pSrc, (uint)size);

        [MethodImpl(Inline)]
        static unsafe Ref define(void* pSrc, int size)
            => new Ref((ulong)pSrc, (uint)size);
    }
}