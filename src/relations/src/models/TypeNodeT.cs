//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Relations
    {
        public readonly struct TypeNode<T> : INode
        {
            public Label Label => typeof(T).Name;

            [MethodImpl(Inline)]
            public static implicit operator TypeNode<T>(T src)
                => new TypeNode<T>();

            [MethodImpl(Inline)]
            public static implicit operator TypeNode(TypeNode<T> src)
                => new TypeNode(typeof(T));

            public static TypeNode<T> Empty => default;
        }
    }
}