//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;
 
    partial class XTend
    {
        /// <summary>
        /// Returns true if a type is a closed 128-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this Type t, W128 w)
            => t.IsClosedGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is a closed 256-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this Type t, W256 w)
            => t.IsClosedGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is a closed 512-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this Type t, W512 w)
            => t.IsClosedGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a method parameter is a closed 128-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this ParameterInfo param, W128 w)
            => param.ParameterType.IsClosedGeneric() && param.ParameterType.IsVector(w);

        /// <summary>
        /// Returns true if a method parameter is a closed 256-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this ParameterInfo param, W256 w)
            => param.ParameterType.IsClosedGeneric() && param.ParameterType.IsVector(w);

        /// <summary>
        /// Returns true if a method parameter is a closed 512-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this ParameterInfo param, W512 w)
            => param.ParameterType.IsClosedGeneric() && param.ParameterType.IsVector(w); 
    }
}