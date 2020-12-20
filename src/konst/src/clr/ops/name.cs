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
        public static MemberName name(FieldInfo src)
            => new MemberName(src.Name);

        [MethodImpl(Inline), Op]
        public static MemberName name(PropertyInfo src)
            => new MemberName(src.Name);

        [MethodImpl(Inline), Op]
        public static MemberName name(MethodInfo src)
            => new MemberName(src.Name);

        [MethodImpl(Inline), Op]
        public static MemberName name(EventInfo src)
            => new MemberName(src.Name);

        [MethodImpl(Inline), Op]
        public static TypeName name(Type src)
            => new TypeName(src.AssemblyQualifiedName);
    }
}