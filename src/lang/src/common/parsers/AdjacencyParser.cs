//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct SyntaxParsers
    {
        public readonly struct AdjacencyParser<T>
            where T : unmanaged
        {
            public T A {get;}

            public T B {get;}

            [MethodImpl(Inline)]
            public AdjacencyParser(T a, T b)
            {
                A = a;
                B = b;
            }
        }
    }
}