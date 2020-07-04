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
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ResIdentity<T> identify<T>(in asci32 name, ulong location, int length)
            where T : unmanaged
                => new ResIdentity<T>(name, memref(location, length));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ReadOnlySpan<T> resource<T>(in ResMember member, int i0, int i1)
            where T : unmanaged
                => As.segment(member.Address.Pointer<T>(), i0, i1); 

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public unsafe static ResMember define<T>(MemberInfo member, ReadOnlySpan<T> src)
            where T : unmanaged
                => new ResMember(member, MemRef.from(cast<T,byte>(src)));

        [MethodImpl(Inline), Op]
        public unsafe static ReadOnlySpan<char> segment(in ResIdentity<char> res, int i0, int i1)
            => As.segment((char*)res.Address, i0, i1);        

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> segment(in ResIdentity<byte> res, int i0, int i1)
            => Addressable.view<byte>(res.Address, (i1 - i0 + 1));
    }
}