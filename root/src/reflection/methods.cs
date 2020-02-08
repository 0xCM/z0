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
    using System.Runtime.Intrinsics;
    using System.ComponentModel;
    using System.Collections.Concurrent;

    using static RootShare;
    
    partial class RootReflections
    {
        /// <summary>
        /// Determines the number of parameters defined by a method
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static int Arity(this MethodInfo m)
            => m.GetParameters().Length;

        /// <summary>
        /// Determines whether a method has a speicied arity
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="arity">The arity to match</param>
        public static bool HasArity(this MethodInfo m, int arity)
            => m.Arity() == arity;

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
        /// Returns a method's parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<Type> ParameterTypes(this MethodInfo m)
            => m.GetParameters().Select(p => p.ParameterType);

        /// <summary>
        /// Determines the type of an index-identified parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="index">The parameter index</param>
        public static Type ParameterType(this MethodInfo m, int index)
            => m.Arity() >= index + 1 ? m.GetParameters()[index].ParameterType : typeof(void);

        /// <summary>
        /// Determines whether the method is an implicit conversion operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsImplicitConverter(this MethodInfo m)
            => string.Equals(m.Name, "op_Implicit", IgnoreCase);

        /// <summary>
        /// Determines whether the method is an explicit conversion operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsExplicitConverter(this MethodInfo m)
            => string.Equals(m.Name, "op_Explicit", IgnoreCase);

        /// <summary>
        /// Determines whether a method is an implict or explicit conversion operation
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsConversionOp(this MethodInfo m)
            => m.IsExplicitConverter() || m.IsImplicitConverter();

        /// <summary>
        /// Selects the conversion operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> ConversionOps(this IEnumerable<MethodInfo> src)
            => src.Where(IsConversionOp);

        /// <summary>
        /// Reomoves any conversion operations from the stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> WithoutConversionOps(this IEnumerable<MethodInfo> src)
            => src.Where(m => !m.IsConversionOp());

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
        /// Determines whether a method is an action
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsAction(this MethodInfo m)
            => m.ReturnType == typeof(void);

        /// <summary>
        /// Determines whether a method is a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsFunction(this MethodInfo m)
            => m.ReturnType != typeof(void);

        /// <summary>
        /// Determines whether a method is an emitter, i.e. a method that returns a value but accepts no input
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsEmitter(this MethodInfo m)
            => m.IsFunction() && m.HasArity(0);


    }

}