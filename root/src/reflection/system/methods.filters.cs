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

    using static Root;
 
    partial class RootReflections
    {
        /// <summary>
        /// Selects the methods that are adorned with parametrically-identified attribute
        /// </summary>
        /// <param name="src">The methods to examine</param>
        /// <typeparam name="A">The attribute type</typeparam>
        public static IEnumerable<MethodInfo> Tagged<A>(this IEnumerable<MethodInfo> src)
            where A : Attribute
                => src.Where(m => m.Tagged<A>());      

        /// <summary>
        /// Selects the conversion operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> ConversionOperators(this IEnumerable<MethodInfo> src)
            => src.Where(IsConversionOperator);

        /// <summary>
        /// Reomoves any conversion operations from the stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> WithoutConversionOperators(this IEnumerable<MethodInfo> src)
            => src.Where(m => !m.IsConversionOperator());

        /// <summary>
        /// Selects the abstract methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Abstract(this IEnumerable<MethodInfo> src)
            => src.Where(t => t.IsAbstract);

        /// <summary>
        /// Selects the static methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Static(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsStatic);

        /// <summary>
        /// Selects the instance methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Instance(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.IsStatic);

        /// <summary>
        /// Selects the public methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Public(this IEnumerable<MethodInfo> src)
            => src.Where(t => t.IsPublic);

        /// <summary>
        /// Selects functions from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> WithArity(this IEnumerable<MethodInfo> src, int arity)
            => src.Where(m => m.HasArity(arity));

        /// <summary>
        ///  Selects methods from a stream that declare a parameter that has a specifid type
        /// </summary>
        /// <param name="src">The methods to examine</param>
        /// <param name="t">The parameter type to match</param>
        public static IEnumerable<MethodInfo> WithParameterType(this IEnumerable<MethodInfo> src, Type t)
            => src.Where(m => m.GetParameters().Any(p => p.ParameterType == t));

        /// <summary>
        ///  Selects methods from a stream that have specified parameter types
        /// </summary>
        /// <param name="src">The methods to examine</param>
        /// <param name="t">The parameter type to match</param>
        public static IEnumerable<MethodInfo> WithParameterTypes(this IEnumerable<MethodInfo> src, params Type[] types)
            => from m in src
                where m.ParameterTypes(true).Intersect(types).Count() == types.Length
                select m;

        /// <summary>
        ///  Selects methods from a stream that have a specified parameter count
        /// </summary>
        /// <param name="src">The methods to examine</param>
        /// <param name="t">The parameter type to match</param>
        public static IEnumerable<MethodInfo> WithParameterCount(this IEnumerable<MethodInfo> src, int count)
            => from m in src
                where m.GetParameters().Length == count
                select m;

        /// <summary>
        /// Selects the non-public methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> NonPublic(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.IsPublic);

        /// <summary>
        /// Selects the methods from a stream that return a particular type of value
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Returns<T>(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.ReturnType == typeof(T));

        /// <summary>
        /// Selects methods from a stream that return a particular type of value
        /// </summary>
        /// <param name="src">The methods to examine</param>
        /// <param name="rt">The method return type</param>
        public static IEnumerable<MethodInfo> Returns(this IEnumerable<MethodInfo> src, Type rt)
            => src.Where(x => x.ReturnType == rt);

        /// <summary>
        /// Selects the concrete (not abstract) methods from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Concrete(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.IsAbstract);

        /// <summary>
        /// Selects the methods from a stream where the name is NOT special
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> NonSpecial(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.IsSpecialName && !t.Name.Contains('|') && !t.Name.Contains('<'));
    }
}