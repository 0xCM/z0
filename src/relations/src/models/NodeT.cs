//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Node<T> : INode<T>
    {
        public uint Index {get;}

        public T Content {get;}

        [MethodImpl(Inline)]
        public Node(uint id, T content)
        {
            Index = id;
            Content = content;
        }

        public static Node<T> Empty => default;
    }
}