//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Reflex
    {
        [MethodImpl(Inline), Op]
        public static ClrMemberIdentity identity(FieldInfo src)
            => new ClrMemberIdentity(src);

        [MethodImpl(Inline), Op]
        public static ClrMemberIdentity identity(PropertyInfo src)
            => new ClrMemberIdentity(src);

        [MethodImpl(Inline), Op]
        public static ClrMemberIdentity identity(MethodInfo src)
            => new ClrMemberIdentity(src);
    }
}