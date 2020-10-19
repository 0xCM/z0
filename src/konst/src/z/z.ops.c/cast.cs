//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static System.Runtime.InteropServices.MemoryMarshal;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static ref T cast<S,T>(in S src)
            => ref @as<S,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T cast<T>(object src)
            => (T)src;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cast<T>(Span<byte> src, int offset, int length)
            where T : unmanaged
                => Cast<byte,T>(src.Slice(offset, (int)(length * size<T>())));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cast<T>(Span<byte> src)
            where T : unmanaged
                => cast<T>(src, 0, (int)(src.Length/size<T>()));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src)
            where T : unmanaged
                => cast<T>(src, 0, (int)(src.Length/size<T>()));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void cast<T>(ReadOnlySpan<object> src, Span<T> dst)
        {
            for(var i=0u; i<src.Length; i++)
                seek(dst, i) = cast<T>(skip(src,i));
        }


        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src, int offset, int length)
            where T : unmanaged
                => Cast<byte,T>(src.Slice(offset, (int)(length * size<T>())));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src, uint offset, uint length)
            where T : unmanaged
                => Cast<byte,T>(src.Slice((int)offset, (int)(length * size<T>())));
    }
}