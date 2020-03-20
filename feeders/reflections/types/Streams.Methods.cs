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
    
    partial class Reflections
    {

        /// <summary>
        /// Selects the methods available through the type, including those that were inherited; 
        /// however, property getters/setters and other compiler-generated artifacts may be excluded 
        /// via the nonspecial option
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> Methods(this Type src, bool nonspecial = true)
            =>  nonspecial ? src.NonSpecialMethods(BF_All) : src.GetMethods(BF_All);

        /// <summary>
        /// Selects the methods available through the type that were not declared by the type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> UndeclaredMethods(this Type src, bool nonspecial = true)
            => src.Methods(nonspecial).Except(src.DeclaredMethods(nonspecial));

        /// <summary>
        /// Selects the public/non-public static/instance methods declared by a type that have a specific name
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> DeclaredMethods(this Type src, string name, bool nonspecial = true)
            => src.DeclaredMethods(nonspecial).Where(m => m.Name == name);
 
        /// <summary>
        /// Selects the public/non-public static/instance methods declared by a stream of types
        /// </summary>
        /// <param name="src">The types to examine</param>
        public static IEnumerable<MethodInfo> DeclaredMethods(this IEnumerable<Type> src, bool nonspecial = true)
            => src.Select(x => x.DeclaredMethods(nonspecial)).SelectMany(x => x);
 
         /// <summary>
        /// Gets the static methods defined on a specified type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> StaticMethods(this Type src, bool nonspecial = true)
            => src.Methods(nonspecial).Where(m => m.IsStatic);

        /// <summary>
        /// Retrieves the public and non-public static methods declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<MethodInfo> DeclaredStaticMethods(this Type t, bool nonspecial = true)
            => nonspecial ?  t.NonSpecialMethods(BF_DeclaredStatic) : t.FlaggedMethods(BF_DeclaredStatic);

        /// <summary>
        /// Retrieves the public and non-public static methods declared by a type that have a specific name
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">Whether to selct static or instance </param>
        public static IEnumerable<MethodInfo> DeclaredStaticMethods(this Type t, string name, bool nonspecial = true)
            => t.DeclaredStaticMethods(nonspecial).Where(m => m.Name == name);

        /// <summary>
        /// Retrieves the public and non-public instance methods declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">Whether to selct static or instance </param>
        public static IEnumerable<MethodInfo> DeclaredInstanceMethods(this Type t, bool nonspecial = true)
            => nonspecial ? t.NonSpecialMethods(BF_DeclaredInstance) : t.FlaggedMethods(BF_DeclaredInstance);
    }
}