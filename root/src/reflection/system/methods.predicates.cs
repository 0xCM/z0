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
        /// Returns true if the method has unspecified generic parameters, false otherwise
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsOpenGeneric(this MethodInfo m)
            => m.ContainsGenericParameters;

        /// <summary>
        /// Returns true if the method has unspecified generic parameters, false otherwise
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static bool IsClosedGeneric(this MethodInfo src)
            => src.IsConstructedGenericMethod;

        /// <summary>
        /// Returns true if the method has unspecified generic parameters, false otherwise
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static bool IsNonGeneric(this MethodInfo src)
            => !src.IsGenericMethod && !src.IsConstructedGenericMethod;
    
 
        /// <summary>
        /// Determines whether a method has a void return and, consequently, cannot be a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool HasVoidReturn(this MethodInfo m)
            => m.ReturnType == typeof(void);


        /// <summary>
        /// Determines whether a method is an homogneous function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsHomogenousFunction(this MethodInfo m)
            => m.IsHomogenous() && m.IsFunction();
 
        /// <summary>
        /// Determines whether a method defines a unary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryFunction(this MethodInfo m)
            => m.IsFunction() && m.HasArity(1);

        /// <summary>
        /// Determines whether a method is a unary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryOperator(this MethodInfo m)
            => m.IsHomogenous() && m.IsUnaryFunction();
 
        /// <summary>
        /// Determines whether a method is a binary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryOperator(this MethodInfo m)
            => m.IsHomogenous() && m.IsBinaryFunction();

        /// <summary>
        /// Determines whether a method defines a binary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryFunction(this MethodInfo m)
            => m.IsFunction() && m.HasArity(2);

        /// <summary>
        /// Determines whether a method defines a binary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryFunction(this MethodInfo m)
            => m.IsFunction() && m.HasArity(3);

        /// <summary>
        /// Determines whether a method is a ternary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryOperator(this MethodInfo m)
            => m.IsHomogenous() && m.IsTernaryFunction();

    }
}