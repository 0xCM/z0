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
        /// Selects the instance properties from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<PropertyInfo> Instance(this IEnumerable<PropertyInfo> src)    
            =>  from p in src
                let m = p.GetGetMethod() ?? p.GetSetMethod()                
                where m != null && !m.IsStatic
                select p;            

        /// <summary>
        /// Selects properaties from a source stream to which a parametrically-identified attribute is attached
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="A">The attribute type</typeparam>
        public static IEnumerable<PropertyInfo> Tagged<A>(this IEnumerable<PropertyInfo> src)
            where A : Attribute
                => src.Where(x => x.Tagged<A>());

        /// <summary>
        /// Selects the static properties from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<PropertyInfo> Static(this IEnumerable<PropertyInfo> src)
            => src.Where(p => p.IsStatic());

        /// <summary>
        /// Selects the properties from a stream that have public accessesors
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<PropertyInfo> WithPublicRead(this IEnumerable<PropertyInfo> src)
            => src.Where(p => p.CanRead && p.GetGetMethod().IsPublic);

        /// <summary>
        /// Selects the properties from a stream that have public manipulators
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<PropertyInfo> WithPublicWrite(this IEnumerable<PropertyInfo> src)
            => src.Where(p => p.CanWrite && p.GetGetMethod().IsPublic);

        /// <summary>
        /// Selects the properties from a stream of a specified type
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<PropertyInfo> WithPropertyType(this IEnumerable<PropertyInfo> src, Type t)
            => src.Where(p => p.PropertyType == t);

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
        /// Selects the property type from each source property
        /// </summary>
        /// <param name="src">The source properties</param>
        public static IEnumerable<Type> PropertyTypes(this IEnumerable<PropertyInfo> src)
            => src.Select(x => x.PropertyType);
    }
}