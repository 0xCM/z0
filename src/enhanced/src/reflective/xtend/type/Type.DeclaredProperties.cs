//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;

    using static ReflectionFlags;
    
    partial class XTend
    {
        /// <summary>
        /// Retrieves all properties declared by a by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static PropertyInfo[] DeclaredProperties(this Type src)
            => src.GetProperties(BF_Declared);

        /// <summary>
        /// Retrieves the public and non-public static properties declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static PropertyInfo[] DeclaredStaticProperties(this Type t)
            => t.GetProperties(BF_Static);
    }
}