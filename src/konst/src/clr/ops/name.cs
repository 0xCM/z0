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

    partial struct ClrQuery
    {
        [MethodImpl(Inline), Op]
        public static ClrMemberName name(FieldInfo src)
            => new ClrMemberName(src.Name);

        [MethodImpl(Inline), Op]
        public static ClrMemberName name(PropertyInfo src)
            => new ClrMemberName(src.Name);

        [MethodImpl(Inline), Op]
        public static ClrMemberName name(MethodInfo src)
            => new ClrMemberName(src.Name);

        [MethodImpl(Inline), Op]
        public static ClrMemberName name(EventInfo src)
            => new ClrMemberName(src.Name);

        [MethodImpl(Inline), Op]
        public static ClrTypeName name(Type src)
            => new ClrTypeName(src.AssemblyQualifiedName);
    }
}