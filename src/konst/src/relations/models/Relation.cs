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
}