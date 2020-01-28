//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public static class FunctionTypeX
    {
        /// <summary>
        /// Derives a signature from reflected method metadata
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline)]
        public static MethodSig Signature(this MethodInfo src)
            => MethodSig.Define(src);

        /// <summary>
        /// Determines the variance of a function parameter
        /// </summary>
        /// <param name="src">The source parameter</param>
        [MethodImpl(Inline)]
        public static ParamDirection Direction(this ParameterInfo src)
            => FunctionType.direction(src);

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
        /// Determines whether a method is a binary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryOp(this MethodInfo m)
            => FunctionType.binaryop(m);

        /// <summary>
        /// Determines whether a method is a ternary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryOp(this MethodInfo m)
            => FunctionType.ternaryop(m);

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
            => FunctionType.function(m);

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
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsVectorized(this MethodInfo m)        
            => FunctionType.vectorized(m, false);

        /// <summary>
        /// Determines whether a method produces, but does not accept, vector values
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsVectorFactory(this MethodInfo m)        
            => FunctionType.vectorfactory(m);

        /// <summary>
        /// Determines whether a method defines a vectorized operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsVectorOp(this MethodInfo m)        
            => FunctionType.vectorized(m) && FunctionType.isoperator(m);

        /// <summary>
        /// Determines whether a method accepts and/or returns at least one memory block parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBlocked(this MethodInfo m)
            => FunctionType.blocked(m);        

        /// <summary>
        /// Determines whether a method is segmentation-centric
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsSegmented(this MethodInfo m)
            => m.IsVectorized() || m.IsBlocked();

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
        /// Determines whether all operands are primal
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsPrimalOp(this MethodInfo m)
            => FunctionType.primal(m);

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
            => FunctionType.immneeds(param);

        /// <summary>
        /// Selects unary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> UnaryOps(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsUnaryOp());

        /// <summary>
        /// Selects binary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> BinaryOps(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsBinaryOp());

        /// <summary>
        /// Selects ternary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> TernaryOps(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsTernaryOp());
    }
}