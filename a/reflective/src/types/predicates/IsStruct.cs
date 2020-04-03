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
        /// Determines whether a type is a struct
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsStruct(this Type t)
            => t.IsValueType && !t.IsEnum;
    }
}