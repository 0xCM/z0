//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;
    
    public static partial class FastOpX
    {        
        /// <summary>
        /// Returns a kind-identified system type if possible; throws an exception otherwise
        /// </summary>
        /// <param name="k">The identifying kind</param>
        [MethodImpl(Inline)]
        public static Option<Type> ToClrType(this NumericKind k)
        {
            var nt = k.NumericType();
            return nt.IsSome() ? some(nt.Subject) : none<Type>();
        }


        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsNatSpan(this Type t)
        {
            var query =    
                from def in t.GenericDefinition() 
                where def == typeof(NatSpan<,>) && t.IsClosedGeneric()
                select def;

            return query.IsSome();            
        }

    }
}