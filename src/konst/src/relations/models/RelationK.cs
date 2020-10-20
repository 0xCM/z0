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

    public readonly struct Relation<K>
        where K : unmanaged
    {
        public K Kind {get;}

        public Relation Definition {get;}

        [MethodImpl(Inline)]
        public Relation(K kind, ObjectName src, ObjectName dst)
        {
            Kind = kind;
            Definition = pair(src,dst);
        }

        [MethodImpl(Inline)]
        public Relation(K kind, Relation spec)
        {
            Kind = kind;
            Definition = spec;
        }

        [MethodImpl(Inline)]
        public static implicit operator Relation<K>(Paired<K,Relation> x)
            => new Relation<K>(x.Left, x.Right);
    }
}