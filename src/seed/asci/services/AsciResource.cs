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

    using static Root;
    using static Konst;

    [ApiHost]
    public readonly struct AsciResource
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> load(in ResIdentity<byte> id)
            => load<byte>(id.Location, id.CellCount);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> load(in ResIdentity<char> id)
            => load<char>(id.Location, id.CellCount);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public unsafe static ReadOnlySpan<T> load<T>(ulong location, int cells)
            where T : unmanaged
        {
            var pFirst = (T*)location;
            ref var first = ref Unsafe.AsRef<T>(pFirst);
            return MemoryMarshal.CreateReadOnlySpan<T>(ref first, cells);      
        }        

        [MethodImpl(Inline), Op]
        public static AsciResource<asci2> define(in asci32 name, asci2 content, asci64? description = null)
            => resource(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResource<asci4> define(in asci32 name, asci4 content, asci64? description = null)
            => resource(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResource<asci8> define(in asci32 name, asci8 content, asci64? description = null)
            => resource(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResource<asci16> define(in asci32 name, asci16 content, asci64? description = null)
            => resource(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResource<asci32> define(in asci32 name, asci32 content, asci64? description = null)
            => resource(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResource<asci64> define(in asci32 name, asci64 content, asci64? description = null)
            => resource(name,content,description);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public unsafe static ResMember define<T>(MemberInfo member, ReadOnlySpan<T> src)
            where T : unmanaged
                => ResMember.Define(member, MemRef.memref(cast<T,byte>(src)));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ReadOnlySpan<T> define<T>(ResMember member, int i0, int i1)
            where T : unmanaged
                => segment(member.Address.ToPointer<T>(), i0, i1);

        /// <summary>
        /// Creates an asci resource
        /// </summary>
        /// <param name="name">The resource name</param>
        /// <param name="content">The resource data</param>
        /// <param name="description">The resource description</param>
        /// <typeparam name="A">The asci element type</typeparam>
        [MethodImpl(Inline)]
        static AsciResource<A> resource<A>(asci32 name, A content, asci64? description = null)
            where A : IAsciSequence
                => new AsciResource<A>(name, content, description);

        /// <summary>
        /// Creates an eponymous asci resource
        /// </summary>
        /// <param name="content">The resource data</param>
        /// <param name="description">The resource description</param>
        /// <typeparam name="A">The asci element type</typeparam>
        [MethodImpl(Inline)]
        static AsciResource<A> resource<A>(A content, asci64? description = null)
            where A : IAsciSequence
                => new AsciResource<A>(content.Text, content, description);

        [MethodImpl(Inline)]
        unsafe static ReadOnlySpan<T> resource<T>(ulong location, int cells)
            where T : unmanaged
        {
            var pFirst = (T*)location;
            ref var first = ref Unsafe.AsRef<T>(pFirst);
            return MemoryMarshal.CreateReadOnlySpan<T>(ref first, cells);      
        }

        [MethodImpl(Inline), Op]
        public unsafe static ReadOnlySpan<char> segment(in ResIdentity<char> res, int i0, int i1)
            => segment((char*)res.Location, i0, i1);        

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> segment(in ResIdentity<byte> res, int i0, int i1)
            => resource<byte>(res.Location, (i1 - i0 + 1));

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