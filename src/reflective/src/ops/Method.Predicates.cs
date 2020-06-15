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

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Returns true if the method accepts generic parameters, false otherwise
        /// </summary>
        /// <param name="m">The method to examine</param>
        [MethodImpl(Inline), Op]
        public static bool IsOpenGeneric(this MethodInfo m)
            => m.ContainsGenericParameters;

        /// <summary>
        /// Returns true if the method has a specified count of open generic parameters, false otherwise
        /// </summary>
        /// <param name="m">The method to examine</param>
        [MethodImpl(Inline), Op]
        public static bool IsOpenGeneric(this MethodInfo m, int count)
            => m.ContainsGenericParameters && m.GenericParameters().Count() == count;

        /// <summary>
        /// Returns true if the method has unspecified generic parameters, false otherwise
        /// </summary>
        /// <param name="src">The method to examine</param>
        [MethodImpl(Inline), Op]
        public static bool IsClosedGeneric(this MethodInfo src)
            => src.IsConstructedGenericMethod;

        /// <summary>
        /// Returns true if the method has unspecified generic parameters, false otherwise
        /// </summary>
        /// <param name="src">The method to examine</param>
        [MethodImpl(Inline), Op]
        public static bool IsNonGeneric(this MethodInfo src)
            => !src.IsGenericMethod && !src.IsConstructedGenericMethod;
    
        /// <summary>
        /// Determines whether a method has a void return and, consequently, cannot be a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        [MethodImpl(Inline), Op]
        public static bool HasVoidReturn(this MethodInfo m)
            => m.ReturnType == typeof(void);

        /// <summary>
        /// Dtermines whether a method has a void return
        /// </summary>
        /// <param name="m">The method to examine</param>
        [MethodImpl(Inline), Op]
        public static bool IsAction(this MethodInfo m)
            => m.HasVoidReturn();

        /// <summary>
        /// Determines whether a method is a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        [MethodImpl(Inline), Op]
        public static bool IsFunction(this MethodInfo m)
            => ! m.HasVoidReturn();

        /// <summary>
        /// Determines the number of parameters defined by a method
        /// </summary>
        /// <param name="m">The method to examine</param>
        [MethodImpl(Inline), Op]
        public static int ArityValue(this MethodInfo m)
            => m.GetParameters().Length;

        /// <summary>
        /// Determines whether a method has a speicied arity
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="arity">The arity to match</param>
        [MethodImpl(Inline), Op]
        public static bool HasArityValue(this MethodInfo m, int arity)
            => m.ArityValue() == arity;

        /// <summary>
        /// Determines whether the method is an implicit conversion operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        [MethodImpl(Inline), Op]
        public static bool IsImplicitConverter(this MethodInfo m)
            => string.Equals(m.Name, "op_Implicit", StringComparison.InvariantCultureIgnoreCase);

        /// <summary>
        /// Determines whether the method is an explicit conversion operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        [MethodImpl(Inline), Op]
        public static bool IsExplicitConverter(this MethodInfo m)
            => string.Equals(m.Name, "op_Explicit", StringComparison.InvariantCultureIgnoreCase);

        /// <summary>
        /// Determines whether a method is an implict or explicit conversion operation
        /// </summary>
        /// <param name="m">The method to examine</param>
        [MethodImpl(Inline), Op]
        public static bool IsConversionOperator(this MethodInfo m)
            => m.IsExplicitConverter() || m.IsImplicitConverter();

        /// <summary>
        /// Returns a method's parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        [MethodImpl(Inline), Op]
        public static Type[] ParameterTypes(this MethodInfo m)
            => m.GetParameters().Select(p => p.ParameterType);

        /// <summary>
        /// Returns a method's parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        [MethodImpl(Inline), Op]
        public static Type[] EffectiveParameterTypes(this MethodInfo m)
            => m.ParameterTypes().Select(t => t.EffectiveType());

        /// <summary>
        /// Returns a method's parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        [MethodImpl(Inline), Op]
        public static Type[] ParameterTypes(this MethodInfo m, bool effective)
            => effective ? m.EffectiveParameterTypes() : m.ParameterTypes();

        /// <summary>
        /// Determines the type of an index-identified parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="index">The parameter index</param>
        [MethodImpl(Inline), Op]
        public static Type ParameterType(this MethodInfo m, int index)
            => m.ArityValue() >= index + 1 ? m.GetParameters()[index].ParameterType : typeof(void);
    }
}