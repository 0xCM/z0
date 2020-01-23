//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    partial class TypeApiX
    {
        /// <summary>
        /// Selects the parameters for a method, if any, that accept an intrinsic vector
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<ParameterInfo> VectorParams(this MethodInfo m, FixedWidth width = default)
            => m.GetParameters().Where(p => p.ParameterType.IsVector(width));

        /// <summary>
        /// Selects methods from a stream that neither accept nor return any instrinsic vector parameters
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> NonVectorized(this IEnumerable<MethodInfo> src)
            => src.Where(m => !m.IsVectorized());

        /// <summary>
        /// Determines whether a method accepts and/or returns at least one memory block parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBlocked(this MethodInfo m)
            => FunctionType.blocked(m);        

        /// <summary>
        /// Selects methods from a stream that accept and/or return at least one memory block  parameter
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Blocked(this IEnumerable<MethodInfo> src)
            => src.Where(m => m.IsBlocked());

        /// <summary>
        /// Selects unblocked operations from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Unblocked(this IEnumerable<MethodInfo> src)
            => src.Where(x => !x.IsBlocked());

        /// <summary>
        /// Determines whether a method is classified as a span op
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsSpanOp(this MethodInfo m)
            => FunctionType.spanned(m);

        /// <summary>
        /// Determines whether a method is classified as a nat op
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsNatOp(this MethodInfo m)
            => FunctionType.natural(m);

        /// <summary>
        /// Determines the bit-width of each intrinsic or primal method parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<Pair<ParameterInfo,FixedWidth>> InputWidths(this MethodInfo m)
            => FunctionType.inputwidths(m);

        /// <summary>
        /// Determines the bit-width of an intrinsic or primal return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Pair<ParameterInfo,FixedWidth> OutputWidth(this MethodInfo m)
            => FunctionType.outputwidth(m);

        /// <summary>
        /// Determines whether all operands are primal
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsPrimal(this MethodInfo m)
            => FunctionType.primal(m);

        /// <summary>
        /// Determines whether a method defines a unary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryFunc(this MethodInfo m)
            => FunctionType.unary(m);

        /// <summary>
        /// Determines whether a method defines a binary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryFunc(this MethodInfo m)
            => FunctionType.binary(m);

        /// <summary>
        /// Determines whether a method defines a binary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryFunc(this MethodInfo m)
            => FunctionType.ternary(m);

        /// <summary>
        /// Determines whether a method is a unary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryOp(this MethodInfo m)
            => FunctionType.unaryop(m);

        /// <summary>
        /// Determines whether a method is a unary operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryOp(this MethodInfo m, PrimalKind k)
            => FunctionType.unaryop(m,k);

        /// <summary>
        /// Determines whether a method is a binary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryOp(this MethodInfo m)
            => FunctionType.binaryop(m);

        /// <summary>
        /// Determines whether a method is a binary operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryOp(this MethodInfo m, PrimalKind k)
            => FunctionType.binaryop(m,k);

        /// <summary>
        /// Determines whether a method is a ternary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryOp(this MethodInfo m)
            => FunctionType.ternaryop(m);

        /// <summary>
        /// Determines whether a method is a ternary operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryOp(this MethodInfo m, PrimalKind k)
            => FunctionType.ternaryop(m,k);

        /// <summary>
        /// Determines whether a method defines a parameter that requires an immediate
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool RequiresImmediate(this MethodInfo m)        
            => FunctionType.immrequired(m);

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsVectorized(this MethodInfo m, int? width, bool total)        
            => FunctionType.vectorized(m,width,total);

        public static bool IsUnaryImmVectorOp(this MethodInfo method)
        {
            var parameters = method.GetParameters().ToArray();
            return parameters.Length == 2 
                && parameters[0].ParameterType.IsVector() 
                && parameters[1].IsImmediate();
        }

        public static bool IsBinaryImmVectorOp(this MethodInfo method)
        {
            var parameters = method.GetParameters().ToArray();
            return parameters.Length == 3 
                && parameters[0].ParameterType.IsVector() 
                && parameters[1].ParameterType.IsVector() 
                && parameters[2].IsImmediate();
        }

        /// <summary>
        /// Determines whether a method is an action
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsAction(this MethodInfo m)
            => m.ReturnType == typeof(void);

        /// <summary>
        /// Determines whether a method is an action with specified arity
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="arity">The arity to match</param>
        public static bool IsAction(this MethodInfo m, int arity)
            => m.IsAction() && m.Arity() == arity;

        /// <summary>
        /// Determines whether a method is a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsFunction(this MethodInfo m)
            => FunctionType.function(m);

        /// <summary>
        /// Determines whether a method is a function with specified arity
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="arity">The arith to match</param>
        public static bool IsFunction(this MethodInfo m, int arity)
            => FunctionType.function(m,arity);

        /// <summary>
        /// Determines whether a method is an emitter, i.e. a method that returns a value but accepts no input
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsEmitter(this MethodInfo m)
            => FunctionType.emitter(m);

        /// <summary>
        /// Determines whether a method defines an operator over a (common) domain
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsOperator(this MethodInfo m)
            => FunctionType.isoperator(m);

        /// <summary>
        /// Determines whether a method defines an operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsOperator(this MethodInfo m, PrimalKind kind)
            => FunctionType.isoperator(m, kind);

        /// <summary>
        /// Determines whether a method is homogenous with respect to input/output values
        /// </summary>
        /// <param name="src">The source stream</param>
        public static bool IsHomogenous(this MethodInfo m)
            => FunctionType.homogenous(m);

        /// <summary>
        /// Determines whether a method accepts natural number type values as arguments
        /// </summary>
        /// <param name="m">The method to test</param>
        public static bool AcceptsNatValues(this MethodInfo m)
            => TypeNatType.accepts(m);

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsVectorized(this MethodInfo m, bool total = false)        
            => FunctionType.vectorized(m,total);

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsSegmented(this MethodInfo m)        
            => FunctionType.vectorized(m,false) || FunctionType.blocked(m);

        /// <summary>
        /// Determines whether a method defines a vectorized operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsVectorOp(this MethodInfo m)        
            => FunctionType.vectorized(m) && FunctionType.isoperator(m);

        /// <summary>
        /// Determines whether a method defines a predicate that returns a bit or bool value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsPredicate(this MethodInfo m)        
            => FunctionType.predicate(m);

        /// <summary>
        /// Determines whether a method is a primal shift operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsPrimalShift(this MethodInfo m)        
            => FunctionType.primalshift(m);

        /// <summary>
        /// Determines whether a parameters is an immediate
        /// </summary>
        /// <param name="param">The parameter to examine</param>
        public static bool IsImmediate(this ParameterInfo param)
            => FunctionType.immediate(param);



        /// <summary>
        /// Selects unary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> UnaryOps(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsUnaryOp());

        /// <summary>
        /// Selects kind-specific unary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> UnaryOps(this IEnumerable<MethodInfo> src, PrimalKind k)
            => src.Where(x => x.IsUnaryOp(k));

        /// <summary>
        /// Selects binary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> BinaryOps(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsBinaryOp());

        /// <summary>
        /// Selects kind-specific binary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> BinaryOps(this IEnumerable<MethodInfo> src, PrimalKind k)
            => src.Where(x => x.IsBinaryOp(k));

        /// <summary>
        /// Selects ternary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> TernaryOps(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsTernaryOp());

        /// <summary>
        /// Selects kind-specific ternary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> TernaryOps(this IEnumerable<MethodInfo> src, PrimalKind k)
            => src.Where(x => x.IsTernaryOp(k));

        /// <summary>
        /// Selects the methods that define parameters that require immediate values
        /// </summary>
        /// <param name="src">The methods to examine</param>
        /// <param name="required">Whether an immediate is required</param>
        public static IEnumerable<MethodInfo> RequiresImmediate(this IEnumerable<MethodInfo> src)
            => src.Where(RequiresImmediate);

        /// <summary>
        /// Selects operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Operators(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsOperator());

    }
}