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
        /// <summary>
        /// Attempts to retrieve the value of an instance or static property
        /// </summary>
        /// <param name="prop">The property</param>
        /// <param name="instance">The object instance, if applicable</param>
        public static Option<object> TryGetValue(this PropertyInfo prop, object instance = null)
            => Root.Try(() => prop.GetValue(instance));

    }
}