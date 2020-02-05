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

    using static RootShare;

    partial class RootX
    {
        /// <summary>
        /// Determines the numeric kind of a type, possibly none
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static NumericKind NumericKind(this Type t)
            => Numeric.kind(t);

        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        public static ISet<Type> DistinctTypes(this NumericKind k)
            => Numeric.typeset(k);

        public static object Convert(this NumericKind dst, object src)
            => Numeric.convert(dst,src);

        [MethodImpl(Inline)]
        public static NumericKind ToNumericKind(this FixedWidth w, NumericIndicator i) 
            => Numeric.from(w, i);

        [MethodImpl(Inline)]
        public static BoxedNumber Zero(this NumericKind kind)
            => BoxedNumber.From(Numeric.convert(kind, 0)); 
            
        /// <summary>
        /// Tests whether the source kind, considered as a bitfield, contains the match kind
        /// </summary>
        /// <param name="k">The source kind</param>
        /// <param name="match">The kind to match</param>
        [MethodImpl(Inline)]
        public static bool Is(this NumericKind k, NumericKind match)        
            => Numeric.@is(k,match);

        /// <summary>
        /// Tests whether the source kind, considered as a bitfield, contains the match id
        /// </summary>
        /// <param name="k">The source kind</param>
        /// <param name="match">The kind to match</param>
        [MethodImpl(Inline)]
        public static bool Is(this NumericKind k, NumericId match)        
            => Numeric.@is(k,match);

        /// <summary>
        /// Enumerates the distinct numeric kinds represented by the (bitfield) source kind
        /// </summary>
        /// <param name="k">The kind to evaluate</param>
        public static ISet<NumericKind> DistinctKinds(this NumericKind k)  
            => Numeric.kindset(k);    
    }
}