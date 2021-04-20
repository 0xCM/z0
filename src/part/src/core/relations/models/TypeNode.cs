//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Relations
    {
        public readonly struct TypeNode : INode
        {
            public Label Label {get;}

            [MethodImpl(Inline)]
            public TypeNode(Type src)
            {
                Label = src.Name;
            }

            [MethodImpl(Inline)]
            public string Format()
                => Label;

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator TypeNode(Type src)
                => new TypeNode(src);

            public static TypeNode Empty => new TypeNode(typeof(void));
        }
    }
}