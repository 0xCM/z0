//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;
    using static System.Runtime.InteropServices.MemoryMarshal;

    readonly partial struct Imagine
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public unsafe static ReadOnlySpan<T> segment<T>(ReadOnlySpan<T> src, int i0, int i1)
            where T : unmanaged
        {
            var count = i1 - i0 + 1;
            ref readonly var first = ref skip(src, i0);
            return CreateReadOnlySpan(ref edit(first), count);      
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> segment<S,T>(ReadOnlySpan<S> src, int i0, int i1)
            where S : unmanaged
            where T : unmanaged
        {
            var count = i1 - i0 + 1;
            ref readonly var first = ref skip(src, i0);
            return cast<S,T>(CreateReadOnlySpan(ref edit(first), count));      
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public unsafe static ReadOnlySpan<T> segment<T>(T* pSrc, int i0, int i1)
            where T : unmanaged
        {
            var count = i1 - i0 + 1;
            var pFirst = Unsafe.Add<T>(pSrc, count);
            ref var first = ref Unsafe.AsRef<T>(pFirst);
            return CreateReadOnlySpan<T>(ref first, count);      
        }

    }
}