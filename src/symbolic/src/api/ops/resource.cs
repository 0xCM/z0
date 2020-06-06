//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static Control;
    using static Seed;
  
    partial class Symbolic
    {
        [MethodImpl(Inline)]
        public unsafe static ResourceMember resource<T>(MemberInfo member, ReadOnlySpan<T> src)
            where T : unmanaged
        {
            ref readonly var rHead = ref head(src);
            var pHead = Unsafe.AsPointer(ref edit(rHead));
            var cellcount = (uint)src.Length;
            var cellsize = (uint)Unsafe.SizeOf<T>();
            return ResourceMember.Define(member, (ulong)pHead, cellcount, cellcount*cellsize);
        }

        [MethodImpl(Inline)]
        public static unsafe ReadOnlySpan<T> resource<T>(ResourceMember<T> member, int i0, int i1)
            where T : unmanaged
                => segment((T*)member.Location, i0, i1);

        [MethodImpl(Inline)]
        public static unsafe ReadOnlySpan<T> resource<T>(ResourceMember member, int i0, int i1)
            where T : unmanaged
                => segment((T*)member.Location, i0, i1);

        [MethodImpl(Inline)]
        public unsafe static ReadOnlySpan<T> resource<T>(ulong location, int cells)
            where T : unmanaged
        {
            var pFirst = (T*)location;
            ref var first = ref Unsafe.AsRef<T>(pFirst);
            return MemoryMarshal.CreateReadOnlySpan<T>(ref first, cells);      
        }
    }
}