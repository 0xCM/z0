//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class XVexKinds
    {
        /// <summary>
        /// Returns true if a type is a closed 128-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this Type t, W128 w)
            => VKinds.closed(t,w);

        /// <summary>
        /// Returns true if a type is a closed 256-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this Type t, W256 w)
            => VKinds.closed(t,w);

        /// <summary>
        /// Returns true if a type is a closed 512-bit intrinsic vector
        /// </summary>
        /// <param name="param">The source parameter</param>
        /// <param name="w">The vector width</param>
        public static bool IsClosedVector(this Type t, W512 w)
            => VKinds.closed(t,w);
    }
}