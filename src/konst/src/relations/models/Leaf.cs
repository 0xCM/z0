//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Leaf<T> : ILeaf<T>
    {
        public T Content {get;}

        [MethodImpl(Inline)]
        public Leaf(T content)
        {
            Content = content;
        }
    }
}