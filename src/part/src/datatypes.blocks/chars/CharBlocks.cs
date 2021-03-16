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

    [ApiHost]
    public readonly partial struct CharBlocks
    {
        const NumericKind Closure = UInt64k;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T init<T>(ReadOnlySpan<char> src, out T dst)
            where T : unmanaged, ICharBlock<T>
        {
            dst = default;
            return ref copy(src, ref dst);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T init<T>(ReadOnlySpan<char> src, in T t0, out T dst)
            where T : unmanaged, ICharBlock<T>
        {
            dst = t0;
            return ref copy(src, ref dst);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T copy<T>(ReadOnlySpan<char> src, ref T dst)
            where T : unmanaged, ICharBlock<T>
        {
            var length = (uint)root.min(src.Length, size<T>()/2);
            memory.copy(first(src), ref @as<T,char>(dst), length);
            return ref dst;
        }
    }
}