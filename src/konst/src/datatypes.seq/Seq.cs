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

    [ApiHost(ApiNames.Seq, true)]
    public readonly partial struct Seq
    {
        const NumericKind Closure = UInt64k;

        public static string format<T>(T[] src)
            => delimit(src).Format();

        /// <summary>
        /// Tests the source index for non-emptiness
        /// </summary>
        /// <param name="src">The index to test</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint count<T>(in DataIndex<T> src)
            where T : struct
                => (uint)(src.Data?.Length ?? 0);

        /// <summary>
        /// Tests the source index for non-emptiness
        /// </summary>
        /// <param name="src">The index to test</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool nonempty<T>(in DataIndex<T> src)
            where T : struct
                => count(src) == 0;

        /// <summary>
        /// Tests the source index for emptiness
        /// </summary>
        /// <param name="src">The index to test</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool empty<T>(in DataIndex<T> src)
            where T : struct
                => src.Data == null || src.Data.Length == 0;

        /// <summary>
        /// Reverses an array in-place
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] reverse<T>(T[] src)
        {
            Array.Reverse(src);
            return src;
        }

        /// <summary>
        /// Produces an indexed sequence from a parameter array
        /// </summary>
        /// <param name="src">The source items</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static IndexedSeq<T> dataseq<T>(params T[] src)
            => src;

        /// <summary>
        /// Creates a value index from an array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static DataIndex<T> dataindex<T>(T[] src)
            where T : struct
                => new DataIndex<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IndexedSeq<T> singletons<T>(params IEnumerable<T>[] src)
            where T : unmanaged
                => src.SelectMany(x => x);

        /// <summary>
        /// Creates an indexed sequence from a stream
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IndexedSeq<T> indexed<T>(IEnumerable<T> src)
            => new IndexedSeq<T>(array(src));

        /// <summary>
        /// Creates an indexed sequence from a stream
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static MutableSeq<T> mutable<T>(IEnumerable<T> src)
            => new MutableSeq<T>(array(src));

        /// <summary>
        /// Creates an indexed sequence from a stream
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IndexedSeq<I,T> indexed<I,T>(IEnumerable<T> src)
            where I : unmanaged
                => new IndexedSeq<I,T>(array(src));

        /// <summary>
        /// Creates an indexed sequence from a parameter array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IndexedSeq<T> indexed<T>(params T[] src)
            => new IndexedSeq<T>(src, true);

        /// <summary>
        /// Creates a mutable sequence from a parameter array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static MutableSeq<T> mutable<T>(params T[] src)
            => new MutableSeq<T>(src, true);

        /// <summary>
        /// Creates an index from an array
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DataIndex<T> values<T>(T[] src)
            where T : struct
                => new DataIndex<T>(src);

        /// <summary>
        /// Creates an index from a stream
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DataIndex<T> values<T>(IEnumerable<T> src)
            where T : struct
                => new DataIndex<T>(array(src));

        /// <summary>
        /// Creates a <see cref='IndexedView{T}'/> from a <see cref ='IEnumerable{T}'/>
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IndexedView<T> view<T>(IEnumerable<T> src)
            => new IndexedView<T>(array(src));

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
        /// All of your streams belong to us
        /// </summary>
        /// <param name="src">The source streams</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Deferred<T> join<T>(params IEnumerable<T>[] src)
            => src.SelectMany(x => x);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IndexedSeq<T> EmptySeq<T>()
            => new IndexedSeq<T>(EmptyArray<T>(),true);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Index<T> EmptyIndex<T>()
            => new Index<T>(EmptyArray<T>());

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bit search<T>(in Index<T> src, Func<T,bool> predicate, out T found)
        {
            var view = src.View;
            var count = view.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var candidate = ref z.skip(view,i);
                if(predicate(candidate))
                {
                    found = candidate;
                    return true;
                }
            }
            found = default;
            return false;
        }
   }
}