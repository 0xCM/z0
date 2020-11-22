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

    [ApiHost(ApiNames.Sets, true)]
    public readonly struct Sets
    {
        const NumericKind Closure = UInt64k;

        /// <summary>
        /// Creates a value set from a stream
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DataSet<T> datset<T>(IEnumerable<T> src)
            where T : struct
                => new DataSet<T>(src);

        /// <summary>
        /// Creates a value set from an array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DataSet<T> dataset<T>(params T[] src)
            where T : struct
                => new DataSet<T>(src);

        /// <summary>
        /// Calculates the union between the source set and a target set and returns the target
        /// </summary>
        /// <param name="src">The set with which to union/param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly DataSet<T> union<T>(in DataSet<T> src, in DataSet<T> dst)
            where T : struct
        {
            dst.Data.UnionWith(src);
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool contains<T>(in DataSet<T> src, in T test)
            where T : struct
                => src.Data.Contains(test);

        [Op, Closures(Closure)]
        public static Multiset<T> multiset<T>(IEnumerable<T> src)
            => new Multiset<T>(src);
    }
}