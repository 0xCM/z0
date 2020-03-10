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

    using static Root;
 
    using NK = NumericKind;

    public static class ReflectedClass
    {
        /// <summary>
        /// Determines the numeric kind of a type, possibly none
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static NK NumericKind(this Type src)
            => Numeric.kind(src).ValueOrDefault();

        /// <summary>
        /// Determines the numeric kind identified by a type code, if any
        /// </summary>
        /// <param name="tc">The type code to evaluate</param>
        [MethodImpl(Inline)]
        public static NumericKind NumericKind(this TypeCode tc)
            => Numeric.kind(tc);

        /// <summary>
        /// Returns true if the source type represents a primal numeric type
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline)]
        public static bool IsNumeric(this Type src)
            => src.NumericKind().IsSome();

        /// <summary>
        /// Determines whether a method defines an operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsOperator(this MethodInfo m, NumericKind k)
            => m.IsFunction() && m.IsHomogenous() && m.Arity() >= 1 && m.ReturnType.NumericKind() == k;

        /// <summary>
        /// Determines whether a method is a binary operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryOperator(this MethodInfo m, NumericKind k)
            => m.IsUnaryOperator() && m.ReturnType.NumericKind() == k;

        /// <summary>
        /// Determines whether a method is a binary operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryOperator(this MethodInfo m, NumericKind k)
            => m.IsBinaryOperator() && m.ReturnType.NumericKind() == k;

        /// <summary>
        /// Determines whether a method is a ternary operator over a domain of specified kind
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryOperator(this MethodInfo m, NumericKind k)
            => m.IsTernaryOperator() && m.ReturnType.NumericKind() == k;

        /// <summary>
        /// Determines whether a method is a function the returns an enum value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsLiteralFunction(this MethodInfo m)
            => m.IsFunction() && m.ReturnType.IsEnum;

        /// <summary>
        /// Determines whether a method has numeric operands (if any) and a numeric return type (if any)
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsNumeric(this MethodInfo m)
            => (m.HasVoidReturn() || m.ReturnType.IsNumeric()) && m.ParameterTypes().All(t => t.IsNumeric());

        /// <summary>
        /// Determines whether a method is a function with numeric operands (if any) and return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsNumericFunction(this MethodInfo m)
            => m.IsFunction() 
            && m.ReturnType.IsNumeric()
            && m.ParameterTypes().All(t => t.NumericKind() != NK.None);

        /// <summary>
        /// Determines whether a method is a function accepts one or more arguments an returns a numeric or enum value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsMeasure(this MethodInfo m)
            => m.IsHomogenousFunction() && m.Arity() >= 1 
            && (m.ReturnType.NumericKind().IsSome() || m.ReturnType.IsEnum);
        
        /// <summary>
        /// Determines whether a method is a unary measure
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsLiteralMeasure(this MethodInfo m)
            => m.IsMeasure() && m.IsLiteralFunction();

        /// <summary>
        /// Determines whether a method is a unary measure
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryMeasure(this MethodInfo m)
            => m.IsMeasure() && m.IsUnaryFunction();

        /// <summary>
        /// Determines whether a method is a binary measure
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryMeasure(this MethodInfo m)
            => m.IsMeasure() && m.IsBinaryFunction();

        /// <summary>
        /// Determines whether a method is a ternary measure
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryMeasure(this MethodInfo m)
            => m.IsMeasure() && m.IsTernaryFunction();

        /// <summary>
        /// Assigns a measure classification, if any, to a method
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static MeasureKind MeasureKind(this MethodInfo m)
        {
            if(m.IsUnaryMeasure())
                return Z0.MeasureKind.UnaryMeasure;
            else if(m.IsBinaryMeasure())
                return Z0.MeasureKind.BinaryMeasure;
            else if(m.IsTernaryMeasure())
                return Z0.MeasureKind.TernaryMeasure;
            else
                return Z0.MeasureKind.None;
        }

        /// <summary>
        /// Determines whether a method defines a predicate that returns a bit or bool value
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsPredicate(this MethodInfo m)        
            => m.ParameterTypes().Distinct().Count() == 1 
            && (m.ReturnType == typeof(bit) || m.ReturnType == typeof(bool));

        /// <summary>
        /// Determines whether a method is a function that accepts a single argument
        /// and returns a bit or boolean value 
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsUnaryPredicate(this MethodInfo m)        
            => m.IsUnaryFunction() && m.IsPredicate();

        /// <summary>
        /// Determines whether a method is a function that accepts two homogenous arguments 
        /// and returns a bit or boolean value 
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsBinaryPredicate(this MethodInfo m)        
            => m.IsBinaryFunction() && m.IsPredicate();

        /// <summary>
        /// Determines whether a method is a function that accepts three homogenous arguments 
        /// and returns a bit or boolean value 
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsTernaryPredicate(this MethodInfo m)        
            => m.IsTernaryFunction() && m.IsPredicate();

        /// <summary>
        /// Returns the source method's kind identifier if it exists
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static OpKindId? KindId(this MethodInfo m)
            => m.Tag<OpKindAttribute>().MapValueOrNull(a => a.KindId);

        /// <summary>
        /// Selects the methods from a source stream that have an identified kind
        /// </summary>
        /// <param name="src">The souce methods</param>
        public static IEnumerable<MethodInfo> WithIdentifiedKind(this IEnumerable<MethodInfo> src)
            => from m in src where m.KindId().HasValue select m;

        /// <summary>
        /// Selects the methods from a source stream of a specified kind
        /// </summary>
        /// <param name="src">The souce methods</param>
        /// <param name="kind">The kind to match</param>
        public static IEnumerable<MethodInfo> WithIdentifiedKind(IEnumerable<MethodInfo> src, OpKindId kind)
            => from m in src where m.KindId() == kind select m;
            
    }
}