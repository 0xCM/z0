//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a vertex to which data may be attached
    /// </summary>
    /// <typeparam name="I">The vertex index type</typeparam>
    /// <typeparam name="T">The payload type</typeparam>
    public readonly struct Node<I,T>
        where I : unmanaged
    {
        /// <summary>
        /// The index of the vertex that uniquely identifies it within a graph
        /// </summary>
        public I Index {get;}

        /// <summary>
        /// The vertex payload
        /// </summary>
        public T Content {get;}

        [MethodImpl(Inline)]
        public Node(I index, T content)
        {
            Index = index;
            Content = content;
        }

        public string Format()
            => string.Format("{0}:{1}", Index, Content);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static Link<I> operator +(in Node<I,T> src, in Node<I,T> dst)
            => new Link<I>(src.Index, dst.Index);

        /// <summary>
        /// Sheds the associated data to form a payload-free vertex
        /// </summary>
        /// <param name="src">The source vertex</param>
        [MethodImpl(Inline)]
        public static implicit operator Node<I>(in Node<I,T> src)
            => new Node<I>(src.Index);
    }
}