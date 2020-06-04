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
    
    [ApiHost]
    public unsafe class ResourceTools : IApiHost<ResourceTools>
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> extract(in ResIdentity<byte> id)
            => resource<byte>(id.Location, id.CellCount);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> extract(in ResIdentity<char> id)
            => resource<char>(id.Location, id.CellCount);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> segment(in ResIdentity<char> res, int i0, int i1)
            => segment((char*)res.Location, i0, i1);        

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> segment(in ResIdentity<byte> res, int i0, int i1)
            => resource<byte>(res.Location, (i1 - i0 + 1));                
        
        [MethodImpl(Inline), Op]
        public static ulong location(string src)
        {
            fixed(char* pHead = src)            
            {
                return (ulong)pHead;
            }
        }

        [MethodImpl(Inline), Op]
        public static void locations(ReadOnlySpan<string> src, Span<ulong> dst)
        {
            ref readonly var r0 = ref head(src);
            for(var i=0; i<src.Length; i++)
                dst[i] = location(skip(r0,i));
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

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> resource<T>(ResourceMember<T> member, int i0, int i1)
            where T : unmanaged
                => segment((T*)member.Location, i0, i1);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> resource<T>(ResourceMember member, int i0, int i1)
            where T : unmanaged
                => segment((T*)member.Location, i0, i1);

        [MethodImpl(Inline)]
        public static ulong location<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => (ulong)pointer(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> segment<T>(T* pSrc, int i0, int i1)
            where T : unmanaged
        {
            var count = i1 - i0 + 1;
            var pFirst = Unsafe.Add<T>(pSrc, count);
            ref var first = ref Unsafe.AsRef<T>(pFirst);
            return MemoryMarshal.CreateReadOnlySpan<T>(ref first, count);      
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> resource<T>(ulong location, int cells)
            where T : unmanaged
        {
            var pFirst = (T*)location;
            ref var first = ref Unsafe.AsRef<T>(pFirst);
            return MemoryMarshal.CreateReadOnlySpan<T>(ref first, cells);      
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> segment<T>(ReadOnlySpan<T> src, int i0, int i1)
            where T : unmanaged
        {
            var count = i1 - i0 + 1;
            ref readonly var first = ref skip(src, i0);
            return MemoryMarshal.CreateReadOnlySpan(ref edit(first), count);      
        }

        [MethodImpl(Inline)]
        public static ResourceMember describe<T>(MemberInfo member, ReadOnlySpan<T> src)
            where T : unmanaged
        {
            ref readonly var rHead = ref head(src);
            var pHead = Unsafe.AsPointer(ref edit(rHead));
            var cellcount = (uint)src.Length;
            var cellsize = (uint)Unsafe.SizeOf<T>();
            return ResourceMember.Define(member, (ulong)pHead, cellcount, cellcount*cellsize);
        }

        [MethodImpl(Inline)]
        public static T* pointer<T>(in T src)
            where T : unmanaged
                => (T*)Unsafe.AsPointer(ref edit(src));

        [MethodImpl(Inline)]
        public static ulong location<T>(in T src)
            where T : unmanaged
                => (ulong)pointer(src);

        [MethodImpl(Inline)]
        public static T* pointer<T>(ReadOnlySpan<T> src)
            where T : unmanaged
        {
            ref readonly var rHead = ref head(src);
            return (T*)Unsafe.AsPointer(ref edit(rHead));
        }
    }
}