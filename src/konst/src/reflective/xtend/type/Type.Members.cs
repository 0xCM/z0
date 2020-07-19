//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static ReflectionFlags;

    partial class XTend
    {
        public static MemberInfo[] Members(this Type src)
            => src.GetMembers(BF_World);
        
        public static MemberInfo[] Members(this Type src, string name)
            => src.Members().Where(x => x.Name == name);
    }
}