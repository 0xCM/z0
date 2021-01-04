//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct MetaRowType<T>
        where T : struct, IRecord<T>
    {
        public MetaTableId<T> Table {get;}

        [MethodImpl(Inline)]
        public MetaRowType(TableIndex index)
        {
            Table = index;
        }

        [MethodImpl(Inline)]
        public static implicit operator MetaRowType<T>(TableIndex index)
            => new MetaRowType<T>(index);
    }
}