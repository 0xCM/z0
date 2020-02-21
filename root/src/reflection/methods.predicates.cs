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
        /// Determines whether a method is an action
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsAction(this MethodInfo m)
            => m.ReturnType == typeof(void);

        /// <summary>
        /// Returns true if all non-void input/output values are of the same type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsHomogenous(this MethodInfo m)
        {
            var inputs = m.ParameterTypes().ToHashSet();
            if(inputs.Count == 1)
                return inputs.Single() == m.ReturnType;
            else if(inputs.Count == 0)
                return m.ReturnType == typeof(void);
            else
                return false;
        }

        /// <summary>
        /// Determines whether a method is a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsFunction(this MethodInfo m)
            => m.ReturnType != typeof(void);
        
        /// <summary>
        /// Determines whether a method is a function with specified arity
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="arity">The arith to match</param>
        public static bool IsFunction(this MethodInfo m, int arity)
            => m.IsFunction() && m.HasArity(arity);

        /// <summary>
        /// Determines whether a method is an emitter, i.e. a method that returns a value but accepts no input
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsEmitter(this MethodInfo m)
            => m.IsFunction() && m.HasArity(0);

        /// <summary>
        /// Determines whether a method defines an operator over a (common) domain
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsOperator(this MethodInfo m)
            => m.IsFunction() && m.IsHomogenous() && m.Arity() >= 1;

        /// <summary>
        /// Determines whether a method defines an operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsOperator(this MethodInfo m, NumericKind k)
            => m.IsFunction() && m.IsHomogenous() && m.Arity() >= 1 && m.ReturnType.NumericKind() == k;

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
        /// Determines whether a method is a binary operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryOperator(this MethodInfo m, NumericKind k)
            => m.IsUnaryOperator() && m.ReturnType.NumericKind() == k;

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
        /// Determines whether a method is a binary operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryOperator(this MethodInfo m, NumericKind k)
            => m.IsBinaryOperator() && m.ReturnType.NumericKind() == k;

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

        /// <summary>
        /// Determines whether a method is a ternary operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryOperator(this MethodInfo m, NumericKind k)
            => m.IsBinaryOperator() && m.ReturnType.NumericKind() == k;

        /// <summary>
        /// Evaluated to true if the source method is a function returns a numeric value and any 
        /// operands are also numeric; otherwise, returns false
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsNumericFunction(this MethodInfo m)
            => m.IsFunction() 
            && m.ReturnType.NumericKind() != NumericKind.None 
            && m.ParameterTypes().All(t => t.NumericKind() != NumericKind.None);

        /// <summary>
        /// Determines whether a method defines a parameter that requires an 8-bit immediate immediate
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool AcceptsImmediate(this MethodInfo m)        
            => m.GetParameters().Where(IsImmediate).Any();
    }
}