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
    partial class text
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T copy<T>(ReadOnlySpan<char> src, ref T dst)
            where T : unmanaged
                => ref TextTools.copy(src, ref dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T copyfill<T>(ReadOnlySpan<char> src, char c, ref T dst)
            where T : unmanaged
        {
            TextTools.copy(src, ref dst);
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
        public static uint copy(string src, ref uint i, Span<char> dst)
        {
            var input = src.ToSpan();
            var count = input.Length;
            var counter = 0u;
            for(var j=0; j<count; j++, counter++)
                seek(dst, i++) = skip(input,j);
            return counter;
        }

        [MethodImpl(Inline), Op]
        public static uint copy(string src, ref char dst)
        {
            var input = src.ToSpan();
            var count = input.Length;
            for(var i=0; i<count; i++)
                seek(dst, i++) = skip(input,i);
            return (uint)count;
        }

        [MethodImpl(Inline), Op]
        public static uint copy(ReadOnlySpan<char> src, ref uint i, Span<char> dst)
        {
            var count = src.Length;
            var counter = 0u;
            for(var j=0; j<count; j++, counter++)
                seek(dst, i++) = skip(src, j);
            return counter;
        }
    }
}