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
    using static Konst;
  
    partial class Symbolic
    {
        [MethodImpl(Inline), Op]
        public static AsciResource<asci2> resource(string name, asci2 content, string description)
            => AsciCodes.resource(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResource<asci4> resource(string name, asci4 content, string description)
            => AsciCodes.resource(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResource<asci8> resource(string name, asci8 content, string description)
            => AsciCodes.resource(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResource<asci16> resource(string name, asci16 content, string description)
            => AsciCodes.resource(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResource<asci32> resource(string name, asci32 content, string description)
            => AsciCodes.resource(name,content,description);

        [MethodImpl(Inline), Op]
        public static AsciResource<asci64> resource(string name, asci64 content, string description)
            => AsciCodes.resource(name,content,description);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public unsafe static ResourceMember resource<T>(MemberInfo member, ReadOnlySpan<T> src)
            where T : unmanaged
                => ResourceMember.Define(member, MemoryRef.From(cast<T,byte>(src)));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ReadOnlySpan<T> resource<T>(ResourceMember member, int i0, int i1)
            where T : unmanaged
                => segment(member.Address.ToPointer<T>(), i0, i1);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public unsafe static ReadOnlySpan<T> resource<T>(ulong location, int cells)
            where T : unmanaged
        {
            var pFirst = (T*)location;
            ref var first = ref Unsafe.AsRef<T>(pFirst);
            return MemoryMarshal.CreateReadOnlySpan<T>(ref first, cells);      
        }
    }
}