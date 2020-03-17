//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    using NK = NumericKind;
    using NT = NumericKinded;
    using NI = NumericIndicator;

    partial class RootNumericOps
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

        /// <summary>
        /// Defines a numeric type model over a clr type that represents a numeric type; if
        /// the source type does not represent a numeric type, returns the empty model
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline)]
        public static NT NumericType(this Type src)
            => NT.From(src);

        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        public static ISet<Type> DistinctTypes(this NK k)
            => Numeric.typeset(k);

        /// <summary>
        /// Convers a source value, which is hopefully a supported kind, to a target kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]
        public static object Convert(this NK dst, object src)
            => Cast.ocast(src,dst);

        [MethodImpl(Inline)]
        public static NK ToNumericKind(this FixedWidth w, NumericIndicator i) 
            => Numeric.from(w, i);
            

        [MethodImpl(Inline)]
        public static Option<NI> NumericIndicator(this Type t)
        {
            if(t == typeof(bit))
                return NI.Unsigned; 
            var i = t.NumericKind().Indicator();
            return i.IsSome() ? some(i) : none<NI>();
        }

        /// <summary>
        /// Determines whether a numeric type model is nonempty
        /// </summary>
        /// <param name="src">The source model</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this NumericKinded src)
            => !src.IsEmpty;
    }
}