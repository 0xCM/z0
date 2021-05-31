//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly partial struct CharBlocks
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T init<T>(ReadOnlySpan<char> src, out T dst)
            where T : unmanaged
        {
            dst = default;
            return ref copy(src, ref dst);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T init<T>(ReadOnlySpan<char> src, in T t0, out T dst)
            where T : unmanaged
        {
            dst = t0;
            return ref copy(src, ref dst);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T copy<T>(ReadOnlySpan<char> src, ref T dst)
            where T : unmanaged
        {
            var count = (uint)core.min(src.Length, size<T>()/2);
            copy(first(src), ref @as<T,char>(dst), count);
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        static void copy(in byte src, ref byte dst, uint count)
        {
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i);
        }

        [MethodImpl(Inline)]
        static void copy<S,T>(in S src, ref T dst, uint srcCount, uint dstOffset = 0)
            where S: unmanaged
            where T :unmanaged
                => copy(core.u8(src), ref core.uint8(ref seek(dst, dstOffset)), srcCount*size<S>());
    }
}