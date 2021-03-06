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
    }
}