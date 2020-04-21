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

    using static Seed;

    using NI = NumericIndicator;

    partial class XTend
    {
        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        public static ISet<Type> DistinctTypes(this NumericKind k)
            => Identities.types(k);

        [MethodImpl(Inline)]
        public static Option<NumericIndicator> NumericIndicator(this Type t)
        {
            if(t == typeof(bit))
                return NI.Unsigned; 
            var i = t.NumericKind().Indicator();
            return i != 0 ? Option.some(i) : Option.none<NumericIndicator>();
        }           

        /// <summary>
        /// Enumerates the distinct numeric kinds represented by the (bitfield) source kind
        /// </summary>
        /// <param name="k">The kind to evaluate</param>
        public static ISet<NumericKind> DistinctKinds(this NumericKind k)  
            => Identities.kinds(k);    
    }
}