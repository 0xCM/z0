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
    
    partial class XTend
    {
        /// <summary>
        /// Gets the static methods defined on a specified type
        /// </summary>
        /// <param name="this">The type to examine</param>
        public static PropertyInfo[] StaticProperties(this Type src)
            => src.GetProperties(BF_AllStatic);

        /// <summary>
        /// Gets the static methods defined on a specified type
        /// </summary>
        /// <param name="this">The type to examine</param>
        /// <param name="get">Specifies whether to require selected properties to provide get accessors</param>
        public static PropertyInfo[] StaticProperties(this Type src, bool get)
            => get ? src.StaticProperties().Where(p => p.HasGetter()) : src.StaticProperties();

        /// <summary>
        /// Gets the static properties defined on a specified type that provided get/set accessors/manipulators 
        /// per the provided specifiation
        /// </summary>
        /// <param name="this">The type to examine</param>
        /// <param name="get">Specifies whether to include or exclude properties with get accessors</param>
        /// <param name="set">Specifies whether to include or exclude properties with set accessors</param>
        public static PropertyInfo[] StaticProperties(this Type src, bool get, bool set)
        {
            if(get && set)
                return src.StaticProperties().Where(p => p.HasGetter() && p.HasSetter());
            else if(get && !set)
                return src.StaticProperties().Where(p => p.HasGetter() && !p.HasSetter());
            else if(!get && set)
                return src.StaticProperties().Where(p => !p.HasGetter() && p.HasSetter());
            else
                return src.StaticProperties();
        }
    }
}