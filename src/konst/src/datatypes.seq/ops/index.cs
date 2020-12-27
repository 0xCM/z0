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

    using static Part;

    partial struct Seq
    {
        /// <summary>
        /// Creates a <see cref='Index{I,T}'/> from an array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        /// <typeparam name="I">The index type</typeparam>
        [MethodImpl(Inline)]
        public static Index<I,T> index<I,T>(T[] src)
            where I : unmanaged
                => new Index<I,T>(src);

        /// <summary>
        /// Creates an indexed sequence from a stream
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IndexedSeq<T> index<T>(IEnumerable<T> src)
            => new IndexedSeq<T>(src.Array());

        /// <summary>
        /// Creates an indexed sequence from a stream
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IndexedSeq<I,T> index<I,T>(IEnumerable<T> src)
            where I : unmanaged
                => new IndexedSeq<I,T>(array(src));

        /// <summary>
        /// Creates an indexed sequence from a parameter array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IndexedSeq<T> index<T>(params T[] src)
            => new IndexedSeq<T>(src, true);
    }
}