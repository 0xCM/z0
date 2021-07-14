//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TableRelation<S,T>
        where S : struct
        where T : struct
    {
        public Arrow<S,T> Direction {get;}

        public TableRelationKind Kind {get;}

        [MethodImpl(Inline)]
        public TableRelation(Arrow<S,T> direction, TableRelationKind kind)
        {
            Direction = direction;
            Kind = kind;
        }

        public S Client
        {
            [MethodImpl(Inline)]
            get => Direction.Source;
        }

        public T Supplier
        {
            [MethodImpl(Inline)]
            get => Direction.Target;
        }
    }
}