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
    using static z;

    [ApiHost(ApiNames.Indexed, true)]
    public readonly struct Indexed
    {
        const NumericKind Closure = UInt64k;

        /// <summary>
        /// Creates a <see cref='IndexedView{T}'/> from a <see cref ='IEnumerable{T}'/>
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IndexedView<T> view<T>(IEnumerable<T> src)
            => new IndexedView<T>(src.Array());

        /// <summary>
        /// Creates a <see cref='IndexedView{T}'/> from an array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IndexedView<T> view<T>(T[] src)
            => new IndexedView<T>(src);

        /// <summary>
        /// Creates a <see cref='IndexedView{I,T}'/> from an array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        /// <typeparam name="I">The index type</typeparam>
        [MethodImpl(Inline)]
        public static IndexedView<I,T> view<I,T>(T[] src, I i = default)
            where I : unmanaged
                => new IndexedView<I,T>(src);

        /// <summary>
        /// Creates an indexed sequence from a stream
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IndexedSeq<T> seq<T>(IEnumerable<T> src)
            => new IndexedSeq<T>(src);

        /// <summary>
        /// Creates an indexed sequence from a parameter array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IndexedSeq<T> seq<T>(params T[] src)
            => new IndexedSeq<T>(src);

        /// <summary>
        /// Creates an index from an array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ValueIndex<T> values<T>(T[] src)
            where T : struct
                => new ValueIndex<T>(src);

        /// <summary>
        /// Creates an index from a stream
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ValueIndex<T> values<T>(IEnumerable<T> src)
            where T : struct
                => new ValueIndex<T>(src.Array());
    }
}