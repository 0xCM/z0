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
    using static Root;

    partial class Symbolic
    {
        [MethodImpl(Inline), Op]
        public unsafe static ReadOnlySpan<char> segment(in ResIdentity<char> res, int i0, int i1)
            => segment((char*)res.Location, i0, i1);        

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> segment(in ResIdentity<byte> res, int i0, int i1)
            => SymbolicData.resource<byte>(res.Location, (i1 - i0 + 1));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public unsafe static ReadOnlySpan<T> segment<T>(T* pSrc, int i0, int i1)
            where T : unmanaged
        {
            var count = i1 - i0 + 1;
            var pFirst = Unsafe.Add<T>(pSrc, count);
            ref var first = ref Unsafe.AsRef<T>(pFirst);
            return MemoryMarshal.CreateReadOnlySpan<T>(ref first, count);      
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public unsafe static ReadOnlySpan<T> segment<T>(ReadOnlySpan<T> src, int i0, int i1)
            where T : unmanaged
        {
            var count = i1 - i0 + 1;
            ref readonly var first = ref skip(src, i0);
            return MemoryMarshal.CreateReadOnlySpan(ref edit(first), count);      
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> segment<S,T>(ReadOnlySpan<S> src, int i0, int i1)
            where S : unmanaged
            where T : unmanaged
        {
            var count = i1 - i0 + 1;
            ref readonly var first = ref skip(src, i0);
            return cast<S,T>(MemoryMarshal.CreateReadOnlySpan(ref edit(first), count));      
        }
    }
}