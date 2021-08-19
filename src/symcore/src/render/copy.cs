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

    partial struct SymbolicRender
    {
        [MethodImpl(Inline), Op]
        public static uint copy(ReadOnlySpan<char> src, ref uint i, Span<char> dst)
        {
            var count = src.Length;
            var counter = 0u;
            for(var j=0; j<count; j++, counter++)
                seek(dst, i++) = skip(src, j);
            return counter;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T copy<T>(ReadOnlySpan<char> src, ref T dst)
            where T : unmanaged
        {
            var count = (uint)min(src.Length, size<T>()/2);
            copy(first(src), ref @as<T,char>(dst), count);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T copyfill<T>(ReadOnlySpan<char> src, char c, ref T dst)
            where T : unmanaged
        {
            copy(src, ref dst);
            var count = src.Length;
            var capacity = size<T>()/2;
            if(count < capacity)
            {
                ref var target = ref seek(@as<T,char>(dst),count);
                for(var i=count; i<capacity; i++)
                    seek(target,i) = c;
            }
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