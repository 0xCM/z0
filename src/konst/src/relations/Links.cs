//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct Links
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Defines an edge from an index-identified source to an index identified target
        /// </summary>
        /// <param name="source">The source index</param>
        /// <param name="target">The target index</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Arrow<T> link<T>(T src, T dst)
            => new Arrow<T>(src,dst);

        /// <summary>
        /// Defines a link from a source to a target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">THe target</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Arrow<S,T> link<S,T>(S src, T dst)
            => new Arrow<S,T>(src, dst);

        [MethodImpl(Inline)]
        public static Arrow<S,T,K> link<S,T,K>(S src, T dst, K kind)
            where K : unmanaged
                => new Arrow<S,T,K>(src, dst, kind);

        /// <summary>
        /// Connects a source vertex to a target vertex
        /// </summary>
        /// <param name="src">The source vertex</param>
        /// <param name="dst">The target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        /// <typeparam name="T">The vertex payload type</typeparam>
        [MethodImpl(Inline)]
        public static Arrow<T> connect<T>(Node<T> src, Node<T> dst)
            where T : unmanaged
                => new Arrow<T>(src, dst);

        /// <summary>
        /// Connects a source vertex to a target vertex
        /// </summary>
        /// <param name="src">The source vertex</param>
        /// <param name="dst">The target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        /// <typeparam name="T">The vertex payload type</typeparam>
        [MethodImpl(Inline)]
        public static Arrow<V> connect<V,T>(in Node<V,T> src, in Node<V,T> dst)
            where V : unmanaged
            where T : unmanaged
                => new Arrow<V>(src.Index, dst.Index);

        /// <summary>
        /// Defines a vertex sequence with a specified length
        /// </summary>
        /// <param name="count">The number of virtices in the sequence</param>
        /// <typeparam name="V">The index type</typeparam>
        public static Span<Node<V>> nodes<V>(int count)
            where V : unmanaged
        {
            Span<Node<V>> dst = new Node<V>[count];
            for(var i=0; i<count; i++)
                dst[i] = new Node<V>(Numeric.force<V>(i));
            return dst;
        }

        /// <summary>
        /// Defines a vertex with payload for each source item
        /// </summary>
        /// <param name="s0">The first index assigned</param>
        /// <param name="data">The vertex payloads</param>
        /// <typeparam name="V">The index type</typeparam>
        public static Span<Node<V,T>> nodes<V,T>(V s0, params T[] data)
            where V : unmanaged
            where T : unmanaged
        {
            var start = Numeric.force<V,ulong>(s0);
            Span<Node<V,T>> dst = new Node<V,T>[data.Length];

            for(var i=0; i<data.Length; i++, start++)
                dst[i] = new Node<V,T>(Numeric.force<V>(start),data[i]);
            return dst;
        }

        /// <summary>
        /// Creates a vertex with payload
        /// </summary>
        /// <param name="index">The index of the vertex that servies as a
        /// unique identifier within the context of a graph</param>
        /// <typeparam name="V">The index type</typeparam>
        /// <typeparam name="V">The payload type</typeparam>
        [MethodImpl(Inline)]
        public static Node<V,T> node<V,T>(V index, T data)
            where V : unmanaged
            where T : unmanaged
                => new Node<V,T>(index,data);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Node<T> node<T>(T src)
            => new Node<T>(src);

        [Op, Closures(Closure)]
        public static string format(LinkType t)
            => render<string>().Format(t.Source.Name, t.Target.Name);

        [Op, Closures(Closure)]
        public static string format<T>(LinkType<T> src)
            => render<string>().Format(src.Source.Name, src.Target.Name);

        public static string format<S,T>(LinkType<S,T> src)
            => render<string>().Format(src.Source.Name, src.Target.Name);

        public static RenderPattern<S,T> render<S,T>() => "{0} -> {1}";

        public static RenderPattern<T,T> render<T>() => render<T,T>();
    }
}
