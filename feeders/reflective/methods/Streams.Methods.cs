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
        /// Returns the methods from the source type per the binding flags
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <param name="flags">The reflection query flags</param>
        public static IEnumerable<MethodInfo> FlaggedMethods(this Type src, BindingFlags flags)
            => src.GetMethods(flags);

        /// <summary>
        /// Selects all methods declared by a type; however, property getters/setters and other 
        /// compiler-generated artifacts are excluded
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> DeclaredMethods(this Type src, bool nonspecial = true)
            => nonspecial ? src.NonSpecialMethods(BF_Declared) : src.GetMethods(BF_Declared);

        /// <summary>
        /// Returns the methods from the source type per the binding flags, exluding those with special names
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <param name="flags">The reflection query flags</param>
        public static IEnumerable<MethodInfo> NonSpecialMethods(this Type src, BindingFlags flags)
            => src.FlaggedMethods(flags).Where(IsNonSpecial);

        /// <summary>
        /// Returns the methods from the source type per the binding flags; however, only those with special names are included
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <param name="flags">The reflection query flags</param>
        public static IEnumerable<MethodInfo> SpecialMethods(this Type src, BindingFlags flags)
            => src.FlaggedMethods(flags).Where(IsNonSpecial);


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
            => src.Where(m => m.IsConversionOperator());

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
            => src.Where(m => m.HasArityValue(arity));

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
    }
}