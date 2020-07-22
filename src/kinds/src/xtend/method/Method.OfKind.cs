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
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static MethodInfo[] OfKind(this MethodInfo[] src, Vec128Type vk, bool total = false)
            => src.Where(m => m.IsKind(vk,total));

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static MethodInfo[] OfKind(this MethodInfo[] src, Vec256Type vk, bool total = false)
            => src.Where(m => m.IsKind(vk,total));

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static MethodInfo[] OfKind<T>(this MethodInfo[] src, Vec128Kind<T> vk)
            where T : unmanaged
                => src.Where(m => m.IsKind(vk));

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static MethodInfo[] OfKind<T>(this MethodInfo[] src, Vec256Kind<T> vk)
            where T : unmanaged
                => src.Where(m => m.IsKind(vk));
    }
}