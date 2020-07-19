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
        public static EventInfo[] Events(this Type src)
            => src.GetEvents(BF_World);
    }
}