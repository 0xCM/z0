//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static ReflectionFlags;

    partial class RootReflections
    {
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
    }
}