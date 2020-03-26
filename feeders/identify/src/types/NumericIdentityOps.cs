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

    using static Identify;

    using NK = NumericKind;
    using NI = NumericIndicator;

    public static class NumericIdentityOps
    {
        /// <summary>
        /// Determines whether a method has numeric operands (if any) and a numeric return type (if any)
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static bool IsNumeric(this MethodInfo src)
            => NumericMethods.test(src);

        /// <summary>
        /// Computes the primal types identified by a specified kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        public static ISet<Type> DistinctTypes(this NumericKind k)
            => Identify.TypeSet(k);

        [MethodImpl(Inline)]
        public static Option<NI> NumericIndicator(this Type t)
        {
            if(t.Name == "bit")
                return NI.Unsigned; 
            var i = t.NumericKind().Indicator();
            return i != 0 ? Option.some(i) : Option.none<NI>();
        }           

        /// <summary>
        /// Enumerates the distinct numeric kinds represented by the (bitfield) source kind
        /// </summary>
        /// <param name="k">The kind to evaluate</param>
        public static ISet<NK> DistinctKinds(this NK k)  
            => Identify.KindSet(k);    
    }
}