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

    using static Root;
 
    partial class RootReflections
    {
        /// <summary>
        /// Returns true if the method has unspecified generic parameters, false otherwise
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsOpenGeneric(this MethodInfo m)
            => m.ContainsGenericParameters;

        /// <summary>
        /// Returns true if the method has unspecified generic parameters, false otherwise
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static bool IsClosedGeneric(this MethodInfo src)
            => src.IsConstructedGenericMethod;

        /// <summary>
        /// Returns true if the method has unspecified generic parameters, false otherwise
        /// </summary>
        /// <param name="src">The method to examine</param>
        public static bool IsNonGeneric(this MethodInfo src)
            => !src.IsGenericMethod && !src.IsConstructedGenericMethod;
    
        /// <summary>
        /// Determines whether a method has a void return and, consequently, cannot be a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool HasVoidReturn(this MethodInfo m)
            => m.ReturnType == typeof(void);

    }
}