//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static Option;

    partial class XTend
    {
        /// <summary>
        /// Attempts to retrieve the value of an instance or static property
        /// </summary>
        /// <param name="p">The property</param>
        /// <param name="instance">The object instance, if applicable</param>
        public static Option<object> Read(this PropertyInfo p, object instance = null)
            => Try(() => p.GetValue(instance));
       
        public static Option<T> Read<T>(this PropertyInfo p, object src)
            => Try(() => (T)p.GetValue(src));
    }
}