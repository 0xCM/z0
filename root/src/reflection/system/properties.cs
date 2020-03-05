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
        /// Retrieves a public or non-public setter for a property if it exists
        /// </summary>
        /// <param name="p">The property to examine</param>
        public static Option<MethodInfo> Setter(this PropertyInfo p)
            => p.GetSetMethod() ?? p.GetSetMethod(true);

        /// <summary>
        /// Retrieves a public or non-public getter for a property if it exists
        /// </summary>
        /// <param name="p">The property to examine</param>
        public static Option<MethodInfo> Getter(this PropertyInfo p)
            => p.GetGetMethod() ?? p.GetGetMethod(true);

        /// <summary>
        /// Selects the instance properties from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<PropertyInfo> Instance(this IEnumerable<PropertyInfo> src)    
            =>  from p in src
                let m = p.GetGetMethod() ?? p.GetSetMethod()                
                where m != null && !m.IsStatic
                select p;            

        /// <summary>
        /// Attempts to retrieve the value of an instance or static property
        /// </summary>
        /// <param name="prop">The property</param>
        /// <param name="instance">The object instance, if applicable</param>
        public static Option<object> TryGetValue(this PropertyInfo prop, object instance = null)
            => Root.Try(() => prop.GetValue(instance));

    }
}