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

    partial struct ClrQuerySvc
    {
        [MethodImpl(Inline)]
        public static bool tagged<T,A>(T member, A a = default)
            where T : MemberInfo
            where A : Attribute
                => Attribute.IsDefined(member, typeof(A));
    }
}