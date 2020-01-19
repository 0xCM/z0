//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    public static class FunctionType
    {
        /// <summary>
        /// Determines whether a method is a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool function(MethodInfo m)
            => m.ReturnType != typeof(void);

        /// <summary>
        /// Determines whether a method is a function with specified arity
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="arity">The arith to match</param>
        public static bool function(this MethodInfo m, int arity)
            => function(m) && m.HasArity(arity);

        /// <summary>
        /// Determines whether a method defines a unary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool unary(MethodInfo m)
            => m.IsFunction() && m.HasArity(1);

        /// <summary>
        /// Determines whether a method defines a binary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool binary(MethodInfo m)
            => m.IsFunction() && m.HasArity(2);

        /// <summary>
        /// Determines whether a method defines a binary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool ternary(MethodInfo m)
            => m.IsFunction() && m.HasArity(3);

        /// <summary>
        /// Determines whether a method is homogenous with respect to input/output values
        /// </summary>
        /// <param name="src">The source stream</param>
        public static bool homogenous(MethodInfo m)
        {
            var inputs = m.ParameterTypes().ToSet();
            if(inputs.Count == 1)
                return inputs.Single() == m.ReturnType;
            else if(inputs.Count == 0)
                return m.ReturnType == typeof(void);
            else
                return false;
        }

        /// <summary>
        /// Determines whether a method is a unary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool unaryop(MethodInfo m)
            => homogenous(m) && unary(m);

        /// <summary>
        /// Determines whether a method is a unary operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool unaryop(MethodInfo m, PrimalKind k)
            => homogenous(m) && unary(m) && m.ReturnType.Kind() == k;

        /// <summary>
        /// Determines whether a method is a binary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool binaryop(MethodInfo m)
            => homogenous(m) && binary(m);

        /// <summary>
        /// Determines whether a method is a binary operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool binaryop(MethodInfo m, PrimalKind k)
            => homogenous(m) && binary(m) && m.ReturnType.Kind() == k;

        /// <summary>
        /// Determines whether a method is a ternary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool ternaryop(MethodInfo m)
            => homogenous(m) && ternary(m);

        /// <summary>
        /// Determines whether a method is a ternary operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool ternaryop(MethodInfo m, PrimalKind k)
            => homogenous(m) && ternary(m) && m.ReturnType.Kind() == k;

        /// <summary>
        /// Determines whether a method defines an operator over a (common) domain
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool isoperator(MethodInfo m)
            => m.IsFunction() && homogenous(m) && m.Arity() >= 1;

        /// <summary>
        /// Determines whether a method defines an operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool isoperator(MethodInfo m, PrimalKind k)
            => m.IsFunction() && homogenous(m) && m.Arity() >= 1 && m.ReturnType.Kind() == k;

        /// <summary>
        /// Determines whether a method is an emitter, i.e. a method that returns a value but accepts no input
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool emitter(MethodInfo m)
            => m.IsFunction() && m.HasArity(0);

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="m">The method to examine</param>        
        public static bool vectorized(MethodInfo m, bool total = false)        
            => total ? (VectorType.test(m.ReturnType) && m.ParameterTypes().All(VectorType.test)) 
                     : (VectorType.test(m.ReturnType) || m.ParameterTypes().Any(VectorType.test));

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool vectorized(MethodInfo m, int? width, bool total)        
            => total ? (VectorType.vector(m.ReturnType,width) && m.ParameterTypes().All(t => VectorType.vector(t,width))) 
                     : (VectorType.vector(m.ReturnType,width) || m.ParameterTypes().Any(t => VectorType.vector(t,width)));

        /// <summary>
        /// Determines whether a method defines a predicate that returns a bit or bool value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool predicate(MethodInfo m)
            => m.ParameterTypes().Distinct().Count() == 1 
            && (m.ReturnType == typeof(bit) || m.ReturnType == typeof(bool));

        /// <summary>
        /// Determines whether a method is a primal shift operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool primalshift(MethodInfo m)        
            => m.IsBinaryFunc() 
            && m.ReturnType == m.ParameterTypes().First() 
            && m.ParameterTypes().Second() == typeof(byte);

        /// <summary>
        /// Determines whether a method defines a parameter that requires an 8-bit immediate immediate
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool imm8required(MethodInfo m)        
            => m.GetParameters().Where(p => p.Attributed<ImmAttribute>()).Any();

        /// <summary>
        /// Returns a method's parameter types
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<Type> immediates(MethodInfo m)
            => m.GetParameters().Where(p => p.Attributed<ImmAttribute>()).Select(p => p.ParameterType);

        /// <summary>
        /// Determines the bit-width of each intrinsic or primal method parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<Pair<ParameterInfo,int>> inputwidths(MethodInfo m)
            => m.GetParameters().Select(p => paired(p, Classified.width(p.ParameterType)));

        /// <summary>
        /// Determines the bit-width of an intrinsic or primal return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Pair<ParameterInfo,int> outputwidth(MethodInfo m)
            => paired(m.ReturnParameter, m.ReturnType.BitWidth());
    }
}