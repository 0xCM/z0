//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TableRelation
    {
        public Arrow<TableId> Direction {get;}

        public TableRelationKind Kind {get;}

        [MethodImpl(Inline)]
        public TableRelation(Arrow<TableId> direction, TableRelationKind kind)
        {
            Direction = direction;
            Kind = kind;
        }
    }
}