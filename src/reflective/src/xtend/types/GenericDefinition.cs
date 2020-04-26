//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    partial class Reflective
    {
        /// <summary>
        /// For a generic type or reference to a generic type, retrieves the generic type definition;
        /// otherwise, returns the void type
        /// </summary>
        /// <param name="t">The type to examine</param>
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