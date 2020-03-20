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
        public static Option<PropertyInfo> Property(this Type src, string name)
            => src.DeclaredProperties().Where(p => p.Name == name).FirstOrDefault();

        /// <summary>
        /// Attempts to retrieve the value of an instance or static property
        /// </summary>
        /// <param name="p">The property</param>
        /// <param name="instance">The object instance, if applicable</param>
        public static Option<object> TryGetValue(this PropertyInfo p, object instance = null)
            => Root.Try(() => p.GetValue(instance));

        public static Option<object> Read(this PropertyInfo p, object src)
            => Root.Try(() => p.GetValue(src));
        
        public static Option<T> Read<T>(this PropertyInfo p, object src)
            => Root.Try(() => (T)p.GetValue(src));

        public static Option<object> Write(this PropertyInfo p, object src, object dst)
        {
            try
            {
                p.SetValue(dst,src);
                return dst;
            }
            catch(Exception e)
            {
                term.error(e);
                return default;
            }
        }        
    }
}