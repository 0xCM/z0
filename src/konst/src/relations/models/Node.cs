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
        public T Content {get;}

        public bool IsNonEmpty {get;}

        [MethodImpl(Inline)]
        public Node(T content)
        {
            Content = content;
            IsNonEmpty = false;
        }

        [MethodImpl(Inline)]
        public Node(T content, bool empty)
        {
            Content = content;
            IsNonEmpty = empty;
        }

        [MethodImpl(Inline)]
        public Node<T> Create(T content)
            => new Node<T>(content);

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => !IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public static implicit operator Node<T>(T src)
            => new Node<T>(src, false);

        public static Node<T> Empty => default;
    }
}