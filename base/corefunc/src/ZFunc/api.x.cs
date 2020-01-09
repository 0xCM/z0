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
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public static class OpApiX
    {
        /// <summary>
        /// Derives a signature from reflected method metadata
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline)]
        public static MethodSig Signature(this MethodInfo src)
            => ZFunc.signature(src);

        /// <summary>
        /// Derives an operation descriptor from reflected method metadata and supplied type argments, if applicable
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="args">The arguments over which to close the method, if generic</param>
        [MethodImpl(Inline)]
        public static Operation Descriptor(this MethodInfo src, params Type[] args)
            => ZFunc.descriptor(src, args);

        /// <summary>
        /// Determines the primal kind of a type, possibly none
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static PrimalKind Kind(this Type t)
            => Classified.primalkind(t);

        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        [MethodImpl(Inline)]
        public static Type PrimalType(this PrimalKind k)
            => Classified.primaltype(k);

        /// <summary>
        /// Determines whether a type is an intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsIntrinsic(this Type t)
            => ZFunc.intrinsic(t);


        /// <summary>
        /// Determines whether a type is blocked memory store
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsDataBlock(this Type t)
            => Classified.blocked(t);

        /// <summary>
        /// Determines whether a type is an intrinsic vector of specified width
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsIntrinsic(this Type t, int? width)        
            => ZFunc.intrinsic(t,width);

        /// <summary>
        /// Returns true if the source type is intrinsic or blocked
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSegmented(this Type t)
            => ZFunc.segmented(t);

        /// <summary>
        /// If the source type is primal or intrinsic, returns the bit-width; otherwise, returns 0
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static int BitWidth(this Type t)
            => ZFunc.bitwidth(t);

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
            => m.IsAction() && m.HasArity(arity);

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
        /// Determines whether a method defines a unary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryFunc(this MethodInfo m)
            => m.IsFunction() && m.HasArity(1);

        /// <summary>
        /// Determines whether a method defines a binary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryFunc(this MethodInfo m)
            => m.IsFunction() && m.HasArity(2);

        /// <summary>
        /// Determines whether a method defines a binary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryFunc(this MethodInfo m)
            => m.IsFunction() && m.HasArity(3);

        /// <summary>
        /// Determines whether a method defines an operator over a (common) domain
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsOperator(this MethodInfo m)
            => m.IsFunction() && m.IsHomogenous() && m.Arity() >= 1;

        /// <summary>
        /// Determines whether a method is a unary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryOp(this MethodInfo m)
            => m.IsHomogenous() && m.IsUnaryFunc();

        /// <summary>
        /// Determines whether a method is a unary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryOp(this MethodInfo m)
            => m.IsHomogenous() && m.IsBinaryFunc();

        /// <summary>
        /// Determines whether a method is a unary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryOp(this MethodInfo m)
            => m.IsHomogenous() && m.IsTernaryFunc();

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsVectorized(this MethodInfo m, bool total = false)        
            => ZFunc.vectorized(m,total);

        /// <summary>
        /// Determines whether a method defines a vectorized operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsVectorOp(this MethodInfo m)        
            => m.IsOperator() && ZFunc.vectorized(m,true);

        /// <summary>
        /// Determines whether a method defines a primal operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsPrimalOp(this MethodInfo m)        
            => m.IsOperator() && m.ReturnType.Kind() != PrimalKind.None;

        /// <summary>
        /// Determines whether a method defines a predicate that returns a bit value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBitPredicate(this MethodInfo m)        
            => m.ParameterTypes().Distinct().Count() == 1 
            && (m.ReturnType == typeof(bit));

        /// <summary>
        /// Determines whether a method defines a predicate that returns a bit or bool value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsPredicate(this MethodInfo m)        
            => m.ParameterTypes().Distinct().Count() == 1 
            && (m.ReturnType == typeof(bit) || m.ReturnType == typeof(bool));

        /// <summary>
        /// Determines whether a method is a primal shift operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsPrimalShift(this MethodInfo m)        
            => m.IsBinaryFunc() 
            && m.ReturnType == m.ParameterTypes().First() 
            && m.ParameterTypes().Second() == typeof(byte);

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsVectorized(this MethodInfo m, int? width, bool total)        
            => ZFunc.vectorized(m,width,total);

        /// <summary>
        /// Determines whether a method accepts and/or returns at least one memory block parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBlocked(this MethodInfo m)
            => Classified.blocked(m);

        /// <summary>
        /// Selects the parameters for a method, if any, that accept an intrinsic vector
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<ParameterInfo> InstrinsicParameters(this MethodInfo m, int? width = null)
            => m.GetParameters().Where(p => p.ParameterType.IsIntrinsic(width));
            
        /// <summary>
        /// Determines the bit-width of each intrinsic or primal method parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Pair<ParameterInfo,int>[] InputWidths(this MethodInfo m)
            => ZFunc.inputwidths(m);

        /// <summary>
        /// Determines the bit-width of an intrinsic or primal return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Pair<ParameterInfo,int> OutputWidth(this MethodInfo m)
            => ZFunc.outputwidth(m);

        /// <summary>
        /// Selects operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Operators(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsOperator());

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

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Vectorized(this IEnumerable<MethodInfo> src, int? width = null, bool total = false)
            => src.Where(m => m.IsVectorized(width,total));

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Vectorized(this IEnumerable<MethodInfo> src, IEnumerable<int> widths, bool total = false)
        {
            foreach(var w in widths)
            foreach(var m in src.Vectorized(w,total))
                yield return m;
        }            

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> Vectorized(this IEnumerable<MethodInfo> src, Pair<int> widths, bool total = false)
            => src.Vectorized(items(widths.A, widths.B), total);

        /// <summary>
        /// Selects methods from a stream that neither accept nor return any instrinsic vector parameters
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> NonVectorized(this IEnumerable<MethodInfo> src)
            => src.Where(m => !m.IsVectorized());

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
    }
}
