//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Values
    {
        /// <summary>
        /// Creates an indexed sequence from a stream
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static ValueSet<T> from<T>(IEnumerable<T> src)
            where T : struct
                => new ValueSet<T>(src); 

        /// <summary>
        /// Calculates the union between the source set and a target set and returns the target
        /// </summary>
        /// <param name="src">The set with which to union/param>
        public static ref readonly ValueSet<T> union<T>(in ValueSet<T> src, in ValueSet<T> dst)
            where T : struct
        {
            dst.Data.UnionWith(src);
            return ref dst;
        }

        public static bool contains<T>(in ValueSet<T> src, in T test)
            where T : struct
                => src.Data.Contains(test);
    }
}