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
    
    using static zfunc;

    partial class Reflections
    {        
        /// <summary>
        /// Selects the instance properties from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<PropertyInfo> Instance(this IEnumerable<PropertyInfo> src)
            => src.Where(x=> (x.HasSetter() && !x.IsStatic()) || (x.HasGetter() && !x.IsStatic()));

        /// <summary>
        /// Attempts to retrieve the value of an instance or static property
        /// </summary>
        /// <param name="prop">The property</param>
        /// <param name="instance">The object instance, if applicable</param>
        public static Option<object> TryGetValue(this PropertyInfo prop, object instance = null)
            => Root.Try(() => prop.GetValue(instance));
    }
}