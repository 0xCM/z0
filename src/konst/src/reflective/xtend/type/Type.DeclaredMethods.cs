//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    using static ReflectionFlags;
    
    partial class XTend
    {
        /// <summary>
        /// Selects all methods declared by a type; however, property getters/setters and other 
        /// compiler-generated artifacts are excluded
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static MethodInfo[] DeclaredMethods(this Type src)
            => src.GetMethods(BF_Declared);

        /// <summary>
        /// Selects the public/non-public static/instance methods declared by a type that have a specific name
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static MethodInfo[] DeclaredMethods(this Type src, string name)
            => src.DeclaredMethods().Where(m => m.Name == name);
    }
}