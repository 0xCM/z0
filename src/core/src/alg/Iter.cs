//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly partial struct Iter
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public unsafe static void run<T>(Span<T> src, Action<T> f)
            where T : unmanaged
        {
            fixed(T* pSrc = src)
            {
                var it = unmanaged(pSrc, src.Length);
                while(it.Next(out T current))
                    f(current);
            }
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe UnmanagedReader<T> unmanaged<T>(T* pSrc, int count)
            where T : unmanaged
                => new UnmanagedReader<T>(pSrc, count);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static bool next<T>(ref UnmanagedReader<T> src, out T dst)
            where T : unmanaged
                => src.Next(out dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T next<T>(ref UnmanagedReader<T> src)
            where T : unmanaged
                => ref src.Next();
    }
}