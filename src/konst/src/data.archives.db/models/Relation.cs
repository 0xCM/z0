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

    partial struct Db
    {
        public readonly struct Relation
        {
            public ObjectName Source {get;}

            public ObjectName Target {get;}

            [MethodImpl(Inline)]
            public Relation(in ObjectName src, in ObjectName dst)
            {
                Source = src;
                Target = dst;
            }

            [MethodImpl(Inline)]
            public static implicit operator Relation((ObjectName src, ObjectName dst) x)
                => new Relation(x.src, x.dst);

            [MethodImpl(Inline)]
            public static implicit operator Relation(Pair<ObjectName> x)
                => new Relation(x.Left, x.Right);
        }

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
}