//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static ReflectionFlags;
    using static z;

    partial class XTend
    {
        /// <summary>
        /// Retrieves the values of a type's public instance properties
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="o">The type instance</param>
        public static IReadOnlyDictionary<string, object> GetPropertyValues(this Type t, object o)
            => dict(map(MemberPropertyCache.Lookup(o), p => (p.Name, p.GetValue(o))));

        /// <summary>
        /// For a generic type or reference to a generic type, retrieves the generic type definition; otherwise, returns none
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Option<Type> GenericDefinition(this Type t)
        {
            var effective = t.EffectiveType();
            if(effective.IsConstructedGenericType)
                return effective.GetGenericTypeDefinition();
            else if(effective.IsGenericTypeDefinition)
                return effective;
            else
                return default;            
        }        
                
        /// <summary>
        /// For a generic type or reference to a generic type, retrieves the generic type definition;
        /// otherwise, returns the void type
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static Type GenericDefinition2(this Type t)
        {
            var effective = t.EffectiveType();
            if(effective.IsConstructedGenericType)
                return effective.GetGenericTypeDefinition();
            else if(effective.IsGenericTypeDefinition)
                return effective;
            else
                return typeof(void);            
        }
    }
}