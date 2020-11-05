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

    [ApiHost(ApiNames.Seq, true)]
    public readonly struct Seq
    {
        const NumericKind Closure = UInt64k;

        /// <summary>
        /// Tests the source index for non-emptiness
        /// </summary>
        /// <param name="src">The index to test</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint count<T>(in ValueIndex<T> src)
            where T : struct
                => (uint)(src.Data?.Length ?? 0);

        /// <summary>
        /// Tests the source index for non-emptiness
        /// </summary>
        /// <param name="src">The index to test</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool nonempty<T>(in ValueIndex<T> src)
            where T : struct
                => count(src) == 0;

        /// <summary>
        /// Tests the source index for emptiness
        /// </summary>
        /// <param name="src">The index to test</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool empty<T>(in ValueIndex<T> src)
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
                => new ValueIndex<T>(array(src));

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

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IndexedSeq<I,T> concat<I,T>(IndexedSeq<I,T> head, IndexedSeq<I,T> tail)
            where I : unmanaged
                => new IndexedSeq<I,T>(array(head.Storage.Concat(tail.Storage)));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IndexedSeq<T> concat<T>(IndexedSeq<T> head, IndexedSeq<T> tail)
            => new IndexedSeq<T>(array(head.Storage.Concat(tail.Storage)));

        /// <summary>
        /// Constructs a nonempty stream
        /// </summary>
        /// <param name="head">The first element in the stream</param>
        /// <param name="tail">The remaining elements of the stream</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        [Op, Closures(Closure)]
        public static Deferred<T> defer<T>(T head, params T[] tail)
            => defer(nes(head, tail));

        [Op, Closures(Closure)]
        static IEnumerable<T> nes<T>(T head, params T[] tail)
        {
            yield return head;
            foreach (var t in tail)
                yield return t;
        }

        /// <summary>
        /// Constructs a stream, possibly empty
        /// </summary>
        /// <param name="src">The stream elements</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Deferred<T> defer<T>(params T[] src)
            => src;

        /// <summary>
        /// Concatenates the source streams to create a unified stream
        /// </summary>
        /// <param name="head">The first part of the sequence</param>
        /// <param name="tail">The last part of the sequence</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Deferred<T> concat<T>(Deferred<T> head, Deferred<T> tail)
            => head.Concat(tail);

        /// <summary>
        /// Concatenates the source streams to create a unified stream
        /// </summary>
        /// <param name="s1">The leading segment</param>
        /// <param name="s2">The second segment</param>
        /// <param name="s3">The terminal segment</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Deferred<T> concat<T>(Deferred<T> s1, Deferred<T> s2, Deferred<T> s3)
            => s1.Concat(s2).Concat(s3);

        /// <summary>
        /// All of your streams belong to us
        /// </summary>
        /// <param name="src">The source streams</param>
        /// <typeparam name="T">The streamed element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Deferred<T> join<T>(params IEnumerable<T>[] src)
            => src.SelectMany(x => x);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Deferred<T> defer<T>(IEnumerable<T> src)
            => new Deferred<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Deferred<T> EmptyDeferral<T>()
            => Deferred<T>.Empty;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static IndexedSeq<T> EmptySeq<T>()
            => new IndexedSeq<T>(EmptyArray<T>(),true);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Indexed<T> EmptyIndex<T>()
            => new Indexed<T>(EmptyArray<T>());

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bit search<T>(in Indexed<T> src, Func<T,bool> predicate, out T found)
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

        /// <summary>
        /// Reduces a stream to a single value via a specified monoid
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The stream element type</typeparam>
        [MethodImpl(Inline)]
        public static T fold<H,T>(ReadOnlySpan<T> src, H monoid)
            where T : struct
            where H : struct, IMonoid<H,T>
        {
            var result = monoid.Identity;
            var count = src.Length;
            for(var i=0u; i<count; i++)
                result = monoid.Compose(result, z.skip(src,i));
            return result;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedList<object> delimited(params object[] src)
            => new DelimitedList<object>(src, FieldDelimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedList<T> delimited<T>(params T[] src)
            where T : unmanaged
                => new DelimitedList<T>(src, text.delimit, FieldDelimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedList<object> delimited(char delimiter, params object[] src)
            => new DelimitedList<object>(src, delimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedList<T> delimited<T>(char delimiter, params T[] src)
            where T : unmanaged
                => new DelimitedList<T>(src, text.delimit, delimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static EnclosedList<T> enclosed<T>(ListEnclosureKind kind, char delimiter, params T[] src)
            where T : unmanaged
                => new EnclosedList<T>(src, kind, delimiter);

        [MethodImpl(Inline)]
        public static DelimitedList<T> delimited<T>(IList<T> src, char delimiter = FieldDelimiter)
            => new DelimitedList<T>(array(src), delimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedList<T> delimited<T>(Span<T> src, char delimiter = FieldDelimiter)
            => new DelimitedList<T>(array(src), delimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DelimitedList<T> delimited<T>(ReadOnlySpan<T> src, char delimiter = FieldDelimiter)
            => new DelimitedList<T>(array(src), delimiter);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Indexed<T> filter<T>(in Indexed<T> src, Func<T,bool> predicate)
            => new Indexed<T>(from x in src.Data where predicate(x) select x);

        public static Indexed<Y> map<T,Y>(in Indexed<T> src, Func<T,Y> selector)
                => new Indexed<Y>(from x in src.Data select selector(x));

        public static Indexed<Z> map<T,Y,Z>(in Indexed<T> src, Func<T,Indexed<Y>> lift, Func<T,Y,Z> project)
            => new Indexed<Z>(array(from x in src.Data
                            from y in lift(x).Data
                            select project(x, y)));

        public static Indexed<Y> map<T,Y>(in Indexed<T> src, Func<T,Indexed<Y>> lift)
            => new Indexed<Y>(array(from x in src.Data
                            from y in lift(x).Data
                            select y));

        [MethodImpl(Inline)]
        public static KeyedValues<K,V> keyed<K,V>(KeyedValue<K,V>[] src)
            => new KeyedValues<K,V>(src);

        public static KeyedValues<K,V> keyed<K,V>(Dictionary<K,V> src)
            => new KeyedValues<K,V>(array(src.Select(x => KeyedValue.define(x.Key, x.Value))));

        public static KeyedValues<K,V> keyed<K,V>(K key, V[] values)
            => new KeyedValues<K,V>(array(values.Select(value => KeyedValue.define(key, value))));

        public static KeyedValues<K,V> keyed<K,V>(Paired<K,V>[] src)
            => new KeyedValues<K,V>(src.Select(x => new KeyedValue<K,V>(x.Left, x.Right)));

        [MethodImpl(NotInline)]
        static T[] array<T>(IEnumerable<T> src)
            => src.ToArray();

        [MethodImpl(NotInline)]
        static T[] array<T>(IList<T> src)
            => src.ToArray();

        [MethodImpl(NotInline)]
        static T[] array<T>(ReadOnlySpan<T> src)
            => src.ToArray();

        [MethodImpl(NotInline)]
        static T[] array<T>(Span<T> src)
            => src.ToArray();

        [MethodImpl(NotInline)]
        static T[] EmptyArray<T>()
            => Array.Empty<T>();
   }
}