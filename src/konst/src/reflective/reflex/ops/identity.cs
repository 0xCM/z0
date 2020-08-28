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
        public static MemberIdentity identity(FieldInfo src)
            => new MemberIdentity(src);

        [MethodImpl(Inline), Op]
        public static MemberIdentity identity(PropertyInfo src)
            => new MemberIdentity(src);

        [MethodImpl(Inline), Op]
        public static MemberIdentity identity(MethodInfo src)
            => new MemberIdentity(src);
    }
}