//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct ClassifierMap
    {
        /// <summary>
        /// Creates a 0-based classifier map with at most <see cref='Pow2.T08'/> entries with indices of type <see cref='byte'/>
        /// </summary>
        /// <param name="w">The map width selector</param>
        /// <param name="src">The source classifiers</param>
        /// <typeparam name="K">The classifier type</typeparam>
        [Op, Closures(UInt8k)]
        public static ClassifierMap<byte,K> classify<K>(W8 w, K[] src)
            where K : unmanaged
        {
            var source = @readonly(src);
            var count = corefunc.min((byte)src.Length, U8.Max);
            var iK = alloc<Paired<byte,K>>(count);
            var Ki = alloc<Paired<K,byte>>(count);
            var indexed = span(iK);
            var kinds = span(Ki);
            project<K>(src, iK, Ki);
            return new ClassifierMap<byte,K>(count, iK, Ki);
        }

        /// <summary>
        /// Creates a 0-based classifier map with at most <see cref='Pow2.T16'/> entries with indices of type <see cref='ushort'/>
        /// </summary>
        /// <param name="w">The map width selector</param>
        /// <param name="src">The source classifiers</param>
        /// <typeparam name="K">The classifier type</typeparam>
        [Op, Closures(UInt16k)]
        public static ClassifierMap<ushort,K> classify<K>(W16 w, K[] src)
            where K : unmanaged
        {
            var source = @readonly(src);
            var count = corefunc.min((ushort)src.Length, U16.MaxLiteral);
            var iK = alloc<Paired<ushort,K>>(count);
            var Ki = alloc<Paired<K,ushort>>(count);
            var indexed = span(iK);
            var kinds = span(Ki);
            project<K>(src, iK, Ki);
            return new ClassifierMap<ushort,K>(count, iK, Ki);
        }

        /// <summary>
        /// Creates a 0-based classifier map with at most <see cref='Pow2.T32'/> entries with indices of type <see cref='uint'/>
        /// </summary>
        /// <param name="w">The map width selector</param>
        /// <param name="src">The source classifiers</param>
        /// <typeparam name="K">The classifier type</typeparam>
        [Op, Closures(UInt32k)]
        public static ClassifierMap<uint,K> classify<K>(W32 w, K[] src)
            where K : unmanaged
        {
            var source = @readonly(src);
            var count = corefunc.min((uint)src.Length, U32.Max);
            var iK = alloc<Paired<uint,K>>(count);
            var Ki = alloc<Paired<K,uint>>(count);
            var indexed = span(iK);
            var kinds = span(Ki);
            project<K>(src, iK, Ki);
            return new ClassifierMap<uint,K>(count, iK, Ki);
        }

        /// <summary>
        /// Creates a 0-based classifier map with at most <see cref='Pow2.T32'/> entries with indices of type <see cref='ulong'/>
        /// </summary>
        /// <param name="w">The map width selector</param>
        /// <param name="src">The source classifiers</param>
        /// <typeparam name="K">The classifier type</typeparam>
        [Op, Closures(UInt64k)]
        public static ClassifierMap<ulong,K> classify<K>(W64 w, K[] src)
            where K : unmanaged
        {
            var source = @readonly(src);
            var count = corefunc.min((ulong)src.Length, U32.Max);
            var iK = alloc<Paired<ulong,K>>(count);
            var Ki = alloc<Paired<K,ulong>>(count);
            var indexed = span(iK);
            var kinds = span(Ki);
            project<K>(src, iK, Ki);
            return new ClassifierMap<ulong,K>((uint)count, iK, Ki);
        }

        public static ClassifierMap<I,K> classify<I,K>(Paired<I,K>[] src)
            where I : unmanaged
            where K : unmanaged
        {
            var source = @readonly(src);
            var count = (uint)src.Length;
            var iK = alloc<Paired<I,K>>(count);
            var Ki = alloc<Paired<K,I>>(count);
            project(source,iK,Ki);
            return new ClassifierMap<I,K>(count, iK, Ki);
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void project<K>(ReadOnlySpan<K> src, Span<Paired<byte,K>> indexed, Span<Paired<K,byte>> kinds)
            where K : unmanaged
        {
            var count = src.Length;
            for(byte i=0; i<count; i++)
            {
                ref readonly var k = ref skip(src,i);
                ref var index = ref seek(indexed,i);
                index = (i,k);
                ref var kind = ref seek(kinds, i);
                kind = (k,i);
            }
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void project<K>(ReadOnlySpan<K> src, Span<Paired<ushort,K>> indexed, Span<Paired<K,ushort>> kinds)
            where K : unmanaged
        {
            var count = src.Length;
            for(ushort i=0; i<count; i++)
            {
                ref readonly var k = ref skip(src,i);
                ref var index = ref seek(indexed,i);
                index = (i,k);
                ref var kind = ref seek(kinds, i);
                kind = (k,i);
            }
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void project<K>(ReadOnlySpan<K> src, Span<Paired<uint,K>> indexed, Span<Paired<K,uint>> kinds)
            where K : unmanaged
        {
            var count = src.Length;
            for(ushort i=0; i<count; i++)
            {
                ref readonly var k = ref skip(src,i);
                ref var index = ref seek(indexed,i);
                index = (i,k);
                ref var kind = ref seek(kinds, i);
                kind = (k,i);
            }
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void project<K>(ReadOnlySpan<K> src, Span<Paired<ulong,K>> indexed, Span<Paired<K,ulong>> kinds)
            where K : unmanaged
        {
            var count = src.Length;
            for(ushort i=0; i<count; i++)
            {
                ref readonly var k = ref skip(src,i);
                ref var index = ref seek(indexed,i);
                index = (i,k);
                ref var kind = ref seek(kinds, i);
                kind = (k,i);
            }
        }

        [MethodImpl(Inline)]
        public static void project<I,K>(ReadOnlySpan<Paired<I,K>> src, Span<Paired<I,K>> indexed, Span<Paired<K,I>> kinds)
            where I : unmanaged
            where K : unmanaged
        {
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var pair = ref skip(src,i);
                ref var index = ref seek(indexed,i);
                index = pair;
                ref var kind = ref seek(kinds,i);
                kind = (pair.Right, pair.Left);
            }
        }

        [MethodImpl(Inline)]
        public static StackedClassifierMap<I,K> stack<I,K>(ClassifierMap<I,K> src)
            where I : unmanaged
            where K : unmanaged
                => src;
    }
}