//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;

    partial struct Relations
    {
        /// <summary>
        /// Defines a vertex with payload for each source item
        /// </summary>
        /// <param name="s0">The first index assigned</param>
        /// <param name="data">The vertex payloads</param>
        /// <typeparam name="V">The index type</typeparam>
        public static Index<Node<V,T>> nodes<V,T>(V s0, params T[] data)
            where V : unmanaged
            where T : unmanaged
        {
            var start = NumericCast.force<V,ulong>(s0);
            var buffer = alloc<Node<V,T>>(data.Length);
            Span<Node<V,T>> dst = buffer;

            for(var i=0; i<data.Length; i++, start++)
                dst[i] = new Node<V,T>(NumericCast.force<V>(start), data[i]);
            return buffer;
        }

        /// <summary>
        /// Defines a vertex sequence with a specified length
        /// </summary>
        /// <param name="count">The number of virtices in the sequence</param>
        /// <typeparam name="V">The index type</typeparam>
        public static Index<Node<V>> nodes<V>(int count)
            where V : unmanaged
        {
            var buffer = alloc<Node<V>>(count);
            Span<Node<V>> dst = buffer;
            for(var i=0; i<count; i++)
                seek(dst,i) = new Node<V>(NumericCast.force<V>(i));
            return buffer;
        }
    }
}