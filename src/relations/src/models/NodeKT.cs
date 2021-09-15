//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Defines a vertex to which data may be attached
    /// </summary>
    /// <typeparam name="K">The vertex index type</typeparam>
    /// <typeparam name="T">The payload type</typeparam>
    public readonly struct Node<K,T>
        where K : unmanaged
    {
        /// <summary>
        /// The index of the vertex that uniquely identifies it within a graph
        /// </summary>
        public K Index {get;}

        /// <summary>
        /// The vertex payload
        /// </summary>
        public T Content {get;}

        [MethodImpl(Inline)]
        public Node(K index, T content)
        {
            Index = index;
            Content = content;
        }

        public string Format()
            => string.Format("({0},{1})", Index, Content);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static Arrow<K> operator +(in Node<K,T> src, in Node<K,T> dst)
            => new Arrow<K>(src.Index, dst.Index);

        /// <summary>
        /// Sheds the associated data to form a payload-free vertex
        /// </summary>
        /// <param name="src">The source vertex</param>
        [MethodImpl(Inline)]
        public static implicit operator Node<T>(in Node<K,T> src)
            => new Node<T>(core.bw32(src.Index), src.Content);
    }
}