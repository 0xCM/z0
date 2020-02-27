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

    using static Root;
    using NK = NumericKind;
    using NT = NumericType;
    using NI = NumericIndicator;


    public static class NumericExtensions
    {
        /// <summary>
        /// Determines the numeric kind of a type, possibly none
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static NK NumericKind(this Type src)
            => Numeric.kind(src);

        /// <summary>
        /// Returns true if the source type represents a primal numeric type
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline)]
        public static bool IsNumeric(this Type src)
            => src.NumericKind().IsSome();

        /// <summary>
        /// Defines a numeric type model over a clr type that represents a numeric type; if
        /// the source type does not represent a numeric type, returns the empty model
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline)]
        public static NT NumericType(this Type src)
            => NT.From(src);

        /// <summary>
        /// Defines a numeric type model over a kind that designates a specific clr type; if
        /// these constraints are unsatisfied, returns the empty model
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline)]
        public static NT NumericType(this NK src)
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
            
        /// <summary>
        /// Tests whether the source kind, considered as a bitfield, contains the match kind
        /// </summary>
        /// <param name="k">The source kind</param>
        /// <param name="match">The kind to match</param>
        [MethodImpl(Inline)]
        public static bool Is(this NumericKind k, NK match)        
            => Numeric.@is(k,match);

        /// <summary>
        /// Tests whether the source kind, considered as a bitfield, contains the match id
        /// </summary>
        /// <param name="k">The source kind</param>
        /// <param name="match">The kind to match</param>
        [MethodImpl(Inline)]
        public static bool Is(this NK k, NumericId match)        
            => Numeric.@is(k,match);

        /// <summary>
        /// Enumerates the distinct numeric kinds represented by the (bitfield) source kind
        /// </summary>
        /// <param name="k">The kind to evaluate</param>
        public static ISet<NK> DistinctKinds(this NK k)  
            => Numeric.kindset(k);    

        /// <summary>
        /// Determines whether a type is a primal float
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bool IsFloat(this NK k)
            => (k & NK.Float) != 0;

        /// <summary>
        /// Determines whether a kind is one of the signed integer types
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bool IsSigned(this NK k)
            => (k & NK.Signed) != 0;

        /// <summary>
        /// Determines whether a kind is one of the signed integer types
        /// </summary>
        /// <typeparam name="T">The type to test</typeparam>
        [MethodImpl(Inline)]
        public static bool IsUnsigned(this NK k)
            => (k & NK.Unsigned) != 0;        

        /// <summary>
        /// Produces a character {i | u | f} indicating whether the source type is signed, unsigned or float
        /// </summary>
        /// <param name="k">The primal classifier</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]   
        public static NI Indicator(this NK k)
        {
            if(k.IsUnsigned())
                return NI.Unsigned;
            else if(k.IsSigned())
                return NI.Signed;
            else if(k.IsFloat())
                return NI.Float;
            else
                return NI.None;
        }

        [MethodImpl(Inline)]
        public static Option<NI> NumericIndicator(this Type t)
        {
            if(t == typeof(bit))
                return NI.Unsigned; 
            var i = t.NumericKind().Indicator();
            return i.IsSome() ? some(i) : none<NI>(); //Option.some(i.ToChar()) : Option.none<char>();
        }

        /// <summary>
        /// Determines whether a numeric type model is nonempty
        /// </summary>
        /// <param name="src">The source model</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this NumericType src)
            => !src.IsEmpty;

        [MethodImpl(Inline)]
        public static string Format(this NumericKind k)
            => $"{k.Width()}{k.Indicator().Format()}";
    }
}