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