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
    public readonly struct ResMembers
    {
        [MethodImpl(Inline)]
        public static ResIdentity<T> identify<T>(asci32 name, ulong location, int length)
            where T : unmanaged
                => new ResIdentity<T>(name, memref(location, length));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ReadOnlySpan<T> resource<T>(ResMember member, int i0, int i1)
            where T : unmanaged
                => As.segment(member.Address.Pointer<T>(), i0, i1); 

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public unsafe static ResMember define<T>(MemberInfo member, ReadOnlySpan<T> src)
            where T : unmanaged
                => new ResMember(member, MemRef.memref(cast<T,byte>(src)));

        [MethodImpl(Inline), Op]
        public unsafe static ReadOnlySpan<char> segment(in ResIdentity<char> res, int i0, int i1)
            => As.segment((char*)res.Location, i0, i1);        

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> segment(in ResIdentity<byte> res, int i0, int i1)
            => Addresses.read<byte>(res.Location, (i1 - i0 + 1));
    }
}