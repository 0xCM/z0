//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Adjacency<T>
        where T : unmanaged
    {
        public T A {get;}

        public T B {get;}

        [MethodImpl(Inline)]
        public Adjacency(T a, T b)
        {
            A = a;
            B = b;
        }
    }
}