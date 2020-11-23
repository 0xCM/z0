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

    [ApiHost(ApiNames.Nodes, true)]
    public readonly partial struct Nodes
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Node<T> create<T>(T src)
            => new Node<T>(src);

        public static Projected<S,T> projected<S,T>(S src, T dst)
            => new Projected<S,T>(src,dst);
    }
}