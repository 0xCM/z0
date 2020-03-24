//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    using GS = GenericStateKind;

    public static partial class ReflectedClass
    {
        /// <summary>
        /// Determines whether a type is a span
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsSpan(this Type t)
            => SpanTypes.test(t);

        /// <summary>
        /// Classifies a type according to whether it is a span and, if so, what sort of span
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static SpanKind SpanKind(this Type t)
            => SpanTypes.kind(t);

        /// <summary>
        /// Determines whether a method is a vectorized operator which, by definition, is an operator 
        /// (which, by definition, is an homogenous function) with a vectorized operand which, by definition, 
        /// is an operand of intrinsic vector type (which, by definition, is one of the system-defined intrinsic vector types
        /// or a custom instrinsic vector type)
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool IsVectorizedOperator(this MethodInfo src)
            => src.IsOperator() && src.ReturnType.IsVector();

        /// <summary>
        /// Returns the source method's kind identifier if it exists
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static OpKindId? KindId(this MethodInfo m)
            => m.Tag<OpKindAttribute>().MapValueOrNull(a => a.KindId);

        /// <summary>
        /// Determines whether the method has a kind identifier
        /// </summary>
        /// <param name="m">The source method</param>
        public static bool IsKinded(this MethodInfo m)
            => m.KindId().HasValue;

        /// <summary>
        /// Determines whether a method defines an operator with identified kind
        /// </summary>
        /// <param name="m">The source method</param>
        public static bool IsKindedOperator(this MethodInfo m)
            => m.IsKinded() && m.IsOperator();

        /// <summary>
        /// Determines whether a method defines a unary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryFunction(this MethodInfo m)
            => m.IsFunction() && m.HasArityValue(1);

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
            => m.IsFunction() && m.HasArityValue(2);

        /// <summary>
        /// Determines whether a method defines a binary function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryFunction(this MethodInfo m)
            => m.IsFunction() && m.HasArityValue(3);

        /// <summary>
        /// Determines whether a method is a ternary operator
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryOperator(this MethodInfo m)
            => m.IsHomogenous() && m.IsTernaryFunction();

        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="src">The method to test</param>
        public static bool IsFullyVectorized(this MethodInfo src)        
            => TypeIdentities.IsCpuVector(src.ReturnType) 
            && src.ParameterTypes().All(TypeIdentities.IsCpuVector);

        public static GenericStateKind GenericState(this Type src, bool effective)
            =>   src.IsOpenGeneric(false) ? GS.Open 
               : src.IsClosedGeneric(false) ? GS.Closed 
               : src.IsGenericTypeDefinition ? GS.Definition 
               : 0;

        public static GenericStateKind GenericState(this MethodInfo src, bool effective)
            =>   src.IsOpenGeneric() ? GS.Open 
               : src.IsClosedGeneric() ? GS.Closed 
               : src.IsGenericMethodDefinition ? GS.Definition 
               : 0;

        /// <summary>
        /// Selects unary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> UnaryOperators(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsUnaryOperator());

        /// <summary>
        /// Selects binary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> BinaryOperators(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsBinaryOperator());

        /// <summary>
        /// Selects ternary operators from a stream
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> TernaryOperators(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsTernaryOperator());

        /// <summary>
        /// Queries the stream for methods that have a nonemtpy kind assignment
        /// </summary>
        /// <param name="src">The souce methods</param>
        public static IEnumerable<MethodInfo> Kinded(this IEnumerable<MethodInfo> src)
            => src.Where(IsKinded);

        /// <summary>
        /// Queries the stream for mathods that are of a specified kind
        /// </summary>
        /// <param name="src">The souce methods</param>
        /// <param name="kind">The kind to match</param>
        public static IEnumerable<MethodInfo> Kinded(IEnumerable<MethodInfo> src, OpKindId kind)
            => from m in src where m.KindId() == kind select m;

        /// <summary>
        /// Queries the stream for methods that have a nonemtpy kind assignment
        /// </summary>
        /// <param name="src">The souce methods</param>
        /// <param name="kind">The kind to match</param>
        public static IEnumerable<MethodInfo> KindedOperators(this IEnumerable<MethodInfo> src)
            => src.Where(IsKindedOperator);
    }
}