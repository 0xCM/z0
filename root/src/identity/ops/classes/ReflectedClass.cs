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

    public static partial class ReflectedClass
    {
        /// <summary>
        /// Determines whether a parameters is an immediate
        /// </summary>
        /// <param name="src">The source parameter</param>
        public static bool IsImmediate(this ParameterInfo param)
            => param.Tagged<ImmAttribute>();

        /// <summary>
        /// Determines whether a method defines a parameter that requires an 8-bit immediate immediate
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool AcceptsImmediate(this MethodInfo m)        
            => m.GetParameters().Where(IsImmediate).Any();

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
        /// Determines whether a method is a numeric operator with a specified arity
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsNumericOperator(this MethodInfo m, int? arity = null)
            => m.IsOperator()  && m.IsNumeric() && (arity != null ? m.Arity() == arity : true);        

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

        /// <summary>
        /// Queries the stream for methods that are recognized as numeric operators
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> NumericOperators(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.IsNumericOperator());

        /// <summary>
        /// Selects numeric operators with a specifed arity from the source stream
        /// </summary>
        /// <param name="src">The methods to filter</param>
        public static IEnumerable<MethodInfo> NumericOperators(this IEnumerable<MethodInfo> src, int arity)
            => src.Where(x => x.IsNumericOperator(arity));
    }
}