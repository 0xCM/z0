//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    partial class XClrQuery
    {
        /// <summary>
        /// Selects the types from a stream that implement a specific interface
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The interface type</typeparam>
        [Op]
        public static Type[] Realize<T>(this IEnumerable<Type> src)
            => src.Where(t => t.Interfaces().Contains(typeof(T))).Array();
    }
}