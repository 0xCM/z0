//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;


    [ApiHost]
    public readonly partial struct Trees
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Leaf<T> leaf<T>(T src)
            => new Leaf<T>(src);

        // [MethodImpl(Inline)]
        // public static Branch<B,L> branch<T>(Index<Branch> b, Index<L> l)
        //     where B : IBranch
        //     where L : ILeaf
        //         => new Branch<B,L>(b, l);


        [MethodImpl(Inline)]
        public static Branch<B,L> branch<B,L>(Index<B> b, Index<L> l)
            where B : IBranch
            where L : ILeaf
                => new Branch<B,L>(b, l);

    }
}