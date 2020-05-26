//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    using API = BinaryLiterals;

    partial class XTend
    {
        /// <summary>
        /// Selects the binary literals declared by a type that are of a specified parametric primal type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <typeparam name="T">The primal literal type</typeparam>
        public static IEnumerable<BinaryLiteral<T>> BinaryLiterals<T>(this Type src)
            where T : unmanaged
                => API.attributed<T>(src);

        /// <summary>
        /// Selects the binary literals declared by a type
        /// </summary>
        /// <param name="src">The source type</param>
        public static IEnumerable<BinaryLiteral> BinaryLiterals(this Type src)
            => API.attributed(src);

        public static string Format(this BinaryLiteral src) 
            => API.format(src);

        public static string Format<T>(this BinaryLiteral<T> src) 
            where T : unmanaged
                => API.format(src);
    }
}