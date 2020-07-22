//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static ReflectionFlags;
    using static Konst;

    partial class XTend
    {
        public static DataMember[] DataMembers(this Type src)
            => DataMemberCache.Lookup(src);
    }
}