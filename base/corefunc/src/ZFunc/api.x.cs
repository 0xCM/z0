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
            => MethodSig.Define(src);

        /// <summary>
        /// Derives an operation descriptor from reflected method metadata and supplied type argments, if applicable
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="args">The arguments over which to close the method, if generic</param>
        [MethodImpl(Inline)]
        public static Operation Descriptor(this MethodInfo src, params Type[] args)
            => Operation.Define(src, args);

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
        /// Returns the keyword used to designate a kind-identified primal type, if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        [MethodImpl(Inline)]
        public static string TypeKeyword(this PrimalKind k)
            => Classified.keyword(k);

        /// <summary>
        /// Determines whether a type is an intrinsic vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVector(this Type t)
            => Classified.vector(t);

        /// <summary>
        /// Determines whether a type is blocked memory store
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsBlocked(this Type t)
            => Classified.blocked(t);

        /// <summary>
        /// Determines whether a type is an intrinsic vector of specified width
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsVector(this Type t, int? width)        
            => Classified.vector(t,width);

        /// <summary>
        /// Returns true if the source type is intrinsic or blocked
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSegmented(this Type t)
            => Classified.segmented(t);

        /// <summary>
        /// If the source type is primal or intrinsic, returns the bit-width; otherwise, returns 0
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static int BitWidth(this Type t)
            => Classified.bitwidth(t);

        /// <summary>
        /// Determines whether a method is an action
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsAction(this MethodInfo m)
            => Classified.action(m);

        /// <summary>
        /// Determines whether a method is an action with specified arity
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="arity">The arity to match</param>
        public static bool IsAction(this MethodInfo m, int arity)
            => Classified.action(m,arity);

        /// <summary>
        /// Determines whether a method is a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsFunction(this MethodInfo m)
            => Classified.function(m);

        /// <summary>
        /// Determines whether a method is a function with specified arity
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="arity">The arith to match</param>
        public static bool IsFunction(this MethodInfo m, int arity)
            => Classified.function(m,arity);

        /// <summary>
        /// Determines whether a method is an emitter, i.e. a method that returns a value but accepts no input
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsEmitter(this MethodInfo m)
            => Classified.emitter(m);

        /// <summary>
        /// Determines whether a method defines an operator over a (common) domain
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsOperator(this MethodInfo m)
            => Classified.isoperator(m);

        /// <summary>
        /// Determines whether a method is homogenous with respect to input/output values
        /// </summary>
        /// <param name="src">The source stream</param>
        public static bool IsHomogenous(this MethodInfo m)
            => Classified.homogenous(m);

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsVectorized(this MethodInfo m, bool total = false)        
            => Classified.vectorized(m,total);

        /// <summary>
        /// Determines whether a method defines a vectorized operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsVectorOp(this MethodInfo m)        
            => Classified.isvectorop(m);

        /// <summary>
        /// Determines whether a method defines a predicate that returns a bit value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBitPredicate(this MethodInfo m)        
            => Classified.bitpredicate(m);

        /// <summary>
        /// Determines whether a method defines a predicate that returns a bit or bool value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsPredicate(this MethodInfo m)        
            => Classified.predicate(m);

        /// <summary>
        /// Determines whether a method is a primal shift operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsPrimalShift(this MethodInfo m)        
            => Classified.primalshift(m);

        /// <summary>
        /// Determines whether a method defines a parameter that requires an immediate
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool RequiresImmediate(this MethodInfo m)        
            => Classified.immrequired(m);

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsVectorized(this MethodInfo m, int? width, bool total)        
            => Classified.vectorized(m,width,total);

        /// <summary>
        /// Determines whether a method accepts and/or returns at least one memory block parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBlocked(this MethodInfo m)
            => Classified.blocked(m);

        /// <summary>
        /// Determines whether a method accepts and/or returns at least one memory block parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBlockedOp(this MethodInfo m)
            => m.IsOperator() && Classified.blocked(m);

        /// <summary>
        /// Selects the parameters for a method, if any, that accept an intrinsic vector
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static IEnumerable<ParameterInfo> InstrinsicParameters(this MethodInfo m, int? width = null)
            => m.GetParameters().Where(p => p.ParameterType.IsVector(width));
            
        /// <summary>
        /// Determines the bit-width of each intrinsic or primal method parameter
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Pair<ParameterInfo,int>[] InputWidths(this MethodInfo m)
            => Classified.inputwidths(m);

        /// <summary>
        /// Determines the bit-width of an intrinsic or primal return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static Pair<ParameterInfo,int> OutputWidth(this MethodInfo m)
            => Classified.outputwidth(m);

        /// <summary>
        /// Specifies the bit-width of a classified primitive
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static int BitWidth(this PrimalKind k)
            => Classified.width(k);

        /// <summary>
        /// Specifies the bit-width of a classified cpu vector
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static int BitWidth(this CpuVectorKind k)
            => Classified.width(k);

        /// <summary>
        /// Determines a sub-classification c := {'u' | 'i' | 'f'} according to whether a classified primal type
        /// is unsigned integral, signed integral or floating-point
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static char Sign(this PrimalKind k)
            => Classified.sign(k);

        /// <summary>
        /// Determines a sub-classification c := {'u' | 'i' | 'f'} according to whether a classified vector
        /// is defined over unsigned integral, signed integral or floating-point primal components
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static char Sign(this CpuVectorKind k)
            => Classified.sign(k);

        /// <summary>
        /// Determines whether a specified kind is included within a classification
        /// </summary>
        /// <param name="k">The classification</param>
        /// <param name="match">The kind to check</param>
        [MethodImpl(Inline)]
        public static bit Is(this PrimalKind k, PrimalKind match)        
            => (k & match) != 0;

        public static IEnumerable<PrimalKind> Distinct(this PrimalKind k)       
        {
            if(k.Is(PrimalKind.U8))
                yield return PrimalKind.U8;

            if(k.Is(PrimalKind.I8))
                yield return PrimalKind.I8;

            if(k.Is(PrimalKind.U16))
                yield return PrimalKind.U16;

            if(k.Is(PrimalKind.I16))
                yield return PrimalKind.I16;

            if(k.Is(PrimalKind.U32))
                yield return PrimalKind.U32;

            if(k.Is(PrimalKind.I32))
                yield return PrimalKind.I32;

            if(k.Is(PrimalKind.U64))
                yield return PrimalKind.U64;

            if(k.Is(PrimalKind.I64))
                yield return PrimalKind.I64;

            if(k.Is(PrimalKind.F32))
                yield return PrimalKind.F32;

            if(k.Is(PrimalKind.F64))
                yield return PrimalKind.F64;
        }
            
        [MethodImpl(Inline)]
        public static bool IsZFunc(this MethodInfo m)
            => Attribute.IsDefined(m,typeof(ZFuncAttribute));

        public static IEnumerable<PrimalKind> SupportedPrimals(this MethodInfo m)
        {
            if(m.IsZFunc() && m.IsOpenGeneric())
            {
                var a = m.GetCustomAttribute<ZFuncAttribute>();
                foreach(var k in a.Closures.Distinct())
                    yield return k;
            }
        }            
 
        /// <summary>
        /// Determines whether a method defines a unary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryFunc(this MethodInfo m)
            => Classified.unaryfunc(m);

        /// <summary>
        /// Determines whether a method defines a binary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryFunc(this MethodInfo m)
            => Classified.binaryfunc(m);

        /// <summary>
        /// Determines whether a method defines a binary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryFunc(this MethodInfo m)
            => Classified.ternaryfunc(m);

        /// <summary>
        /// Determines whether a method is a unary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryOp(this MethodInfo m)
            => Classified.unaryop(m);

        /// <summary>
        /// Determines whether a method is a unary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryOp(this MethodInfo m)
            => Classified.binaryop(m);

        /// <summary>
        /// Determines whether a method is a unary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryOp(this MethodInfo m)
            => Classified.ternaryop(m);

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
