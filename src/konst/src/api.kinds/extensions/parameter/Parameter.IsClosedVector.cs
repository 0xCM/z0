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
        /// Returns true if a method parameter is a closed 128-bit intrinsic vector
        /// </summary>
        /// <param name="p">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this ParameterInfo p, W128 w)
            => VectorKinds.closed(p,w);

        /// <summary>
        /// Returns true if a method parameter is a closed 256-bit intrinsic vector
        /// </summary>
        /// <param name="p">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this ParameterInfo p, W256 w)
            => VectorKinds.closed(p,w);

        /// <summary>
        /// Returns true if a method parameter is a closed 512-bit intrinsic vector
        /// </summary>
        /// <param name="p">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this ParameterInfo p, W512 w)
            => VectorKinds.closed(p,w);
    }
}