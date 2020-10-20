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

   public readonly struct Relation<K,A>
        where K : unmanaged
        where A : struct
    {
        public Relation<K> Definition {get;}

        public A Aspects {get;}

        [MethodImpl(Inline)]
        public Relation(Relation<K> spec, A aspects)
        {
            Definition = spec;
            Aspects = aspects;
        }

        [MethodImpl(Inline)]
        public static implicit operator Relation<K,A>(Paired<Relation<K>,A> x)
            => new Relation<K,A>(x.Left, x.Right);
    }
}