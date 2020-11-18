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
        public static ClrMemberIdentity identity(FieldInfo src)
            => new ClrMemberIdentity(src);

        [MethodImpl(Inline), Op]
        public static ClrMemberIdentity identity(MethodInfo src)
            => new ClrMemberIdentity(src);

        [MethodImpl(Inline), Op]
        public static ClrMemberIdentity identity(PropertyInfo src)
            => new ClrMemberIdentity(src);

        [MethodImpl(Inline), Op]
        public static ClrMemberIdentity identity(EventInfo src)
            => new ClrMemberIdentity(src);
    }
}