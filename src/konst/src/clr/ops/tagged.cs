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

    partial struct Clr
    {
        [MethodImpl(Inline)]
        public static bool tagged<T,A>(T member, A a = default)
            where T : MemberInfo
            where A : Attribute
                => Attribute.IsDefined(member, typeof(A));
    }
}