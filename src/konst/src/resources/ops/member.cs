//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;
    using static memory;

    partial struct Resources
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public unsafe static ResMember member<T>(MemberInfo member, ReadOnlySpan<T> src)
            => new ResMember(member, memseg(recover<T,byte>(src)));

        [MethodImpl(Inline), Op]
        public unsafe static ResMember member(FieldInfo field, uint size)
            => new ResMember(field, memseg(field.FieldHandle.Value, size));

        [MethodImpl(Inline), Op]
        public unsafe static ResMember member(W8 w, FieldInfo field)
            => new ResMember(field, memseg(field.FieldHandle.Value, 1));

        [MethodImpl(Inline), Op]
        public unsafe static ResMember member(W16 w, FieldInfo field)
            => new ResMember(field, memseg(field.FieldHandle.Value, 2));

        [MethodImpl(Inline), Op]
        public unsafe static ResMember member(W32 w, FieldInfo field)
            => new ResMember(field, memseg(field.FieldHandle.Value, 4));

        [MethodImpl(Inline), Op]
        public unsafe static ResMember member(W64 w, FieldInfo field)
            => new ResMember(field, memseg(field.FieldHandle.Value, 8));
    }
}