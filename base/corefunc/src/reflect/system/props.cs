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
    
    using static zfunc;
    using static ReflectionFlags;

    partial class Reflections
    {        

        /// <summary>
        /// Determines whether a property is an indexer
        /// </summary>
        /// <param name="p">The property to examine</param>
        public static bool IsIndexer(this PropertyInfo p)
            => p.GetIndexParameters().Length > 0;

        /// <summary>
        /// Determines whether the property has a public or non-public setter
        /// </summary>
        /// <param name="p">The property to examine</param>
        public static bool HasSetter(this PropertyInfo p)
            => p.Setter().Exists;

        /// <summary>
        /// Determines whether the property has a public or non-public getter
        /// </summary>
        /// <param name="p">The property to examine</param>
        public static bool HasGetter(this PropertyInfo p)
            => p.Getter().Exists;

        /// <summary>
        /// Selects the static properties from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<PropertyInfo> Static(this IEnumerable<PropertyInfo> src)
            => src.Where(p => p.IsStatic());

        /// <summary>
        /// Selects the instance properties from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<PropertyInfo> Instance(this IEnumerable<PropertyInfo> src)
            => src.Where(x=> (x.HasSetter() && !x.IsStatic()) || (x.HasGetter() && !x.IsStatic()));

        /// <summary>
        /// Selects the properties with set methods from the stream
        /// </summary>
        /// <param name="src">The properties to examine</param>
        public static IEnumerable<PropertyInfo> WithSet(this IEnumerable<PropertyInfo> src)
            => src.Where(p => p.GetSetMethod() != null);

        /// <summary>
        /// Selects the properties with get methods from the stream
        /// </summary>
        /// <param name="src">The properties to examine</param>
        public static IEnumerable<PropertyInfo> WithGet(this IEnumerable<PropertyInfo> src)
            => src.Where(p => p.GetGetMethod() != null);

        /// <summary>
        /// Selects the properties with both get/set methods from the stream
        /// </summary>
        /// <param name="src">The properties to examine</param>
        public static IEnumerable<PropertyInfo> WithGetAndSet(this IEnumerable<PropertyInfo> src)
            => src.Where(p => p.GetGetMethod() != null && p.GetSetMethod() != null);

        /// <summary>
        /// Attempts to retrieve the value of an instance or static property
        /// </summary>
        /// <param name="prop">The property</param>
        /// <param name="instance">The object instance, if applicable</param>
        public static Option<object> TryGetValue(this PropertyInfo prop, object instance = null)
            => Try(() => prop.GetValue(instance));

    }

}