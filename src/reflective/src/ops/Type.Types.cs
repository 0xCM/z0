//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    partial class XTend
    {
        /// <summary>
        /// Selects the concrete types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static Type[] Concrete(this Type[] src)
            => src.Where(t => t.IsConcrete());

        /// <summary>
        /// Returns all source types which ar interfaces
        /// </summary>
        /// <param name="src">The source types</param>
        public static Type[] Interfaces(this Type[] src)
            => src.Where(t => t.IsInterface);

        /// <summary>
        /// Returns all source types which are classes
        /// </summary>
        /// <param name="src">The source types</param>
        public static Type[] Classes(this Type[] src)
            => src.Where(t => t.IsClass);

        /// <summary>
        /// Returns all source types which are structs
        /// </summary>
        /// <param name="src">The source types</param>
        public static Type[] Structs(this Type[] src)
            => src.Where(t => t.IsStruct());

        /// <summary>
        /// Returns all source types which are delegates
        /// </summary>
        /// <param name="src">The source types</param>
        public static Type[] Delegates(this Type[] src)
            => src.Where(t => t.IsDelegate());

        /// <summary>
        /// Returns all source types which are enums
        /// </summary>
        /// <param name="src">The source types</param>
        public static IEnumerable<Type> Enums(this IEnumerable<Type> src)
            => src.Where(t => t.IsEnum);

        /// <summary>
        /// Selects the types from a specified namespace
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<Type> InNamespace(this IEnumerable<Type> src, string match)
            => src.Where(t => t.Namespace == match);

        /// <summary>
        /// Selects the abstract types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static Type[] Abstract(this Type[] src)
            => src.Where(t => t.IsAbstract);

        /// <summary>
        /// Selects the nested types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static Type[] Nested(this Type[] src)
            => src.Where(t => t.IsNested);

        /// <summary>
        /// Selects the static types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static Type[] Static(this Type[] src)
            => src.Where(p => p.IsStatic());

        /// <summary>
        /// Selects the types from a stream that implement a specific interface
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The interface type</typeparam>
        public static IEnumerable<Type> Realize<T>(this IEnumerable<Type> src)
            => src.Where(t => t.Interfaces().Contains(typeof(T)));

        /// <summary>
        /// Selects the public types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<Type> Public(this IEnumerable<Type> src)
            => src.Where(t => t.IsPublic);

        /// <summary>
        /// Selects the non-public types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<Type> NonPublic(this IEnumerable<Type> src)
            => src.Where(t => !t.IsPublic);
    }
}