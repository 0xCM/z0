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
    
    partial class Reflective
    {
        /// <summary>
        /// Determines whether a type is a reference to a generic type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsGenericRef(this Type t)
            => t.IsRef() && t.GetElementType().IsGenericType;
    }
}