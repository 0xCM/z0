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

    public struct Relation<A,B>
    {
        public readonly A First;

        public readonly B Second;

        [MethodImpl(Inline)]
        public static implicit operator Relation<A,B>(Paired<A,B> src)
            => new Relation<A,B>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public Relation(A a, B b)
        {
            First = a;
            Second = b;
        }
    }
}