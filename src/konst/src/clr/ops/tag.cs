//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ClrQuery
    {
        [MethodImpl(Inline)]
        public static A tag<T,A>(T member, A a = default)
            where T : MemberInfo
            where A : Attribute
                => member.GetCustomAttribute<A>();
    }
}