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
    using System.Linq.Expressions;

    using static ReflectionFlags;
    
    partial class XTend
    {
        /// <summary>
        /// Selects all methods available through the type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static MethodInfo[] Methods(this Type src)
            => src.GetMethods(BF_All);

        /// <summary>
        /// Selects the methods available through the type that were not declared by the type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> UndeclaredMethods(this Type src)
            => src.Methods().Except(src.DeclaredMethods());

        /// <summary>
        /// Selects the public/non-public static/instance methods declared by a type that have a specific name
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static MethodInfo[] DeclaredMethods(this Type src, string name)
            => src.DeclaredMethods().Where(m => m.Name == name);
 
        /// <summary>
        /// Selects the public/non-public static/instance methods declared by a stream of types
        /// </summary>
        /// <param name="src">The types to examine</param>
        public static IEnumerable<MethodInfo> DeclaredMethods(this IEnumerable<Type> src)
            => src.Select(x => x.DeclaredMethods()).SelectMany(x => x);
 
        /// <summary>
        /// Gets the static methods defined on a specified type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static MethodInfo[] StaticMethods(this Type src)
            => src.Methods().Where(m => m.IsStatic);

        /// <summary>
        /// Retrieves the public and non-public static methods declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static MethodInfo[] DeclaredStaticMethods(this Type src)
            => src.GetMethods(BF_DeclaredStatic);

        /// <summary>
        /// Retrieves the public and non-public static methods declared by a type that have a specific name
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">Whether to selct static or instance </param>
        public static MethodInfo[] DeclaredStaticMethods(this Type t, string name)
            => t.DeclaredStaticMethods().Where(m => m.Name == name);

        /// <summary>
        /// Retrieves the public and non-public instance methods declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">Whether to selct static or instance </param>
        public static MethodInfo[] DeclaredInstanceMethods(this Type src, bool nonspecial = true)
            => src.GetMethods(BF_DeclaredInstance);

    }
}