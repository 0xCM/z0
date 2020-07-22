//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static ReflectionFlags;
    
    partial class XTend
    {
        /// <summary>
        /// Retrieves the public and non-public static methods declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static MethodInfo[] DeclaredStaticMethods(this Type src)
            => src.GetMethods(BF_DeclaredStatic);
    }
}