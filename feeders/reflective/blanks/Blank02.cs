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
    using System.Runtime.CompilerServices;
    using System.Linq.Expressions;

    using static ReflectionFlags;
    
    partial class Reflective
    {

        public static IEnumerable<object> Values(this IEnumerable<FieldInfo> src, object o = null)
            => src.Select(x => x.GetValue(o));

        public static IEnumerable<T> Values<T>(this IEnumerable<FieldInfo> src, object o = null)
            => src.Select(x => x.GetValue(o)).Where(x => x is T).Cast<T>();

    }
}