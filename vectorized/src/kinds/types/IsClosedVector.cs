//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Root;

    partial class VectorTypeOps
    {
        /// <summary>
        /// Returns true if a type is a closed 128-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        [MethodImpl(Inline)]
        public static bool IsClosedVector(this Type t, N128 w)
            => t.IsClosedGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is a closed 256-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        [MethodImpl(Inline)]
        public static bool IsClosedVector(this Type t, N256 w)
            => t.IsClosedGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is a closed 512-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        [MethodImpl(Inline)]
        public static bool IsClosedVector(this Type t, N512 w)
            => t.IsClosedGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a method parameter is a closed 128-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this ParameterInfo param, N128 w)
            => param.ParameterType.IsClosedGeneric() && param.ParameterType.IsVector(w);

        /// <summary>
        /// Returns true if a method parameter is a closed 256-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this ParameterInfo param, N256 w)
            => param.ParameterType.IsClosedGeneric() && param.ParameterType.IsVector(w);

        /// <summary>
        /// Returns true if a method parameter is a closed 512-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this ParameterInfo param, N512 w)
            => param.ParameterType.IsClosedGeneric() && param.ParameterType.IsVector(w);
    }
}