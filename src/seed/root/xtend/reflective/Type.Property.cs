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
        public static Option<PropertyInfo> Property(this Type src, string name)
            => src.GetProperties(BF_Declared).Where(p => p.Name == name).FirstOrDefault();
    }
}