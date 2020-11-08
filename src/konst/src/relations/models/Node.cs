//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Rules
    {
        public readonly struct Node<T> : INode<Node<T>,T>
        {
            public T Content {get;}

            public bool IsTerminal {get;}

            public bool IsNonEmpty {get;}

            [MethodImpl(Inline)]
            public Node(T content, bool terminal, bool nonempty)
            {
                Content = content;
                IsTerminal = terminal;
                IsNonEmpty = nonempty;
            }

            [MethodImpl(Inline)]
            public Node<T> Create(T content, bool terminal, bool empty)
                => new Node<T>(content, terminal, empty);

            public bool IsEmpty
            {
                [MethodImpl(Inline)]
                get => !IsNonEmpty;
            }

            public static Node<T> Empty => default;

            [MethodImpl(Inline)]
            public static implicit operator Node<T>(T src)
                => new Node<T>(src, false, false);
        }

        /// <summary>
        /// Defines a directed association from a source to a target
        /// </summary>
        public readonly struct Relation<S,T>
            where S : INode<S>
            where T : INode<T>
        {
            public S Source {get;}

            public T Target {get;}

            [MethodImpl(Inline)]
            public Relation(in S src, in T dst)
            {
                Source = src;
                Target = dst;
            }

            [MethodImpl(Inline)]
            public static implicit operator Relation<S,T>((S src, T dst) x)
                => new Relation<S,T>(x.src, x.dst);
        }

    }
}