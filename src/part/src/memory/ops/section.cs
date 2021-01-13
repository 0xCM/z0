//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static System.Runtime.CompilerServices.Unsafe;
    using static System.Runtime.InteropServices.MemoryMarshal;

    partial struct memory
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public unsafe static ReadOnlySpan<T> section<T>(ReadOnlySpan<T> src, int i0, int i1)
            where T : unmanaged
        {
            var count = i1 - i0 + 1;
            ref readonly var first = ref skip(src, (uint)i0);
            return CreateReadOnlySpan(ref edit(first), count);
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> section<S,T>(ReadOnlySpan<S> src, int i0, int i1)
            where S : unmanaged
            where T : unmanaged
        {
            var count = i1 - i0 + 1;
            ref readonly var first = ref skip(src, (uint)i0);
            return recover<S,T>(CreateReadOnlySpan(ref edit(first), (int)count));
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public unsafe static ReadOnlySpan<T> section<T>(T* pSrc, int i0, int i1)
            where T : unmanaged
        {
            var count = i1 - i0 + 1;
            var pFirst = Add<T>(pSrc, count);
            ref var first = ref AsRef<T>(pFirst);
            return CreateReadOnlySpan<T>(ref first, count);
        }
    }
}