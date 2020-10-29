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

    partial class XReflex
    {
        [MethodImpl(Inline), Op]
        public static DataMember[] DataMembers(this Type src)
            => CachedReflections.Lookup(src);
    }
}