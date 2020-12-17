//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Node<T> : INode<Node<T>,T>
    {
        public Label Label {get;}

        public T Content {get;}

        [MethodImpl(Inline)]
        public Node(T content, Label? label = null)
        {
            Content = content;
            Label = label ?? Label.Empty;
        }

        [MethodImpl(Inline)]
        public static implicit operator Node<T>(T src)
            => new Node<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator T(Node<T> src)
            => src.Content;

        public static Node<T> Empty => default;
    }
}