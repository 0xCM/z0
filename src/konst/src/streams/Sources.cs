//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct Sources
    {
        /// <summary>
        /// Produces stream of bytes
        /// </summary>
        /// <param name="source">The random source</param>
        [Op]
        public static Deferred<byte> bytes(IValueSource source)
            => Collective.defer(stream(w8, source));

        [Op]
        static IEnumerable<byte> stream(W8 w, IValueSource source)
        {
            while(true)
            {
                var u64 = source.Next<ulong>();
                for(byte i=0; i<8; i++)
                    yield return @byte(u64,i);
            }
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Triple<T> triple<T>(IValueSource source, T t = default)
            where T : struct
                => Tuples.triple(one(source, t), one(source, t), one(source, t));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static IEnumerable<Pair<T>> pairstream<T>(IValueSource source, T t = default)
            where T : struct
        {
            while(true)
                yield return pair(source,t);
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static IEnumerable<Triple<T>> triplestream<T>(IValueSource source, T t = default)
            where T : struct
        {
            while(true)
                yield return triple(source, t);
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Triples<T> triples<T>(IValueSource source, int count, T t = default)
            where T : struct
                => triplestream(source, t).Take(count).ToArray();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Triples<T> triples<T>(IValueSource source, Span<Triple<T>> dst, T t = default)
            where T : struct
                => z.store(triplestream(source, t).Take(dst.Length),dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Pair<T> pair<T>(IValueSource source, T t = default)
            where T : struct
                => Tuples.pair(one(source, t), one(source, t));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ConstPair<T> kpair<T>(IValueSource source, T t = default)
            where T : struct
                => (one(source, t), one(source, t));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ConstPair<T> kpair<T>(IDomainValues source, T min, T max)
            where T : struct
                => (next(source,min,max), next(source,min,max));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Pairs<T> pairs<T>(IValueSource source, int count, T t = default)
            where T : struct
                => pairstream(source,t).Take(count).ToArray();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Pairs<T> pairs<T>(IValueSource source, Span<Pair<T>> dst, T t = default)
            where T : struct
                => z.store(pairstream(source, t).Take(dst.Length),dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Pairs<T> pairs<T>(IValueSource source, Pair<T>[] dst, T t = default)
            where T : struct
                => z.store(pairstream(source, t).Take(dst.Length),dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T one<T>(IValueSource src, T t = default)
            where T : struct
                => src.Next<T>();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref readonly T one<T>(IRefSource<T> src)
            where T : struct
                => ref src.Next();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T next<T>(IDomainValues source, T max)
            where T : struct
                => source.Next<T>(max);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T next<T>(IDomainValues source, T min, T max)
            where T : struct
                => source.Next<T>(min, max);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static DataSnapshot<T> snapshot<T>(T[] src)
            where T : struct
                => snapshot(src,sys.alloc<int>(1));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static DataSnapshot<T> snapshot<T>(T[] src, int[] index)
            where T : struct
                => new DataSnapshot<T>(src, index);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ConstTriple<T> ktriple<T>(IValueSource source, T t = default)
            where T : struct
                => (one(source, t), one(source, t), one(source, t));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ConstTriple<T> ktriple<T>(IDomainValues source, T min, T max)
            where T : struct
                => (next(source,min,max), next(source,min,max), next(source,min,max));

        /// <summary>
        /// Yields a source-provided heterogenous pairs
        /// </summary>
        /// <param name="source">The value source</param>
        /// <typeparam name="S">The left value type</typeparam>
        /// <typeparam name="T">The right value type</typeparam>
        public static Paired<S,T> paired<S,T>(IValueSource source)
            where S : struct
            where T : struct
                => Tuples.paired(source.Next<S>(), source.Next<T>());

        /// <summary>
        /// Produces an interminable stream of <see cref='bit'/> values
        /// </summary>
        /// <param name="random">The value source</param>
        public static IEnumerable<bit> bitstream(IValueSource src)
        {
            while(true)
            {
                var data = src.Next<ulong>();
                for(byte i=0; i<64; i++)
                    yield return BitStates.test(data,i);
            }
        }

        /// <summary>
        /// Produces an interminable stream of random values from a numeric domain {0,1}
        /// </summary>
        /// <param name="random">The random source</param>
        /// <typeparam name="T">The numeric type</typeparam>
        public static IEnumerable<T> bitstream<T>(IValueSource src)
            where T : unmanaged
        {
            while(true)
            {
                var data = src.Next<ulong>();
                for(byte i=0; i<64; i++)
                    yield return z.force<byte,T>((byte)BitStates.test(data,i));
            }
        }
    }
}
