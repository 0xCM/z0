//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct Node<T> : INode<T>
    {
        public uint Index;

        public T Content;

        [MethodImpl(Inline)]
        public Node(uint id, T content)
        {
            Index = id;
            Content = content;
        }

        T INode<T>.Content
            => Content;

        uint INode.Index
            => Index;

        public static Node<T> Empty => default;
    }
}