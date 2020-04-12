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
        /// Returns true if a type is an open generic 128-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsOpenVector(this Type t, W128 w)
            => t.IsOpenGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is an open generic 256-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsOpenVector(this Type t, W256 w)
            => t.IsOpenGeneric() && t.IsVector(w);

        /// <summary>
        /// Returns true if a type is an open generic 512-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsOpenVector(this Type t, W512 w)
            => t.IsOpenGeneric() && t.IsVector(w);



    }
}