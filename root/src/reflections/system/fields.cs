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

    using static Root;
    
    partial class RootReflections
    {
        /// <summary>
        /// Attempts to retrieve the value of an instance or static field
        /// </summary>
        /// <param name="field">The field</param>
        /// <param name="instance">The object instance, if applicable</param>
        public static Option<object> Value(this FieldInfo field, object instance = null)
            => Root.Try(() => field.GetValue(instance));

        public static IEnumerable<object> Values(this IEnumerable<FieldInfo> src, object o = null)
            => src.Select(x => x.GetValue(o));

        public static IEnumerable<T> Values<T>(this IEnumerable<FieldInfo> src, object o = null)
            => src.Select(x => x.GetValue(o)).Where(x => x is T).Cast<T>();

    }

}