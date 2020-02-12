//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
 
    using static ReflectionFlags;

    partial class RootReflections
    {
        public static bool IsStatic(this PropertyInfo p)
            => p.GetGetMethod()?.IsStatic == true 
            || p.GetSetMethod().IsStatic == true;

    }
}