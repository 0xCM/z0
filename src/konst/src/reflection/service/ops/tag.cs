//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    partial struct ClrReflexSvc
    {
        [MethodImpl(Inline)]
        public static A tag<T,A>(T member, A a = default)
            where T : MemberInfo
            where A : Attribute
                => member.GetCustomAttribute<A>();
    }
}